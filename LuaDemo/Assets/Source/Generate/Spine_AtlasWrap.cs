//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_AtlasWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.Atlas), typeof(System.Object));
		L.RegFunction("GetEnumerator", GetEnumerator);
		L.RegFunction("FlipV", FlipV);
		L.RegFunction("FindRegion", FindRegion);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("New", _CreateSpine_Atlas);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_Atlas(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<Spine.AtlasPage> arg0 = (System.Collections.Generic.List<Spine.AtlasPage>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<Spine.AtlasPage>));
				System.Collections.Generic.List<Spine.AtlasRegion> arg1 = (System.Collections.Generic.List<Spine.AtlasRegion>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<Spine.AtlasRegion>));
				Spine.Atlas obj = new Spine.Atlas(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3)
			{
				System.IO.TextReader arg0 = (System.IO.TextReader)ToLua.CheckObject<System.IO.TextReader>(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				Spine.TextureLoader arg2 = (Spine.TextureLoader)ToLua.CheckObject<Spine.TextureLoader>(L, 3);
				Spine.Atlas obj = new Spine.Atlas(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.Atlas.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Atlas obj = (Spine.Atlas)ToLua.CheckObject<Spine.Atlas>(L, 1);
			System.Collections.Generic.IEnumerator<Spine.AtlasRegion> o = obj.GetEnumerator();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FlipV(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Atlas obj = (Spine.Atlas)ToLua.CheckObject<Spine.Atlas>(L, 1);
			obj.FlipV();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindRegion(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.Atlas obj = (Spine.Atlas)ToLua.CheckObject<Spine.Atlas>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.AtlasRegion o = obj.FindRegion(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Atlas obj = (Spine.Atlas)ToLua.CheckObject<Spine.Atlas>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

