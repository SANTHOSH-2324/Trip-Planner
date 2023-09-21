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

namespace Trip_Planner
{
    [Activity(Label = "LoginorRegister")]
    public class LoginorRegister : Activity
    {
        private ImageView img_login, img_reg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginPage);
            // Create your application here
            img_login = FindViewById<ImageView>(Resource.Id.login);
            img_reg = FindViewById<ImageView>(Resource.Id.register);
            img_login.Click += login;
            img_reg.Click += register;
        }

        private void register(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Login));
            StartActivity(intent);
        }

        public void login(Object sender,EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Login));
            StartActivity(intent);
        }
    }
}