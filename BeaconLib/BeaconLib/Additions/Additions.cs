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

namespace Org.Altbeacon.Beacon.Distance
{
    public partial class ModelSpecificDistanceUpdater : global::Android.OS.AsyncTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
                id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID(class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;");
            IntPtr native_p0 = JNIEnv.NewArray(@params);
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(native_p0);

                global::Java.Lang.Void __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                if (@params != null)
                {
                    JNIEnv.CopyArray(native_p0, @params);
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }
    }
}

namespace Org.Altbeacon.Beacon
{
    public partial class Identifier : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable
    {

        public unsafe int CompareTo(Java.Lang.Object another)
        {
            if (id_compareTo_Lorg_altbeacon_beacon_Identifier_ == IntPtr.Zero)
                id_compareTo_Lorg_altbeacon_beacon_Identifier_ = JNIEnv.GetMethodID(class_ref, "compareTo", "(Lorg/altbeacon/beacon/Identifier;)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(another);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_compareTo_Lorg_altbeacon_beacon_Identifier_, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "compareTo", "(Lorg/altbeacon/beacon/Identifier;)I"), __args);
                return __ret;
            }
            finally
            {
            }
        }
    }

    public partial class AltBeacon : global::Org.Altbeacon.Beacon.Beacon
    {
        static IntPtr CREATOR_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='org.altbeacon.beacon']/class[@name='AltBeacon']/field[@name='CREATOR']"
        [Register("CREATOR")]
        new public static global::Android.OS.IParcelableCreator Creator
        {
            get
            {
                if (CREATOR_jfieldId == IntPtr.Zero)
                    CREATOR_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
                IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, CREATOR_jfieldId);
                return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator>(__ret, JniHandleOwnership.TransferLocalRef);
            }
        }
    }
}

namespace Org.Altbeacon.Beacon.Simulator
{
    public partial class StaticBeaconSimulator : global::Java.Lang.Object, global::Org.Altbeacon.Beacon.Simulator.IBeaconSimulator
    {
        static IntPtr id_getBeacons2;
        static IntPtr id_setBeacons_Ljava_util_List_2;
        public virtual unsafe global::System.Collections.Generic.IList<global::Org.Altbeacon.Beacon.Beacon> Beacons
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.altbeacon.beacon.simulator']/class[@name='StaticBeaconSimulator']/method[@name='getBeacons' and count(parameter)=0]"
            [Register("getBeacons", "()Ljava/util/List;", "GetGetBeaconsHandler")]
            get
            {
                if (id_getBeacons2 == IntPtr.Zero)
                    id_getBeacons2 = JNIEnv.GetMethodID(class_ref, "getBeacons", "()Ljava/util/List;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return global::Android.Runtime.JavaList<global::Org.Altbeacon.Beacon.Beacon>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getBeacons), JniHandleOwnership.TransferLocalRef);
                    else
                        return global::Android.Runtime.JavaList<global::Org.Altbeacon.Beacon.Beacon>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getBeacons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='org.altbeacon.beacon.simulator']/class[@name='StaticBeaconSimulator']/method[@name='setBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.altbeacon.beacon.Beacon&gt;']]"
            [Register("setBeacons", "(Ljava/util/List;)V", "GetSetBeacons_Ljava_util_List_Handler")]
            set
            {
                if (id_setBeacons_Ljava_util_List_2 == IntPtr.Zero)
                    id_setBeacons_Ljava_util_List_2 = JNIEnv.GetMethodID(class_ref, "setBeacons", "(Ljava/util/List;)V");
                IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Altbeacon.Beacon.Beacon>.ToLocalJniHandle(value);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_value);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setBeacons_Ljava_util_List_2, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setBeacons", "(Ljava/util/List;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }
}


}

