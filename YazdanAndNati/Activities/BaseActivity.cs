using Android.App;
using AndroidX.AppCompat.App;
using Android.OS;
using System;

namespace YazdanAndNati.Activities
{
    [Activity(Label = "BaseActivity")]
    public abstract class BaseActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}