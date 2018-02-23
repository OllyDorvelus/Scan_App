using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.IO;
using Android.Content.Res;
using Android.Util;
using Android.Content;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Scan_Android
{
    [Activity(Label = "ScanPage")]
    public class ScanPage : Activity
    {
        string[] items;
        private List<string> mItems;
        private List<Item> ItemList;
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.ScanPage);
            ListView listView = FindViewById<ListView>(Resource.Id.ScanList);
            var scanButton = FindViewById<Button>(Resource.Id.scanButton);
            var checkoutBtn = FindViewById<Button>(Resource.Id.checkoutBtn);
            ItemList = new List<Item>();
            mItems = new List<string>();
            checkoutBtn.Click += delegate
            {
                checkOut();
            };

            scanButton.Click += delegate
            {
                string code = OnScan();
                Item myItem = new Item(code);
                myItem.SetName(code);
                ItemList.Insert(0, myItem);
                
                mItems.Insert(0, code);
                ArrayAdapter<string> ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
                //listView.Adapter = ListAdapter;
                listView.Adapter = ListAdapter;
                Intent nextActivity = new Intent(this, typeof(QuantityPage));
                //nextActivity.PutExtra("Item", 3);
                //LoggedInUser myUser = (LoggedInUser)Intent.GetSerializableExtra("User");
                // nextActivity.putSerr("thisItem", myItem);
                //var MySerializedObject = JsonConvert.SerializeObject(myItem);
                //nextActivity.PutExtra("thisItem", MySerializedObject);
                nextActivity.PutExtra("thisItem", JsonConvert.SerializeObject(myItem));
                nextActivity.PutExtra("name", myItem.GetName());
               // nextActivity.PutExtra("thisItem2", "Okay");
                StartActivity(nextActivity);
        
    };
            // var scanText = FindViewById<EditText>(Resource.Id.editScan);
            
            
            //  mItems = new List<string>();
            //  mItems.Insert(0, "Bob");
            //  mItems.Insert(0, "Tom");
            //  mItems.Insert(0, "Jim");
            items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };

        }

        string OnScan()
               {
                //   string temp;
                var scanText = FindViewById<EditText>(Resource.Id.editScan);
                var inputText = scanText.Text.ToString();
                inputText = inputText.ToUpper();
            //  temp = "3n3nfcj39jevje";
                   
                   return inputText;
               }
        void checkOut()
        {
            Intent nextActivity = new Intent(this, typeof(CheckoutPage));
            StartActivity(nextActivity);
        }
        }
    }
