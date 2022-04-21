using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairyGUI;
using UnityEngine;

namespace DemoILRuntime
{
    public class BaseDemand
    {
        public static void Init()
        {
            GRoot.inst.onClick.Add(PlayClickEffect);
        }

        private static void PlayClickEffect()
        {
            SpineFactory.CrateSkeleton("dianji", "effect", (ske) => {
                if(ske != null)
                {
                    var pos = Input.mousePosition;
                    pos.y = Screen.height - pos.y;
                    var pt = new Vector2(pos.x, pos.y);
                    var outpt =  GRoot.inst.GlobalToLocal(pt);
                    if(ske.disPlayObject != null)
                    {
                        ske.disPlayObject.xy = outpt;
                        ske.Play("idle", false);
                        GRoot.inst.AddChild(ske.disPlayObject);
                        ske.completeCall = () =>
                        {
                            ske.Destroy();
                        };
                    }
                }
             });
        }
    }
}
