//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_Unity_SpineEventWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.Unity.SpineEvent), typeof(Spine.Unity.SpineAttributeBase));
		L.RegFunction("New", _CreateSpine_Unity_SpineEvent);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("audioOnly", get_audioOnly, set_audioOnly);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_Unity_SpineEvent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Spine.Unity.SpineEvent obj = new Spine.Unity.SpineEvent();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				Spine.Unity.SpineEvent obj = new Spine.Unity.SpineEvent(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				Spine.Unity.SpineEvent obj = new Spine.Unity.SpineEvent(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				Spine.Unity.SpineEvent obj = new Spine.Unity.SpineEvent(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 4)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				Spine.Unity.SpineEvent obj = new Spine.Unity.SpineEvent(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 5)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				Spine.Unity.SpineEvent obj = new Spine.Unity.SpineEvent(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.Unity.SpineEvent.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_audioOnly(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SpineEvent obj = (Spine.Unity.SpineEvent)o;
			bool ret = obj.audioOnly;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index audioOnly on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_audioOnly(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SpineEvent obj = (Spine.Unity.SpineEvent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.audioOnly = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index audioOnly on a nil value");
		}
	}
}

