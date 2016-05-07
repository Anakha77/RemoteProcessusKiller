using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Widget;
using KillerClient.Common;
using KillerClient.Resources;

namespace KillerClient
{
    [Activity(Label = "KillerClient", MainLauncher = true, Icon = "@drawable/iconKiller")]
    public class MainActivity : Activity
    {
        private ProcessusAdapter _adapter;
        private List<Processus> _processus;
        private ListView _processusListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _processusListView = FindViewById<ListView>(Resource.Id.listProcessus);

            var configButton = FindViewById<ImageButton>(Resource.Id.btnSettings);
            var refreshButton = FindViewById<Button>(Resource.Id.Reload);

            configButton.Click += (sender, args) =>
            {
                StartActivity(new Intent(this, typeof (ConfigActivity)));
            };
            refreshButton.Click += async delegate
            {
                await LoadProcessusListAsync();
            };

            if (!ConfigManager.ConfigFileExists)
            {
                StartActivity(new Intent(this, typeof(ConfigActivity)));
            }

            var swipeLayout = FindViewById<SwipeRefreshLayout>(Resource.Id.swipeLayout);
            swipeLayout.Refresh += async delegate
            {
                await LoadProcessusListAsync();
                swipeLayout.Refreshing = false;
            };
        }

        protected async Task LoadProcessusListAsync()
        {
            try
            {
                _processus = await ProcessusManager.GetProcessusAsync();
                _adapter = new ProcessusAdapter(this, _processus);

                _processusListView.Adapter = _adapter;
            }
            catch (Exception e)
            {
                var t = Toast.MakeText(this, e.Message, ToastLength.Long);
                t.Show();
            }
        }
    }
}

