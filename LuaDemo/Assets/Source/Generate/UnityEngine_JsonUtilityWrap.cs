﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_JsonUtilityWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("JsonUtility");
		L.RegFunction("ToJson", ToJson);
		L.RegFunction("FromJson", FromJson);
		L.RegFunction("FromJsonOverwrite", FromJsonOverwrite);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToJson(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				object arg0 = ToLua.ToVarObject(L, 1);
				string o = UnityEngine.JsonUtility.ToJson(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2)
			{
				object arg0 = ToLua.ToVarObject(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				string o = UnityEngine.JsonUtility.ToJson(arg0, arg1);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.JsonUtility.ToJson");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FromJson(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			object o = UnityEngine.JsonUtility.FromJson(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FromJsonOverwrite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			object arg1 = ToLua.ToVarObject(L, 2);
			UnityEngine.JsonUtility.FromJsonOverwrite(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

