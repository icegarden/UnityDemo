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
    unsafe class System_Linq_Enumerable_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Linq.Enumerable);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;                    
            foreach(var m in type.GetMethods())
            {
                if(m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }
                    lst.Add(m);
                }
            }
            args = new Type[]{typeof(System.Collections.Generic.KeyValuePair<System.Type, System.Int32>), typeof(System.Int32)};
            if (genericMethods.TryGetValue("OrderByDescending", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>>), typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>>), typeof(System.Func<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>, System.Int32>)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, OrderByDescending_0);

                        break;
                    }
                }
            }


        }


        static StackObject* OrderByDescending_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>, System.Int32> @keySelector = (System.Func<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>, System.Int32>)typeof(System.Func<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>> @source = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>>)typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<System.Type, System.Int32>, System.Int32>(@source, @keySelector);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}