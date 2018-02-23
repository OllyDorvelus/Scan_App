using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.IO;
using Android.Content.Res;
using Android.Util;
using Android.Content;
using Newtonsoft.Json;

namespace Scan_Android
{
    [Activity(Label = "QuantityPage")]
    public class QuantityPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.QuantityPage);
            var quantityButton = FindViewById<Button>(Resource.Id.quantityButton);
            var label = FindViewById<TextView>(Resource.Id.quantityLabel);
            // Item myItem = (Item)Intent.GetSerializableExtra("thisItem");
            //string myItem2 = Intent.GetStringExtra("thisItem2");
            //var MyJsonString = Intent.GetStringExtra("thisItem");
            // var MyObject = JsonConvert.DeserializeObject<Item>(MyJsonString);

            quantityButton.Click += delegate
            {
                //Intent nextActivity = new Intent(this, typeof(ScanPage));
                //nextActivity.PutExtra("Item", 3);
                // StartActivity(nextActivity);
                quantityCheck();
            };

            // Create your application here
        }
        void quantityCheck()
        {
            var inputNum = FindViewById<EditText>(Resource.Id.editNumber);
            var label = FindViewById<TextView>(Resource.Id.quantityLabel);
            int quantity = 0;
            var quantityString = inputNum.Text.ToString();
            var myItem = JsonConvert.DeserializeObject<Item>(Intent.GetStringExtra("thisItem"));
            var name = Intent.GetStringExtra("name");
            myItem.SetName(name);
            // label.Text = myItem.ToString();
            if (quantityString == "")
            {
                label.Text = "Please enter a quantity";
            }
            else
            {
                quantity = Int32.Parse(quantityString);
                myItem.SetQuantity(quantity);
                Intent scanActivity = new Intent();
                scanActivity.PutExtra("recieveItem", JsonConvert.SerializeObject(myItem));
                base.OnBackPressed();
            }

        }
    }
}