using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using KillerClient.Common;

namespace KillerClient
{
    [Activity(Label = "KillerClient", MainLauncher = true, Icon = "@drawable/iconKiller")]
    public class MainActivity : Activity
    {
        private ProcessusAdapter Adapter;
        private List<Processus> Processus;
        private ListView ProcessusListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ProcessusListView = FindViewById<ListView>(Resource.Id.listProcessus);

            var configButton = FindViewById<ImageButton>(Resource.Id.btnSettings);
            configButton.Click += (sender, args) =>
            {
                StartActivity(new Intent(this, typeof (ConfigActivity)));
            };

            if (!ConfigManager.ConfigFileExists)
            {
                StartActivity(new Intent(this, typeof(ConfigActivity)));
            }
        }

        protected override void OnResume()
        {
            base.OnResume();

            Processus = ProcessusManager.GetProcessus();

            Adapter = new ProcessusAdapter(this, Processus);

            ProcessusListView.Adapter = Adapter;
        }
    }
}

