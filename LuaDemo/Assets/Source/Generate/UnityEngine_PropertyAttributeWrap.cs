//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_PropertyAttributeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.PropertyAttribute), typeof(System.Attribute));
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("order", get_order, set_order);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_order(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.PropertyAttribute obj = (UnityEngine.PropertyAttribute)o;
			int ret = obj.order;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index order on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_order(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.PropertyAttribute obj = (UnityEngine.PropertyAttribute)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.order = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index order on a nil value");
		}
	}
}

