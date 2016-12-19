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
	public class PlayerActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.LayoutPlayer);

			// Create your application here
		}

		private bool checkInput()
		{
			bool ok = true;
			string name = FindViewById<EditText>(Resource.Id.editTextPlayerName).Text;
			if (name.Length < 3)
			{
				ok = false;
				AlertDialog.Builder alert = new AlertDialog.Builder(this);
				alert.SetTitle("Benutzername");
				alert.SetMessage("Der Benutzername muss mindestens 3 Zeichen enthalten");
				alert.SetPositiveButton("OK", (senderAlert, args) => {
					Toast.MakeText(this, "Deleted!", ToastLength.Short).Show();
				});

				Dialog dialog = alert.Create();
				dialog.Show();
			}



			return ok;
		}
	}
}