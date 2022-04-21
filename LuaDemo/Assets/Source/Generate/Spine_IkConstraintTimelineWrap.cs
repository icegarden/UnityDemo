﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_IkConstraintTimelineWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.IkConstraintTimeline), typeof(Spine.CurveTimeline));
		L.RegFunction("SetFrame", SetFrame);
		L.RegFunction("Apply", Apply);
		L.RegFunction("New", _CreateSpine_IkConstraintTimeline);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("ENTRIES", 5);
		L.RegVar("PropertyId", get_PropertyId, null);
		L.RegVar("IkConstraintIndex", get_IkConstraintIndex, set_IkConstraintIndex);
		L.RegVar("Frames", get_Frames, set_Frames);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_IkConstraintTimeline(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				Spine.IkConstraintTimeline obj = new Spine.IkConstraintTimeline(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.IkConstraintTimeline.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFrame(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)ToLua.CheckObject<Spine.IkConstraintTimeline>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
			bool arg5 = LuaDLL.luaL_checkboolean(L, 7);
			obj.SetFrame(arg0, arg1, arg2, arg3, arg4, arg5);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 8);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)ToLua.CheckObject<Spine.IkConstraintTimeline>(L, 1);
			Spine.Skeleton arg0 = (Spine.Skeleton)ToLua.CheckObject<Spine.Skeleton>(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			Spine.ExposedList<Spine.Event> arg3 = (Spine.ExposedList<Spine.Event>)ToLua.CheckObject<Spine.ExposedList<Spine.Event>>(L, 5);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 6);
			Spine.MixBlend arg5 = (Spine.MixBlend)ToLua.CheckObject(L, 7, typeof(Spine.MixBlend));
			Spine.MixDirection arg6 = (Spine.MixDirection)ToLua.CheckObject(L, 8, typeof(Spine.MixDirection));
			obj.Apply(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PropertyId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)o;
			int ret = obj.PropertyId;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PropertyId on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IkConstraintIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)o;
			int ret = obj.IkConstraintIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IkConstraintIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Frames(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)o;
			float[] ret = obj.Frames;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Frames on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IkConstraintIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.IkConstraintIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IkConstraintIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Frames(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.IkConstraintTimeline obj = (Spine.IkConstraintTimeline)o;
			float[] arg0 = ToLua.CheckNumberArray<float>(L, 2);
			obj.Frames = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Frames on a nil value");
		}
	}
}

