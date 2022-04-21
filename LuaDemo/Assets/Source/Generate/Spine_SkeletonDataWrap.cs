﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_SkeletonDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.SkeletonData), typeof(System.Object));
		L.RegFunction("FindBone", FindBone);
		L.RegFunction("FindBoneIndex", FindBoneIndex);
		L.RegFunction("FindSlot", FindSlot);
		L.RegFunction("FindSlotIndex", FindSlotIndex);
		L.RegFunction("FindSkin", FindSkin);
		L.RegFunction("FindEvent", FindEvent);
		L.RegFunction("FindAnimation", FindAnimation);
		L.RegFunction("FindIkConstraint", FindIkConstraint);
		L.RegFunction("FindTransformConstraint", FindTransformConstraint);
		L.RegFunction("FindPathConstraint", FindPathConstraint);
		L.RegFunction("FindPathConstraintIndex", FindPathConstraintIndex);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateSpine_SkeletonData);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Name", get_Name, set_Name);
		L.RegVar("Bones", get_Bones, null);
		L.RegVar("Slots", get_Slots, null);
		L.RegVar("Skins", get_Skins, set_Skins);
		L.RegVar("DefaultSkin", get_DefaultSkin, set_DefaultSkin);
		L.RegVar("Events", get_Events, set_Events);
		L.RegVar("Animations", get_Animations, set_Animations);
		L.RegVar("IkConstraints", get_IkConstraints, set_IkConstraints);
		L.RegVar("TransformConstraints", get_TransformConstraints, set_TransformConstraints);
		L.RegVar("PathConstraints", get_PathConstraints, set_PathConstraints);
		L.RegVar("Width", get_Width, set_Width);
		L.RegVar("Height", get_Height, set_Height);
		L.RegVar("Version", get_Version, set_Version);
		L.RegVar("Hash", get_Hash, set_Hash);
		L.RegVar("ImagesPath", get_ImagesPath, set_ImagesPath);
		L.RegVar("AudioPath", get_AudioPath, set_AudioPath);
		L.RegVar("Fps", get_Fps, set_Fps);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSpine_SkeletonData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Spine.SkeletonData obj = new Spine.SkeletonData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Spine.SkeletonData.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindBone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.BoneData o = obj.FindBone(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindBoneIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int o = obj.FindBoneIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSlot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.SlotData o = obj.FindSlot(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSlotIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int o = obj.FindSlotIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSkin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.Skin o = obj.FindSkin(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.EventData o = obj.FindEvent(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindAnimation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.Animation o = obj.FindAnimation(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindIkConstraint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.IkConstraintData o = obj.FindIkConstraint(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindTransformConstraint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.TransformConstraintData o = obj.FindTransformConstraint(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindPathConstraint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Spine.PathConstraintData o = obj.FindPathConstraint(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindPathConstraintIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int o = obj.FindPathConstraintIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
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
			Spine.SkeletonData obj = (Spine.SkeletonData)ToLua.CheckObject<Spine.SkeletonData>(L, 1);
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
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
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
	static int get_Bones(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.BoneData> ret = obj.Bones;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Bones on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Slots(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.SlotData> ret = obj.Slots;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Slots on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Skins(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.Skin> ret = obj.Skins;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Skins on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DefaultSkin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.Skin ret = obj.DefaultSkin;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DefaultSkin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Events(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.EventData> ret = obj.Events;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Events on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Animations(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.Animation> ret = obj.Animations;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Animations on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IkConstraints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.IkConstraintData> ret = obj.IkConstraints;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IkConstraints on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TransformConstraints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.TransformConstraintData> ret = obj.TransformConstraints;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TransformConstraints on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PathConstraints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.PathConstraintData> ret = obj.PathConstraints;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PathConstraints on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			float ret = obj.Width;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			float ret = obj.Height;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Version(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string ret = obj.Version;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Version on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Hash(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string ret = obj.Hash;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Hash on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ImagesPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string ret = obj.ImagesPath;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ImagesPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AudioPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string ret = obj.AudioPath;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AudioPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Fps(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			float ret = obj.Fps;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Fps on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Skins(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.Skin> arg0 = (Spine.ExposedList<Spine.Skin>)ToLua.CheckObject<Spine.ExposedList<Spine.Skin>>(L, 2);
			obj.Skins = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Skins on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DefaultSkin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.Skin arg0 = (Spine.Skin)ToLua.CheckObject<Spine.Skin>(L, 2);
			obj.DefaultSkin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DefaultSkin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Events(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.EventData> arg0 = (Spine.ExposedList<Spine.EventData>)ToLua.CheckObject<Spine.ExposedList<Spine.EventData>>(L, 2);
			obj.Events = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Events on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Animations(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.Animation> arg0 = (Spine.ExposedList<Spine.Animation>)ToLua.CheckObject<Spine.ExposedList<Spine.Animation>>(L, 2);
			obj.Animations = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Animations on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IkConstraints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.IkConstraintData> arg0 = (Spine.ExposedList<Spine.IkConstraintData>)ToLua.CheckObject<Spine.ExposedList<Spine.IkConstraintData>>(L, 2);
			obj.IkConstraints = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IkConstraints on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TransformConstraints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.TransformConstraintData> arg0 = (Spine.ExposedList<Spine.TransformConstraintData>)ToLua.CheckObject<Spine.ExposedList<Spine.TransformConstraintData>>(L, 2);
			obj.TransformConstraints = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TransformConstraints on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PathConstraints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			Spine.ExposedList<Spine.PathConstraintData> arg0 = (Spine.ExposedList<Spine.PathConstraintData>)ToLua.CheckObject<Spine.ExposedList<Spine.PathConstraintData>>(L, 2);
			obj.PathConstraints = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PathConstraints on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Width = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Version(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Version = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Version on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Hash(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Hash = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Hash on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ImagesPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.ImagesPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ImagesPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AudioPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.AudioPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AudioPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Fps(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.SkeletonData obj = (Spine.SkeletonData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Fps = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Fps on a nil value");
		}
	}
}

