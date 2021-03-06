//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_SkinWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.Skin), typeof(System.Object));
		L.RegFunction("AddAttachment", AddAttachment);
		L.RegFunction("GetAttachment", GetAttachment);
		L.RegFunction("RemoveAttachment", RemoveAttachment);
		L.RegFunction("FindNamesForSlot", FindNamesForSlot);
		L.RegFunction("FindAttachmentsForSlot", FindAttachmentsForSlot);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateSpine_Skin);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Name", get_Name, null);
		L.RegVar("Attachments", get_Attachments, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_Skin(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				Spine.Skin obj = new Spine.Skin(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.Skin.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddAttachment(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Spine.Skin obj = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			Spine.Attachment arg2 = (Spine.Attachment)ToLua.CheckObject<Spine.Attachment>(L, 4);
			obj.AddAttachment(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAttachment(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Spine.Skin obj = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			Spine.Attachment o = obj.GetAttachment(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAttachment(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Spine.Skin obj = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.RemoveAttachment(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindNamesForSlot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Spine.Skin obj = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.Generic.List<string> arg1 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.List<string>));
			obj.FindNamesForSlot(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindAttachmentsForSlot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Spine.Skin obj = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.Generic.List<Spine.Attachment> arg1 = (System.Collections.Generic.List<Spine.Attachment>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.List<Spine.Attachment>));
			obj.FindAttachmentsForSlot(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Skin obj = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Skin obj = (Spine.Skin)o;
			string ret = obj.Name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Attachments(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Skin obj = (Spine.Skin)o;
			System.Collections.Generic.Dictionary<Spine.Skin.AttachmentKeyTuple,Spine.Attachment> ret = obj.Attachments;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Attachments on a nil value");
		}
	}
}

