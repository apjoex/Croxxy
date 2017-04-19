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
using Java.Lang;

namespace Croxxy.Droid.adapters
{
    class ListAdapter : BaseAdapter
    {

        Context context;
        List<Croxxy.models.Croxx> croxxyDatas;

        public ListAdapter(Context context, List<Croxxy.models.Croxx> croxxyDatas) {
            this.context = context;
            this.croxxyDatas = croxxyDatas;
        }

        public override int Count
        {
            get
            {
                return croxxyDatas.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }
    }
}