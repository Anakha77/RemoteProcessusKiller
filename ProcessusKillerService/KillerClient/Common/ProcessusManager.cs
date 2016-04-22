using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KillerClient.Common
{
    public static class ProcessusManager
    {
        public static List<Processus> GetProcessus()
        {
            // TODO : call web service to get processus
            return new List<Processus>();
        }
    }
}