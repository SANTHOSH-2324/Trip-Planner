using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using Trip_Planner.Class;
namespace Trip_Planner
{
    [Activity(Label = "recycle")]
    public class Recycle : Activity
    {
        List<DataCard> list = new List<DataCard>();
        private RecyclerView recycler;
        private Recycler adapter;
        private RecyclerView.LayoutManager lm;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            setdata();
            SetContentView(Resource.Layout.recycler);
            recycler = FindViewById<RecyclerView>(Resource.Id.recyler);
            recycler.HasFixedSize = true;
            lm = new LinearLayoutManager(this);
            recycler.SetLayoutManager(lm);
            adapter = new Recycler(list);
            recycler.SetAdapter(adapter);

        }

        private void setdata()
        {
            list.Add(new DataCard { imageid = Resource.Drawable.alapuzha, text = "Alapuzha" });
            list.Add(new DataCard { imageid = Resource.Drawable.allepey, text = "Allepey" });
            list.Add(new DataCard { imageid = Resource.Drawable.Munnar, text = "Munnar" });
            list.Add(new DataCard { imageid = Resource.Drawable.thekkady, text = "thekkady" });
            list.Add(new DataCard { imageid = Resource.Drawable.vagamon, text = "vagmon" });
            list.Add(new DataCard { imageid = Resource.Drawable.Varkala, text = "varkala" });


        }
    }
}