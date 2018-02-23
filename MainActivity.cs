using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.IO;
using Android.Content.Res;
using Android.Util;
using Android.Content;
namespace Scan_Android
{
    [Activity(Label = "Scan_Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);
            var editText = FindViewById<EditText>(Resource.Id.editText);
            TextView textv = FindViewById<TextView>(Resource.Id.textView2);


            string content;
            string inputText;

            button.Click += delegate
            {
               

                inputText = editText.Text.ToString();
                inputText = inputText.ToUpper();
                AssetManager assets = this.Assets;

                using (StreamReader sr = new StreamReader(assets.Open("MemID.txt")))
                { content = sr.ReadToEnd(); }

                //Log.Error(inputTextCAP, "CAP");

                if (inputText == content)
                {
                    textv.Text = "";
                    string tag = "confirm";

                    Log.Info(tag, "they match");

                    Intent nextActivity = new Intent(this, typeof(ScanPage));
                    StartActivity(nextActivity);
                   
                }

                else
                {
                    textv.Text = "Invalid Login Credentials, Please Try Again.";

                    string tag = "deny";

                    Log.Info(tag, "they dont");
                }

            };
          

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

