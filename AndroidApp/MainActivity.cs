using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
    [Activity(Label = "RoM Kick App", MainLauncher = true, Icon = "@drawable/icon")] //This is what controls orientation
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);
            //button.Click += delegate { button.Text = string.Format("{0} Tore!", count++); };

            Button buttonGame = FindViewById<Button>(Resource.Id.buttonGame);
            buttonGame.Click += delegate { StartActivity(typeof(SpielActivity)); ; };

			Button buttonAddPlayer = FindViewById<Button>(Resource.Id.buttonAddPlayer);
			buttonAddPlayer.Click += delegate { StartActivity(typeof(PlayerActivity)); ; };

			DB_Manager db = new DB_Manager();

		}
    }
}

