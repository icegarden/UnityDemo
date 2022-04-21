using FairyGUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ImageUtil
{
    public static void SetImgFromBundle(GLoader img,string uri)
    {
        var preUri = "Assets/GameMain/Assets/";
        var loader = new ResourceItemLoader();
        loader.LoadBundleContent(Path.Combine(preUri, uri));
        loader.once(EventConst.BundleContentLoadComplete, (context) =>
        {
            var data = (object[])context.data;
            var tmp = data[0];
            img.texture = new NTexture((Texture2D)tmp);

        });
    }
}

