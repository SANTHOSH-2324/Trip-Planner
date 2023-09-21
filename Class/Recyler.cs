using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Trip_Planner.Class
{
    public class RecylerViewHolder : RecyclerView.ViewHolder
    {
        public ImageView card_img { get; set; }
        public TextView card_text { get; set; }

        public RecylerViewHolder(View view) : base(view)
        {
            card_img = view.FindViewById<ImageView>(Resource.Id.card_img_1);
            card_text = view.FindViewById<TextView>(Resource.Id.card_text_1);
        }
    }

    class Recycler : RecyclerView.Adapter
    {

        private List<DataCard> list = new List<DataCard>();

        public Recycler(List<DataCard> list)
        {
            this.list = list;
        }

        public override int ItemCount
        {
            get
            {
                return list.Count();
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecylerViewHolder viewholder = holder as RecylerViewHolder;
            viewholder.card_img.SetImageResource(list[position].imageid);
            viewholder.card_text.Text = list[position].text;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflate = LayoutInflater.From(parent.Context);
            View view = inflate.Inflate(Resource.Layout.Cardview,parent,false);
            return new RecylerViewHolder(view);
        }
    }
}