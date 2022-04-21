using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class EventConst_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::EventConst);

            field = type.GetField("BundleContentLoadComplete", flag);
            app.RegisterCLRFieldGetter(field, get_BundleContentLoadComplete_0);
            app.RegisterCLRFieldSetter(field, set_BundleContentLoadComplete_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_BundleContentLoadComplete_0, AssignFromStack_BundleContentLoadComplete_0);
            field = type.GetField("BundleLoadComplete", flag);
            app.RegisterCLRFieldGetter(field, get_BundleLoadComplete_1);
            app.RegisterCLRFieldSetter(field, set_BundleLoadComplete_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_BundleLoadComplete_1, AssignFromStack_BundleLoadComplete_1);
            field = type.GetField("BundleContentLoadFailed", flag);
            app.RegisterCLRFieldGetter(field, get_BundleContentLoadFailed_2);
            app.RegisterCLRFieldSetter(field, set_BundleContentLoadFailed_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_BundleContentLoadFailed_2, AssignFromStack_BundleContentLoadFailed_2);


        }



        static object get_BundleContentLoadComplete_0(ref object o)
        {
            return global::EventConst.BundleContentLoadComplete;
        }

        static StackObject* CopyToStack_BundleContentLoadComplete_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::EventConst.BundleContentLoadComplete;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BundleContentLoadComplete_0(ref object o, object v)
        {
            global::EventConst.BundleContentLoadComplete = (System.String)v;
        }

        static StackObject* AssignFromStack_BundleContentLoadComplete_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BundleContentLoadComplete = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            global::EventConst.BundleContentLoadComplete = @BundleContentLoadComplete;
            return ptr_of_this_method;
        }

        static object get_BundleLoadComplete_1(ref object o)
        {
            return global::EventConst.BundleLoadComplete;
        }

        static StackObject* CopyToStack_BundleLoadComplete_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::EventConst.BundleLoadComplete;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BundleLoadComplete_1(ref object o, object v)
        {
            global::EventConst.BundleLoadComplete = (System.String)v;
        }

        static StackObject* AssignFromStack_BundleLoadComplete_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BundleLoadComplete = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            global::EventConst.BundleLoadComplete = @BundleLoadComplete;
            return ptr_of_this_method;
        }

        static object get_BundleContentLoadFailed_2(ref object o)
        {
            return global::EventConst.BundleContentLoadFailed;
        }

        static StackObject* CopyToStack_BundleContentLoadFailed_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::EventConst.BundleContentLoadFailed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BundleContentLoadFailed_2(ref object o, object v)
        {
            global::EventConst.BundleContentLoadFailed = (System.String)v;
        }

        static StackObject* AssignFromStack_BundleContentLoadFailed_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BundleContentLoadFailed = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            global::EventConst.BundleContentLoadFailed = @BundleContentLoadFailed;
            return ptr_of_this_method;
        }



    }
}
