//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_AutoPlayWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.AutoPlay));
		L.RegVar("None", get_None, null);
		L.RegVar("AutoPlaySequences", get_AutoPlaySequences, null);
		L.RegVar("AutoPlayTweeners", get_AutoPlayTweeners, null);
		L.RegVar("All", get_All, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<DG.Tweening.AutoPlay>.Check = CheckType;
		StackTraits<DG.Tweening.AutoPlay>.Push = Push;
	}

	static void Push(IntPtr L, DG.Tweening.AutoPlay arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(DG.Tweening.AutoPlay), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.AutoPlay.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AutoPlaySequences(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.AutoPlay.AutoPlaySequences);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AutoPlayTweeners(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.AutoPlay.AutoPlayTweeners);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_All(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.AutoPlay.All);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DG.Tweening.AutoPlay o = (DG.Tweening.AutoPlay)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

