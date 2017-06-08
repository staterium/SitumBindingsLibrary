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
using CZ.Msebera.Android.Httpclient.IO;
using CZ.Msebera.Android.Httpclient.Conn.Routing;
using Java.Lang;
using Java.Net;
using Java.Util;
using CZ.Msebera.Android.Httpclient.Protocol;
using CZ.Msebera.Android.Httpclient.Params;
using System.IO;

namespace CZ.Msebera.Android.Httpclient.Util
{
    public partial class Args : global::Java.Lang.Object
    {
        static IntPtr id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.util']/class[@name='Args']/method[@name='notBlank' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
        [Register("notBlank", "(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "T extends java.lang.CharSequence" })]
        public static unsafe global::Java.Lang.Object NotBlank(global::Java.Lang.Object p0, string p1)
        {
            if (id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
                id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "notBlank", "(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/CharSequence;");
            IntPtr native_p0 = JNIEnv.ToLocalJniHandle(p0);
            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(native_p1);
                global::Java.Lang.Object __ret = (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallStaticObjectMethod(class_ref, id_notBlank_Ljava_lang_CharSequence_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

        static IntPtr id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.util']/class[@name='Args']/method[@name='notEmpty' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
        [Register("notEmpty", "(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "T extends java.lang.CharSequence" })]
        public static unsafe global::Java.Lang.Object NotEmpty(global::Java.Lang.Object p0, string p1)
        {
            if (id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
                id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "notEmpty", "(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/CharSequence;");
            IntPtr native_p0 = JNIEnv.ToLocalJniHandle(p0);
            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(native_p1);
                global::Java.Lang.Object __ret = (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallStaticObjectMethod(class_ref, id_notEmpty_Ljava_lang_CharSequence_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }
    }

    public partial class SocketHttpServerConnection : Impl.AbstractHttpServerConnection, IHttpInetConnection
    {
        public override bool IsOpen
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public InetAddress LocalAddress
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int LocalPort
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public InetAddress RemoteAddress
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RemotePort
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int SocketTimeout
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Shutdown()
        {
            throw new NotImplementedException();
        }

        protected override void AssertOpen()
        {
            throw new NotImplementedException();
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Impl.Pool
{
    public partial class BasicConnPool : global::CZ.Msebera.Android.Httpclient.Pool.AbstractConnPool
    {
        protected override Java.Lang.Object CreateEntry(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            throw new NotImplementedException();
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Impl.IO
{
    public partial class HttpResponseWriter : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageWriter
    {
        protected override void WriteHeadLine(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class HttpResponseParser : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageParser
    {
        static IntPtr id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.io']/class[@name='HttpResponseParser']/method[@name='parseHead' and count(parameter)=1 and parameter[1][@type='cz.msebera.android.httpclient.io.SessionInputBuffer']]"
        [Register("parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;", "GetParseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_Handler")]
        protected override unsafe global::Java.Lang.Object ParseHead(global::CZ.Msebera.Android.Httpclient.IO.ISessionInputBuffer p0)
        {
            if (id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ == IntPtr.Zero)
                id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ = JNIEnv.GetMethodID(class_ref, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                Java.Lang.Object __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    }

    public partial class HttpRequestWriter : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageWriter
    {
        protected override void WriteHeadLine(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class HttpRequestParser
    {
        static IntPtr id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.io']/class[@name='HttpRequestParser']/method[@name='parseHead' and count(parameter)=1 and parameter[1][@type='cz.msebera.android.httpclient.io.SessionInputBuffer']]"
        [Register("parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;", "GetParseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_Handler")]
        protected override unsafe Java.Lang.Object ParseHead(global::CZ.Msebera.Android.Httpclient.IO.ISessionInputBuffer p0)
        {
            if (id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ == IntPtr.Zero)
                id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ = JNIEnv.GetMethodID(class_ref, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                Java.Lang.Object __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    }

    public partial class DefaultHttpResponseWriter : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageWriter
    {
        protected override void WriteHeadLine(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class DefaultHttpResponseParser : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageParser
    {
        static IntPtr id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.io']/class[@name='DefaultHttpResponseParser']/method[@name='parseHead' and count(parameter)=1 and parameter[1][@type='cz.msebera.android.httpclient.io.SessionInputBuffer']]"
        [Register("parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpResponse;", "GetParseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_Handler")]
        protected override unsafe Java.Lang.Object ParseHead(global::CZ.Msebera.Android.Httpclient.IO.ISessionInputBuffer p0)
        {
            if (id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ == IntPtr.Zero)
                id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ = JNIEnv.GetMethodID(class_ref, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpResponse;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                Java.Lang.Object __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    }

    public partial class DefaultHttpRequestWriter : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageWriter
    {
        protected override void WriteHeadLine(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class DefaultHttpRequestParser : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageParser
    {
        protected override Java.Lang.Object ParseHead(ISessionInputBuffer p0)
        {
            throw new NotImplementedException();
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Impl.Cookie
{
    public partial class BasicClientCookie : global::Java.Lang.Object, global::CZ.Msebera.Android.Httpclient.Cookie.IClientCookie, global::CZ.Msebera.Android.Httpclient.Cookie.ISetCookie, global::Java.IO.ISerializable, global::Java.Lang.ICloneable
    {
        public void SetComment(string p0)
        {
            throw new NotImplementedException();
        }

        public void SetDomain(string p0)
        {
            throw new NotImplementedException();
        }

        public void SetExpiryDate(Date p0)
        {
            throw new NotImplementedException();
        }

        public void SetPath(string p0)
        {
            throw new NotImplementedException();
        }

        public void SetValue(string p0)
        {
            throw new NotImplementedException();
        }

        public void SetVersion(int p0)
        {
            throw new NotImplementedException();
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Impl.Conn.Tsccm
{
    /*public partial class BasicPooledConnAdapter : global::CZ.Msebera.Android.Httpclient.Impl.Conn.AbstractPooledConnAdapter
    {
        public override HttpRoute Route
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }*/
}

namespace CZ.Msebera.Android.Httpclient.Impl.Conn
{
    public partial class DefaultResponseParser : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageParser
    {
        static IntPtr id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.conn']/class[@name='DefaultResponseParser']/method[@name='parseHead' and count(parameter)=1 and parameter[1][@type='cz.msebera.android.httpclient.io.SessionInputBuffer']]"
        [Register("parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;", "GetParseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_Handler")]
        protected override unsafe global::Java.Lang.Object ParseHead(global::CZ.Msebera.Android.Httpclient.IO.ISessionInputBuffer p0)
        {
            if (id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ == IntPtr.Zero)
                id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ = JNIEnv.GetMethodID(class_ref, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                Java.Lang.Object __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpMessage;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    }

    public partial class DefaultHttpResponseParser : global::CZ.Msebera.Android.Httpclient.Impl.IO.AbstractMessageParser
    {
        static IntPtr id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.conn']/class[@name='DefaultHttpResponseParser']/method[@name='parseHead' and count(parameter)=1 and parameter[1][@type='cz.msebera.android.httpclient.io.SessionInputBuffer']]"
        [Register("parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpResponse;", "GetParseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_Handler")]
        protected override unsafe Java.Lang.Object ParseHead(global::CZ.Msebera.Android.Httpclient.IO.ISessionInputBuffer p0)
        {
            if (id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ == IntPtr.Zero)
                id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_ = JNIEnv.GetMethodID(class_ref, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpResponse;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                Java.Lang.Object __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseHead_Lcz_msebera_android_httpclient_io_SessionInputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "parseHead", "(Lcz/msebera/android/httpclient/io/SessionInputBuffer;)Lcz/msebera/android/httpclient/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Impl.Client
{
    public partial class TargetAuthenticationStrategy : global::CZ.Msebera.Android.Httpclient.Impl.Client.AuthenticationStrategyImpl
    {
        static IntPtr id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='TargetAuthenticationStrategy']/method[@name='getChallenges' and count(parameter)=3 and parameter[1][@type='cz.msebera.android.httpclient.HttpHost'] and parameter[2][@type='cz.msebera.android.httpclient.HttpResponse'] and parameter[3][@type='cz.msebera.android.httpclient.protocol.HttpContext']]"
        [Register("getChallenges", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpResponse;Lcz/msebera/android/httpclient/protocol/HttpContext;)Ljava/util/Map;", "GetGetChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_Handler")]
        public override unsafe IDictionary<string, global::CZ.Msebera.Android.Httpclient.IHeader> GetChallenges(global::CZ.Msebera.Android.Httpclient.HttpHost p0, global::CZ.Msebera.Android.Httpclient.IHttpResponse p1, global::CZ.Msebera.Android.Httpclient.Protocol.IHttpContext p2)
        {
            if (id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_ == IntPtr.Zero)
                id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_ = JNIEnv.GetMethodID(class_ref, "getChallenges", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpResponse;Lcz/msebera/android/httpclient/protocol/HttpContext;)Ljava/util/Map;");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);

                IDictionary<string, global::CZ.Msebera.Android.Httpclient.IHeader> __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = (IDictionary<string, global::CZ.Msebera.Android.Httpclient.IHeader>)JavaDictionary.FromJniHandle(JNIEnv.CallObjectMethod(Handle, id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = (IDictionary<string, global::CZ.Msebera.Android.Httpclient.IHeader>)JavaDictionary.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getChallenges", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpResponse;Lcz/msebera/android/httpclient/protocol/HttpContext;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        /*private IJavaObject Select(IDictionary p0, HttpHost p1, IHttpResponse p2, IHttpContext p3)
        {
            throw new NotImplementedException();
        }*/
    }

    public partial class RedirectLocations : global::Java.Util.AbstractList
    {
        static IntPtr id_get_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='RedirectLocations']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("get", "(I)Ljava/net/URI;", "GetGet_IHandler")]
        public override unsafe Java.Lang.Object Get(int p0)
        {
            if (id_get_I == IntPtr.Zero)
                id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Ljava/net/URI;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::Java.Net.URI>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::Java.Net.URI>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Ljava/net/URI;"), __args), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    public partial class ProxyAuthenticationStrategy : global::CZ.Msebera.Android.Httpclient.Impl.Client.AuthenticationStrategyImpl
    {
        static IntPtr id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='ProxyAuthenticationStrategy']/method[@name='getChallenges' and count(parameter)=3 and parameter[1][@type='cz.msebera.android.httpclient.HttpHost'] and parameter[2][@type='cz.msebera.android.httpclient.HttpResponse'] and parameter[3][@type='cz.msebera.android.httpclient.protocol.HttpContext']]"
        [Register("getChallenges", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpResponse;Lcz/msebera/android/httpclient/protocol/HttpContext;)Ljava/util/Map;", "GetGetChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_Handler")]
        public override unsafe IDictionary<string, IHeader> GetChallenges(global::CZ.Msebera.Android.Httpclient.HttpHost p0, global::CZ.Msebera.Android.Httpclient.IHttpResponse p1, global::CZ.Msebera.Android.Httpclient.Protocol.IHttpContext p2)
        {
            if (id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_ == IntPtr.Zero)
                id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_ = JNIEnv.GetMethodID(class_ref, "getChallenges", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpResponse;Lcz/msebera/android/httpclient/protocol/HttpContext;)Ljava/util/Map;");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);

                IDictionary<string, IHeader> __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = (IDictionary<string, IHeader>)global::Android.Runtime.JavaDictionary.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getChallenges_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpResponse_Lcz_msebera_android_httpclient_protocol_HttpContext_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = (IDictionary<string, IHeader>)global::Android.Runtime.JavaDictionary.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getChallenges", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpResponse;Lcz/msebera/android/httpclient/protocol/HttpContext;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    }

    public abstract partial class CloseableHttpClient : global::Java.Lang.Object, global::CZ.Msebera.Android.Httpclient.Client.IHttpClient, global::Java.IO.ICloseable
    {/*
        static IntPtr id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='CloseableHttpClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='cz.msebera.android.httpclient.HttpHost'] and parameter[2][@type='cz.msebera.android.httpclient.HttpRequest']]"
        [Register("execute", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpRequest;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;", "GetExecute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_Handler")]
        public virtual unsafe global::CZ.Msebera.Android.Httpclient.IHttpResponse Execute(global::CZ.Msebera.Android.Httpclient.HttpHost p0, global::CZ.Msebera.Android.Httpclient.IHttpRequest p1)
        {
            if (id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_ == IntPtr.Zero)
                id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_ = JNIEnv.GetMethodID(class_ref, "execute", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpRequest;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                global::CZ.Msebera.Android.Httpclient.IHttpResponse __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "execute", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpRequest;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='CloseableHttpClient']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='cz.msebera.android.httpclient.HttpHost'] and parameter[2][@type='cz.msebera.android.httpclient.HttpRequest'] and parameter[3][@type='cz.msebera.android.httpclient.protocol.HttpContext']]"
        [Register("execute", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpRequest;Lcz/msebera/android/httpclient/protocol/HttpContext;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;", "GetExecute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_Handler")]
        public virtual unsafe global::CZ.Msebera.Android.Httpclient.IHttpResponse Execute(global::CZ.Msebera.Android.Httpclient.HttpHost p0, global::CZ.Msebera.Android.Httpclient.IHttpRequest p1, global::CZ.Msebera.Android.Httpclient.Protocol.IHttpContext p2)
        {
            if (id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_ == IntPtr.Zero)
                id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_ = JNIEnv.GetMethodID(class_ref, "execute", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpRequest;Lcz/msebera/android/httpclient/protocol/HttpContext;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);

                global::CZ.Msebera.Android.Httpclient.IHttpResponse __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_execute_Lcz_msebera_android_httpclient_HttpHost_Lcz_msebera_android_httpclient_HttpRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "execute", "(Lcz/msebera/android/httpclient/HttpHost;Lcz/msebera/android/httpclient/HttpRequest;Lcz/msebera/android/httpclient/protocol/HttpContext;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='CloseableHttpClient']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='cz.msebera.android.httpclient.client.methods.HttpUriRequest']]"
        [Register("execute", "(Lcz/msebera/android/httpclient/client/methods/HttpUriRequest;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;", "GetExecute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_Handler")]
        public virtual unsafe global::CZ.Msebera.Android.Httpclient.IHttpResponse Execute(global::CZ.Msebera.Android.Httpclient.Client.Methods.IHttpUriRequest p0)
        {
            if (id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_ == IntPtr.Zero)
                id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_ = JNIEnv.GetMethodID(class_ref, "execute", "(Lcz/msebera/android/httpclient/client/methods/HttpUriRequest;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                global::CZ.Msebera.Android.Httpclient.IHttpResponse __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "execute", "(Lcz/msebera/android/httpclient/client/methods/HttpUriRequest;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_;
        // Metadata.xml XPath method reference: path="/api/package[@name='cz.msebera.android.httpclient.impl.client']/class[@name='CloseableHttpClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='cz.msebera.android.httpclient.client.methods.HttpUriRequest'] and parameter[2][@type='cz.msebera.android.httpclient.protocol.HttpContext']]"
        [Register("execute", "(Lcz/msebera/android/httpclient/client/methods/HttpUriRequest;Lcz/msebera/android/httpclient/protocol/HttpContext;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;", "GetExecute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_Handler")]
        public virtual unsafe global::CZ.Msebera.Android.Httpclient.IHttpResponse Execute(global::CZ.Msebera.Android.Httpclient.Client.Methods.IHttpUriRequest p0, global::CZ.Msebera.Android.Httpclient.Protocol.IHttpContext p1)
        {
            if (id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_ == IntPtr.Zero)
                id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_ = JNIEnv.GetMethodID(class_ref, "execute", "(Lcz/msebera/android/httpclient/client/methods/HttpUriRequest;Lcz/msebera/android/httpclient/protocol/HttpContext;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                global::CZ.Msebera.Android.Httpclient.IHttpResponse __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_execute_Lcz_msebera_android_httpclient_client_methods_HttpUriRequest_Lcz_msebera_android_httpclient_protocol_HttpContext_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::CZ.Msebera.Android.Httpclient.IHttpResponse>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "execute", "(Lcz/msebera/android/httpclient/client/methods/HttpUriRequest;Lcz/msebera/android/httpclient/protocol/HttpContext;)Lcz/msebera/android/httpclient/client/methods/CloseableHttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }*/
    }

    public partial class DefaultHttpClient : global::CZ.Msebera.Android.Httpclient.Impl.Client.AbstractHttpClient
    {
        public override IHttpParams SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class DecompressingHttpClient : global::Java.Lang.Object, global::CZ.Msebera.Android.Httpclient.Client.IHttpClient
    {
        public IHttpParams SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class AutoRetryHttpClient : global::Java.Lang.Object, global::CZ.Msebera.Android.Httpclient.Client.IHttpClient
    {
        public IHttpParams SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Entity
{
    public partial class StringEntity : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity, global::Java.Lang.ICloneable
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class InputStreamEntity : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class FileEntity : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity, global::Java.Lang.ICloneable
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class ByteArrayEntity : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity, global::Java.Lang.ICloneable
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class SerializableEntity : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class HttpEntityWrapper : global::Java.Lang.Object, global::CZ.Msebera.Android.Httpclient.IHttpEntity
    {
        public Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class EntityTemplate : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }

    public partial class BasicHttpEntity : global::CZ.Msebera.Android.Httpclient.Entity.AbstractHttpEntity
    {
        public override Stream SomeOtherName()
        {
            throw new NotImplementedException();
        }
    }
}

namespace CZ.Msebera.Android.Httpclient.Cookie
{
    public partial class CookiePathComparator : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IComparator
    {
        public int Compare(Java.Lang.Object lhs, Java.Lang.Object rhs)
        {
            throw new NotImplementedException();
        }
    }

    public partial class CookieIdentityComparator : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IComparator
    {
        public int Compare(Java.Lang.Object lhs, Java.Lang.Object rhs)
        {
            throw new NotImplementedException();
        }
    }
}




