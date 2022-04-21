using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityGameFramework.Runtime;

public class GameResourceLoadHelper : DefaultLoadResourceAgentHelper
{
    public override void OnBundleReady(object asset)
    {
        base.OnBundleReady(asset);
        var bundle = (AssetBundle)asset;
        EventUtil.dispatch(EventConst.BundleLoadComplete, new object[] { bundle });
    }
}

