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
using ES.Usc.Citius.Hipster.Model.Impl;
using Java.Util;

namespace ES.Usc.Citius.Hipster.Model.Impl
{
    public partial class WeightedNode : global::ES.Usc.Citius.Hipster.Model.AbstractNode, global::ES.Usc.Citius.Hipster.Model.IHeuristicNode
    {
        public int CompareTo(Java.Lang.Object another)
        {
            return CompareTo((WeightedNode)another);
        }
    }

    public partial class ADStarNodeImpl : global::ES.Usc.Citius.Hipster.Model.AbstractNode, global::ES.Usc.Citius.Hipster.Model.IADStarNode
    {
        public int CompareTo(Java.Lang.Object another)
        {
            return CompareTo((ADStarNodeImpl)another);
        }

        void IADStarNode.SetPreviousNode(Java.Lang.Object p0)
        {
            throw new NotImplementedException();
        }

        void SetPreviousNode(global::Java.Lang.Object p0)
        {
            SetPreviousNode((ADStarNodeImpl)p0);
        }
    }
}

namespace ES.Usc.Citius.Hipster.Model
{
    public partial class ADStarNodeKey : global::Java.Lang.Object, global::Java.Lang.IComparable
    {
        public int CompareTo(Java.Lang.Object another)
        {
            return CompareTo((ADStarNodeKey)another);
        }
    }
}

namespace ES.Usc.Citius.Hipster.Model.Function.Impl
{
    public partial class WeightedNodeFactory : global::Java.Lang.Object, global::ES.Usc.Citius.Hipster.Model.Function.INodeFactory
    {
        public Java.Lang.Object MakeNode(Java.Lang.Object p0, Transition p1)
        {
            return MakeNode((WeightedNode)p0, p1);
        }
    }

    public partial class ADStarNodeFactory : global::Java.Lang.Object, global::ES.Usc.Citius.Hipster.Model.Function.INodeFactory
    {
        public Java.Lang.Object MakeNode(Java.Lang.Object p0, Transition p1)
        {
            return MakeNode((ADStarNodeImpl)p0, p1);
        }
    }
}

namespace ES.Usc.Citius.Hipster.Algorithm
{
    public partial class MultiobjectiveLS : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        public partial class MyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class DepthFirstSearch : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        public partial class MyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            Java.Lang.Object IIterator.Next()
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class BreadthFirstSearch : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        static IntPtr id_iterator;
        [Register("iterator", "()Les/usc/citius/hipster/algorithm/BreadthFirstSearch$Iterator;", "GetIteratorHandler")]
        public override IIterator Iterator()
        {
            if (id_iterator == IntPtr.Zero)
                id_iterator = JNIEnv.GetMethodID(class_ref, "iterator", "()Les/usc/citius/hipster/algorithm/BreadthFirstSearch$Iterator;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.BreadthFirstSearch.MyIterator>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.BreadthFirstSearch.MyIterator>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "iterator", "()Les/usc/citius/hipster/algorithm/BreadthFirstSearch$Iterator;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        public partial class MyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class BellmanFord : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {

        static IntPtr id_iterator;
        // Metadata.xml XPath method reference: path="/api/package[@name='es.usc.citius.hipster.algorithm']/class[@name='BellmanFord']/method[@name='iterator' and count(parameter)=0]"
        [Register("iterator", "()Les/usc/citius/hipster/algorithm/BellmanFord$Iterator;", "GetIteratorHandler")]
        public override unsafe IIterator Iterator()
        {
            if (id_iterator == IntPtr.Zero)
                id_iterator = JNIEnv.GetMethodID(class_ref, "iterator", "()Les/usc/citius/hipster/algorithm/BellmanFord$Iterator;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.BellmanFord.MyIterator>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.BellmanFord.MyIterator>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "iterator", "()Les/usc/citius/hipster/algorithm/BellmanFord$Iterator;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        public partial class MyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class AStar : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        static IntPtr id_iterator;
        // Metadata.xml XPath method reference: path="/api/package[@name='es.usc.citius.hipster.algorithm']/class[@name='AStar']/method[@name='iterator' and count(parameter)=0]"
        [Register("iterator", "()Les/usc/citius/hipster/algorithm/AStar$Iterator;", "GetIteratorHandler")]
        public override unsafe IIterator Iterator()
        {
            if (id_iterator == IntPtr.Zero)
                id_iterator = JNIEnv.GetMethodID(class_ref, "iterator", "()Les/usc/citius/hipster/algorithm/AStar$Iterator;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.AStar.MyIterator>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.AStar.MyIterator>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "iterator", "()Les/usc/citius/hipster/algorithm/AStar$Iterator;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        public partial class MyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class ADStarForward : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        static IntPtr id_iterator;
        // Metadata.xml XPath method reference: path="/api/package[@name='es.usc.citius.hipster.algorithm']/class[@name='ADStarForward']/method[@name='iterator' and count(parameter)=0]"
        [Register("iterator", "()Les/usc/citius/hipster/algorithm/ADStarForward$Iterator;", "GetIteratorHandler")]
        public override unsafe IIterator Iterator()
        {
            if (id_iterator == IntPtr.Zero)
                id_iterator = JNIEnv.GetMethodID(class_ref, "iterator", "()Les/usc/citius/hipster/algorithm/ADStarForward$Iterator;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.ADStarForward.MyIterator>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::ES.Usc.Citius.Hipster.Algorithm.ADStarForward.MyIterator>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "iterator", "()Les/usc/citius/hipster/algorithm/ADStarForward$Iterator;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        public partial class MyIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }
}

namespace ES.Usc.Citius.Hipster.Algorithm.Localsearch
{
    public partial class HillClimbing : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        public override IIterator Iterator()
        {
            throw new NotImplementedException();
        }

        public partial class EHCIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class AnnealingSearch : global::ES.Usc.Citius.Hipster.Algorithm.Algorithm
    {
        public override IIterator Iterator()
        {
            throw new NotImplementedException();
        }

        public partial class ASIterator : global::Java.Lang.Object, global::Java.Util.IIterator
        {
            public Java.Lang.Object Next()
            {
                throw new NotImplementedException();
            }
        }
    }
}