using Android.App;
using Android.OS;
using Android.Widget;

namespace Trip_Planner
{
    [Activity(Label = "Frame")]
    public class Frame : Activity
    {
        TextView t1, t2;
        Button b1, b2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Frame);
            t1 = FindViewById<TextView>(Resource.Id.textView1);
            t2 = FindViewById<TextView>(Resource.Id.textView2);
            b1 = FindViewById<Button>(Resource.Id.button1);
            b2 = FindViewById<Button>(Resource.Id.button2);
           // b1.Click += Insertbtn;
            //b2.Click += Show;
        }
       /* public void Insertbtn(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=sql12.freesqldatabase.com;Port=3306;database=sql12647059;User Id=sql12647059;Password =xq4jEEigj9;charset=utf88");
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    t2.Text = "Success";
                }
            }
            catch (Exception ex)
            {
                t2.Text += ex.Message;
            }
            finally { conn.Close(); }
        }
        public void Show(object sender, EventArgs e)
        {

        }
       */
    }
}