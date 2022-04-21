﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_Unity_SkeletonRendererInstructionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.Unity.SkeletonRendererInstruction), typeof(System.Object));
		L.RegFunction("Clear", Clear);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("SetWithSubset", SetWithSubset);
		L.RegFunction("Set", Set);
		L.RegFunction("GeometryNotEqual", GeometryNotEqual);
		L.RegFunction("New", _CreateSpine_Unity_SkeletonRendererInstruction);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("submeshInstructions", get_submeshInstructions, null);
		L.RegVar("immutableTriangles", get_immutableTriangles, set_immutableTriangles);
		L.RegVar("hasActiveClipping", get_hasActiveClipping, set_hasActiveClipping);
		L.RegVar("rawVertexCount", get_rawVertexCount, set_rawVertexCount);
		L.RegVar("attachments", get_attachments, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_Unity_SkeletonRendererInstruction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Spine.Unity.SkeletonRendererInstruction obj = new Spine.Unity.SkeletonRendererInstruction();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.Unity.SkeletonRendererInstruction.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 1);
			obj.Clear();
			return 0;
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
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetWithSubset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 1);
			Spine.ExposedList<Spine.Unity.SubmeshInstruction> arg0 = (Spine.ExposedList<Spine.Unity.SubmeshInstruction>)ToLua.CheckObject<Spine.ExposedList<Spine.Unity.SubmeshInstruction>>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			obj.SetWithSubset(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Set(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 1);
			Spine.Unity.SkeletonRendererInstruction arg0 = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 2);
			obj.Set(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GeometryNotEqual(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.Unity.SkeletonRendererInstruction arg0 = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 1);
			Spine.Unity.SkeletonRendererInstruction arg1 = (Spine.Unity.SkeletonRendererInstruction)ToLua.CheckObject<Spine.Unity.SkeletonRendererInstruction>(L, 2);
			bool o = Spine.Unity.SkeletonRendererInstruction.GeometryNotEqual(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_submeshInstructions(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			Spine.ExposedList<Spine.Unity.SubmeshInstruction> ret = obj.submeshInstructions;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index submeshInstructions on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_immutableTriangles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			bool ret = obj.immutableTriangles;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index immutableTriangles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasActiveClipping(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			bool ret = obj.hasActiveClipping;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hasActiveClipping on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rawVertexCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			int ret = obj.rawVertexCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rawVertexCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_attachments(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			Spine.ExposedList<Spine.Attachment> ret = obj.attachments;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index attachments on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_immutableTriangles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.immutableTriangles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index immutableTriangles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hasActiveClipping(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.hasActiveClipping = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hasActiveClipping on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rawVertexCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonRendererInstruction obj = (Spine.Unity.SkeletonRendererInstruction)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.rawVertexCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rawVertexCount on a nil value");
		}
	}
}
