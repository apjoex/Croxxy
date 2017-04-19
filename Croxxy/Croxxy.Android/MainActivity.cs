using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Croxxy.Droid
{
	[Activity (Label = "Croxxy", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
	public class MainActivity : AppCompatActivity
    {

        //int count = 1;
        Button demoBtn;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button> (Resource.Id.myButton);
            //button.Click += delegate {
            //	button.Text = string.Format ("{0} clicks!", count++);
            //	};

            // var realm = Realm.GetInstance;

            demoBtn = FindViewById<Button>(Resource.Id.demoBtn);



            demoBtn.Click += DemoBtn_Click;

		}

        private void DemoBtn_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();

            Toast toast = Toast.MakeText(this, "This is my toast message", ToastLength.Long);
            toast.Show();
        }
    }
}


