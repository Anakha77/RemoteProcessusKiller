using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using KillerClient.Common;

namespace KillerClient
{
    public class ProcessusAdapter : BaseAdapter<Processus>
    {
        protected List<Processus> ListProcessus;
        protected Activity Context;

        public ProcessusAdapter(Activity context, List<Processus> processus)
        {
            ListProcessus = processus;
            Context = context;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var process = ListProcessus[position];

            if (!(Context.LayoutInflater.Inflate(Resource.Layout.ProcessListItem, parent, false) is LinearLayout view)) return null;

            var txtName = view.FindViewById<TextView>(Resource.Id.NameText);
            var txtId = view.FindViewById<TextView>(Resource.Id.IdText);

            txtName.Text = process.DisplayName;
            txtId.Text = process.Id.ToString();

            view.LongClick += ViewOnLongClick;

            return view;
        }

        private static void ViewOnLongClick(object sender, View.LongClickEventArgs longClickEventArgs)
        {
            var view = (View) sender;
            var context = view.Context;

            var name = view.FindViewById<TextView>(Resource.Id.NameText);
            var id = view.FindViewById<TextView>(Resource.Id.IdText);

            var builder = new AlertDialog.Builder(context);
            builder.SetTitle("Alert !");
            builder.SetMessage($"Are you sure to kill the {name.Text} processus ?");
            builder.SetNegativeButton("No", (o, args) => { });
            builder.SetPositiveButton("Yes", (o, args) =>
            {
                Toast t;
                try
                {
                    ProcessusManager.StopProcessus(int.Parse(id.Text));
                    t = Toast.MakeText(context, "You killed the process !", ToastLength.Long);
                }
                catch (Exception)
                {
                    t = Toast.MakeText(context, "Failed to kill the process !", ToastLength.Long);
                }
                t.Show();
            });

            builder.Show();
        }

        public override int Count => ListProcessus.Count;

        public override Processus this[int position] => ListProcessus[position];
    }
}