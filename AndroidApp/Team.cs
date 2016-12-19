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
	class Team
	{
		int id;
		List<Player> players = new List<Player>();

		TextView txtScore;

		public int TeamScore
		{
			get	{ return players.Sum(p => p.goals); }
		}

		public void setupControls(TextView txt)
		{
			this.txtScore = txt;
		}

		public void addPlayer(Player p)
		{
			p.Changed += delegate { refreshControls(); };
			this.players.Add(p);
		}

		public void refreshControls()
		{
			txtScore.Text = TeamScore.ToString();
		}
	}
}