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

namespace Com.Loopj.Android.Http
{
    public partial class JsonStreamerEntity : global::Java.Lang.Object, global::CZ.Msebera.Android.Httpclient.IHttpEntity
    {
        public System.IO.Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public abstract partial class BinaryHttpResponseHandler : global::Com.Loopj.Android.Http.AsyncHttpResponseHandler
    {

    }
}