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

namespace Scan_Android
{
    class Item: Java.Lang.Object, Java.IO.ISerializable
    {
        public Item(string name, int quantity = 0)
        {
            this.name = name;

        }
        int quantity;
        string code;
        string name;

        public void SetQuantity(int amount)
        {
            this.quantity = amount;
        }

        public void SetCode(string code)
        {
            this.code = code;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetCode()
        {
            return code;
        }

       override public string ToString()
        {
            return "" + name + " - " + quantity;
        }
    }
}