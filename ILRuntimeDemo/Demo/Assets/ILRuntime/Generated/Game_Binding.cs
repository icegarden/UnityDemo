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
    unsafe class Game_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::Game);
            args = new Type[]{typeof(System.String), typeof(System.String)};
            method = type.GetMethod("BindFairyGui", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BindFairyGui_0);

            field = type.GetField("allTypes", flag);
            app.RegisterCLRFieldGetter(field, get_allTypes_0);
            app.RegisterCLRFieldSetter(field, set_allTypes_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_allTypes_0, AssignFromStack_allTypes_0);


        }


        static StackObject* BindFairyGui_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @url = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            global::Game.BindFairyGui(@url, @name);

            return __ret;
        }


        static object get_allTypes_0(ref object o)
        {
            return global::Game.allTypes;
        }

        static StackObject* CopyToStack_allTypes_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::Game.allTypes;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_allTypes_0(ref object o, object v)
        {
            global::Game.allTypes = (System.Type[])v;
        }

        static StackObject* AssignFromStack_allTypes_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Type[] @allTypes = (System.Type[])typeof(System.Type[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            global::Game.allTypes = @allTypes;
            return ptr_of_this_method;
        }



    }
}
