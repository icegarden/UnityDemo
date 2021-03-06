//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_ScaleTimelineWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.ScaleTimeline), typeof(Spine.TranslateTimeline));
		L.RegFunction("Apply", Apply);
		L.RegFunction("New", _CreateSpine_ScaleTimeline);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("PropertyId", get_PropertyId, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_ScaleTimeline(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				Spine.ScaleTimeline obj = new Spine.ScaleTimeline(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.ScaleTimeline.New");
			}
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
			Spine.ScaleTimeline obj = (Spine.ScaleTimeline)ToLua.CheckObject<Spine.ScaleTimeline>(L, 1);
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
			Spine.ScaleTimeline obj = (Spine.ScaleTimeline)o;
			int ret = obj.PropertyId;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PropertyId on a nil value");
		}
	}
}

