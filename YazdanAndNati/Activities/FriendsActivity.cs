using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using MODEL;
using System;
using YazdanAndNati.Adapters;

namespace YazdanAndNati.Activities
{
    [Activity(Label = "FriendsActivity")]
    public class FriendsActivity : Activity
    {
        private RecyclerView rvFriends;
        private Friends friends;
        private FriendsAdapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.FriendsLayout);

            InitializeViews();
            SetRecyclerView();
        }

        private void InitializeViews()
        {
            this.friends = new Friends();
            rvFriends = FindViewById<RecyclerView>(Resource.Id.rvFriends);
            
        }

        public void SetRecyclerView()
        {
            adapter = new FriendsAdapter(friends);
            rvFriends.SetAdapter(adapter);
            rvFriends.SetLayoutManager(new LinearLayoutManager(this));
            rvFriends.AddItemDecoration(new DividerItemDecoration(this, DividerItemDecoration.Vertical));

        }
    }
}