using Android.App;
using Android.OS;
using Android.Widget;
using KillerClient.Common;

namespace KillerClient
{
    [Activity(Label = "ConfigActivity")]
    public class ConfigActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Config);

            var config = ConfigManager.LoadConfiguration();

            var editServer = FindViewById<EditText>(Resource.Id.server);
            var editPort = FindViewById<EditText>(Resource.Id.port);
            var editPin = FindViewById<EditText>(Resource.Id.pin);

            editServer.Text = config["ServerAdress"];
            editPort.Text = config["ServerPort"];
            editPin.Text = config["ServerPin"];

            var btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnSave.Click += (sender, e) => { ConfigManager.SaveConfiguration(editServer.Text, editPort.Text, editPin.Text); };
        }
    }
}