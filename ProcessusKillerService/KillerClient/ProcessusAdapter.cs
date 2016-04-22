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

            var view = (convertView ?? Context.LayoutInflater.Inflate(Resource.Layout.ProcessListItem, parent, false)) as LinearLayout;
            var txtName = view.FindViewById<TextView>(Resource.Id.NameText);
            txtName.Text = process.Name;
            return view;
        }

        public override int Count => ListProcessus.Count;

        public override Processus this[int position] => ListProcessus[position];
    }
}