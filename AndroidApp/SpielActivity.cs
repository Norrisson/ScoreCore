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
    [Activity()]
    public class SpielActivity : Activity
    {
		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LayoutSpiel);

		

			// Create your application here
			Player p1 = new Player(1);
            Player p2 = new Player(2);
			Player p3 = new Player(3);
			Player p4 = new Player(4);

			p1.setupControls(FindViewById<Button>(Resource.Id.buttonPlayer1Add), FindViewById<EditText>(Resource.Id.editTextPlayer1));
			p2.setupControls(FindViewById<Button>(Resource.Id.buttonPlayer2Add), FindViewById<EditText>(Resource.Id.editTextPlayer2));

			Team teamRed = new Team();
			//Team teamBlue = new Team();

			teamRed.setupControls(FindViewById<TextView>(Resource.Id.textViewTeamRed));
			//teamBlue.setupControls(FindViewById<TextView>(Resource.Id.textViewTeamBlue));

			teamRed.addPlayer(p1);
			teamRed.addPlayer(p2);
			//teamBlue.addPlayer(p3);
			//teamBlue.addPlayer(p4);
		}
    }

}