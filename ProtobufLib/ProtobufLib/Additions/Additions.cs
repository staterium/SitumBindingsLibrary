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
using static Com.Google.Protobuf.Internal;

namespace Com.Google.Protobuf
{
    public partial class UnmodifiableLazyStringList : global::Java.Util.AbstractList, global::Com.Google.Protobuf.ILazyStringList, global::Java.Util.IRandomAccess
    {
        static IntPtr id_get_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnmodifiableLazyStringList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("get", "(I)Ljava/lang/String;", "GetGet_IHandler")]
        public override unsafe Java.Lang.Object Get(int p0)
        {
            if (id_get_I == IntPtr.Zero)
                id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Ljava/lang/String;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
                else
                    return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    public abstract partial class AbstractProtobufList : global::Java.Util.AbstractList, global::Com.Google.Protobuf.Internal.IProtobufList
    {
        /*static IntPtr id_isModifiable;

        public virtual unsafe bool IsModifiable
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='AbstractProtobufList']/method[@name='isModifiable' and count(parameter)=0]"
            [Register("isModifiable", "()Z", "GetIsModifiableHandler")]
            get
            {
                if (id_isModifiable == IntPtr.Zero)
                    id_isModifiable = JNIEnv.GetMethodID(class_ref, "isModifiable", "()Z");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isModifiable);
                    else
                        return JNIEnv.CallNonvirtualBooleanMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isModifiable", "()Z"));
                }
                finally
                {
                }
            }
        }*/

      

        public Internal.IProtobufList MutableCopyWithCapacity(int p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class LazyStringArrayList : global::Com.Google.Protobuf.AbstractProtobufList, global::Com.Google.Protobuf.ILazyStringList, global::Java.Util.IRandomAccess
    {
        static IntPtr id_get_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='LazyStringArrayList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("get", "(I)Ljava/lang/String;", "GetGet_IHandler")]
        public override unsafe Java.Lang.Object Get(int p0)
        {
            if (id_get_I == IntPtr.Zero)
                id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Ljava/lang/String;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
                else
                    return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        public partial class ByteArrayListView : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
        {
            static IntPtr id_get_I;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='LazyStringArrayList.ByteArrayListView']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("get", "(I)[B", "GetGet_IHandler")]
            public override unsafe Java.Lang.Object Get(int p0)
            {
                if (id_get_I == IntPtr.Zero)
                    id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)[B");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(p0);

                    if (((object)this).GetType() == ThresholdType)
                        return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef, typeof(byte));
                    else
                        return (byte[])JNIEnv.GetArray(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof(byte));
                }
                finally
                {
                }
            }
        }

        public partial class ByteStringListView : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
        {
            static IntPtr id_get_I;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='LazyStringArrayList.ByteStringListView']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("get", "(I)Lcom/google/protobuf/ByteString;", "GetGet_IHandler")]
            public override unsafe Java.Lang.Object Get(int p0)
            {
                if (id_get_I == IntPtr.Zero)
                    id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lcom/google/protobuf/ByteString;");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(p0);

                    if (((object)this).GetType() == ThresholdType)
                        return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
                    else
                        return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lcom/google/protobuf/ByteString;"), __args), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }       
    }

    public partial class LazyField : global::Com.Google.Protobuf.LazyFieldLite
    {
        public partial class LazyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            static IntPtr id_next;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='LazyField.LazyIterator']/method[@name='next' and count(parameter)=0]"
            [Register("next", "()Ljava/util/Map$Entry;", "GetNextHandler")]
            public virtual unsafe global::Java.Lang.Object Next()
            {
                if (id_next == IntPtr.Zero)
                    id_next = JNIEnv.GetMethodID(class_ref, "next", "()Ljava/util/Map$Entry;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
                    else
                        return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "next", "()Ljava/util/Map$Entry;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    public abstract partial class GeneratedMessageLite : global::Com.Google.Protobuf.AbstractMessageLite
    {
        static IntPtr id_getDefaultInstanceForType;
        public override unsafe IMessageLite DefaultInstanceForType
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite']/method[@name='getDefaultInstanceForType' and count(parameter)=0]"
            [Register("getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetGetDefaultInstanceForTypeHandler")]
            get
            {
                if (id_getDefaultInstanceForType == IntPtr.Zero)
                    id_getDefaultInstanceForType = JNIEnv.GetMethodID(class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;");
                try
                {
                    return global::Java.Lang.Object.GetObject<IMessageLite>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        public partial class GeneratedExtension : global::Com.Google.Protobuf.ExtensionLite
        {
            protected override Java.Lang.Object RawDefaultValue
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

        public new abstract partial class Builder : global::Com.Google.Protobuf.AbstractMessageLite.Builder
        {
            static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.Builder']/method[@name='mergeFrom' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.CodedInputStream'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite']]"
            [Register("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
            public override unsafe IMessageLiteBuilder MergeFrom(global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
            {
                if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
                    id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID(class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;");
                try
                {
                    JValue* __args = stackalloc JValue[2];
                    __args[0] = new JValue(p0);
                    __args[1] = new JValue(p1);

                    IMessageLiteBuilder __ret;

                    if (((object)this).GetType() == ThresholdType)
                        __ret = (IMessageLiteBuilder)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, __args), JniHandleOwnership.TransferLocalRef);
                    else
                        __ret = (IMessageLiteBuilder)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
                    return __ret;
                }
                finally
                {
                }
            }
        }

        /*internal partial class BuilderInvoker : Builder
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='AbstractMessageLite.Builder']/method[@name='mergeFrom' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.CodedInputStream'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite']]"
            [Register("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
            public override unsafe Java.Lang.Object MergeFrom(global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
            {
                if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
                    id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID(class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;");
                try
                {
                    JValue* __args = stackalloc JValue[2];
                    __args[0] = new JValue(p0);
                    __args[1] = new JValue(p1);
                    Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, __args), JniHandleOwnership.TransferLocalRef);
                    return __ret;
                }
                finally
                {
                }
            }
        }*/
    }

    public abstract partial class AbstractParser : global::Java.Lang.Object, global::Com.Google.Protobuf.IParser
    {
        public Java.Lang.Object ParsePartialFrom(CodedInputStream p0, ExtensionRegistryLite p1)
        {
            throw new NotImplementedException();
        }
    }
}