using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.Widget;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Trip_Planner.Class;
using AndroidX.RecyclerView.Widget;

namespace Trip_Planner
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private ImageView img1;
        private RecyclerView recycler;
        private Recycler adapter;
        private RecyclerView.LayoutManager lm;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            img1 = FindViewById<ImageView>(Resource.Id.imageView1);
            img1.Click += Frame1;
        }
        public void Frame1(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Frame));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}