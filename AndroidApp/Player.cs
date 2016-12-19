using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidApp
{
	public delegate void ChangedEventHandler(object sender, EventArgs e);

	public class Player 
    {
        int id;
        int number;
        string name;
        int _goals=0;
        public int goals
        {
            get { return _goals; }
            set
			{
				if (_goals!=value)
					_goals = value;
					scoreCount.Text = _goals.ToString();
					OnChanged(EventArgs.Empty);
			}
        }

        Button plus;
		EditText scoreCount;

		public event ChangedEventHandler Changed;
		protected virtual void OnChanged(EventArgs e)
		{
			if (Changed != null)
				Changed(this, e);
		}

		public Player(int nr)
        {
            this.number  = nr;
            this.name = string.Format("Player {0}", nr);
        }

        public void setupControls(Button plus, EditText text)
        {
            this.plus = plus;
            this.scoreCount = text;

            this.plus.Click += delegate {goals++; };
            this.scoreCount.AfterTextChanged += delegate 
			{
				int score;
				int.TryParse(scoreCount.Text,out score);
				if (goals != score)
					goals = score;
			};
        }
    }
}