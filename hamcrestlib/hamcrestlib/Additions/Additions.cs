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

namespace Org.Hamcrest.Internal
{
    public partial class SelfDescribingValueIterator : global::Java.Lang.Object, global::Java.Util.IIterator
    {
        static IntPtr id_next;
        // Metadata.xml XPath method reference: path="/api/package[@name='org.hamcrest.internal']/class[@name='SelfDescribingValueIterator']/method[@name='next' and count(parameter)=0]"
        [Register("next", "()Lorg/hamcrest/SelfDescribing;", "GetNextHandler")]
        public virtual unsafe Java.Lang.Object Next()
        {
            if (id_next == IntPtr.Zero)
                id_next = JNIEnv.GetMethodID(class_ref, "next", "()Lorg/hamcrest/SelfDescribing;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "next", "()Lorg/hamcrest/SelfDescribing;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}

namespace Org.Hamcrest.Core
{
    public partial class StringStartsWith : global::Org.Hamcrest.Core.SubstringMatcher
    {
        protected override bool MatchesSafely(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class StringEndsWith : global::Org.Hamcrest.Core.SubstringMatcher
    {
        protected override bool MatchesSafely(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class StringContains : global::Org.Hamcrest.Core.SubstringMatcher
    {
        protected override bool MatchesSafely(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }
    }

    public partial class IsCollectionContaining : global::Org.Hamcrest.TypeSafeDiagnosingMatcher
    {
        protected override bool MatchesSafely(Java.Lang.Object p0, IDescription p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class Every : global::Org.Hamcrest.TypeSafeDiagnosingMatcher
    {
        protected override bool MatchesSafely(Java.Lang.Object p0, IDescription p1)
        {
            throw new NotImplementedException();
        }
    }
}