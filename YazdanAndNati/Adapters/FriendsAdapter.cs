using AndroidX.RecyclerView.Widget;
using Android.Views;
using Android.Widget;
using System;
using MODEL;

namespace YazdanAndNati.Adapters
{
    public class FriendsAdapter : RecyclerView.Adapter
    {
        public event EventHandler<FriendsAdapterClickEventArgs> ItemClick;
        public event EventHandler<FriendsAdapterClickEventArgs> ItemLongClick;
        private Friends items;

        public FriendsAdapter(Friends data)
        {
            items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.FriendsLayout, parent, false);

            var vh = new FriendsAdapterViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as FriendsAdapterViewHolder;
            holder.FullName.Text = item.FullName;
            holder.Email.Text = item.Email;
            holder.Age.Text = item.Age.ToString();
        }

        public override int ItemCount => (items != null) ? items.Count : 0;

        void OnClick(FriendsAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(FriendsAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class FriendsAdapterViewHolder : RecyclerView.ViewHolder
    {
        public TextView FullName { get; set; }
        public TextView Email { get; set; }
        public TextView Age { get; set; }


        public FriendsAdapterViewHolder(View itemView, Action<FriendsAdapterClickEventArgs> clickListener,
                            Action<FriendsAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            FullName = ItemView.FindViewById<TextView>(Resource.Id.tvFullName);
            Email = ItemView.FindViewById<TextView>(Resource.Id.tvEmail);
            Age = ItemView.FindViewById<TextView>(Resource.Id.tvAge);
            itemView.Click += (sender, e) => clickListener(new FriendsAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new FriendsAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        }

    }

    public class FriendsAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}