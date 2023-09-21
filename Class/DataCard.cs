using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trip_Planner.Class
{
    class DataCard
    {
        public int imageid { get; set; }
        public string text { get; set; }

        List<DataCard> list;
    }
}