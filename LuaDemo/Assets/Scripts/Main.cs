using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.IO;

public class Main : LuaClient
{
    private GameObject ins;

    private ArrayList filePaths;

    protected override void StartMain()
    {
        filePaths = new ArrayList();
        DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(800, 50);
        doLuaFile(Application.dataPath + "/LuaScript", luaState);
        searchDirectory(Application.dataPath + "/LuaScript", luaState);

        //如果出现因为继承导致的引用顺序问题，记得在子类中require一下父类
        var len = filePaths.Count;
        for (var i = 0; i < len; i++)
        {
            luaState.DoFile(filePaths[i] as string);
        }
        luaState.DoFile(Application.dataPath + "/LuaScript/Main.lua");
        base.StartMain();
    }
    void Start()
    {
        // Camera camera = this.gameObject.GetComponent<Camera>();
        // Canvas canvas = camera.GetComponentInChildren<Canvas>();
        // Object obj = Resources.Load("Prefabs/ui/login");
        // ins = Instantiate(obj) as GameObject;
        // ins.transform.SetParent(canvas.transform);
        // ins.transform.localPosition = new Vector3(0,0,0);
        // ins.transform.localPosition.Set(100,100,0);
        // var tt = ins.transform as RectTransform;
        // tt.SetSizeWithCurrentAnchors()
        // UnityEngine.UI.Text
        // var size = tt.rect.size;
        // tt.rect.width
        // ArrayList a = new ArrayList();
        // a.Add(1);
        // Debug.Log(a[0]);
        // Resources.Load("",typeof(Projector));
        // UnityEngine.RectTransformUtility
    }

    private void searchDirectory(string path, LuaState state)
    {
        var dirs = Directory.GetDirectories(path);
        foreach (var dirpath in dirs)
        {
            doLuaFile(dirpath, state);
            searchDirectory(dirpath, state);
        }


    }

    private void doLuaFile(string path, LuaState state)
    {
        var paths = Directory.GetFiles(path);
        state.AddSearchPath(path);
        foreach (var url in paths)
        {
            if (Path.GetExtension(url) == ".lua")
            {
                var filename = Path.GetFileName(url);
                if (filename != "Main.lua")
                {
                    filePaths.Add(url);
                }
            }
        }
    }
}
