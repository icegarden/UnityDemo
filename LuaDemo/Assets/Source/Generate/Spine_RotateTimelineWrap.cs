﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_RotateTimelineWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.RotateTimeline), typeof(Spine.CurveTimeline));
		L.RegFunction("SetFrame", SetFrame);
		L.RegFunction("Apply", Apply);
		L.RegFunction("New", _CreateSpine_RotateTimeline);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("ENTRIES", 2);
		L.RegVar("PropertyId", get_PropertyId, null);
		L.RegVar("BoneIndex", get_BoneIndex, set_BoneIndex);
		L.RegVar("Frames", get_Frames, set_Frames);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_RotateTimeline(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				Spine.RotateTimeline obj = new Spine.RotateTimeline(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.RotateTimeline.New");
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
			ToLua.CheckArgsCount(L, 4);
			Spine.RotateTimeline obj = (Spine.RotateTimeline)ToLua.CheckObject<Spine.RotateTimeline>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.SetFrame(arg0, arg1, arg2);
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
			Spine.RotateTimeline obj = (Spine.RotateTimeline)ToLua.CheckObject<Spine.RotateTimeline>(L, 1);
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
			Spine.RotateTimeline obj = (Spine.RotateTimeline)o;
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
	static int get_BoneIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.RotateTimeline obj = (Spine.RotateTimeline)o;
			int ret = obj.BoneIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BoneIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Frames(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.RotateTimeline obj = (Spine.RotateTimeline)o;
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
	static int set_BoneIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.RotateTimeline obj = (Spine.RotateTimeline)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.BoneIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BoneIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Frames(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.RotateTimeline obj = (Spine.RotateTimeline)o;
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

