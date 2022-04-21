using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairyGUI;
using FairyGUI.Utils;

namespace DemoILRuntime
{
    public class ScaleButton:GButton
    {
        private GTweener _curTween;
        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);
            onTouchBegin.Add(OnTouchDown);
            onTouchEnd.Add(OnTouchUp);
        }

        private void OnTouchDown()
        {
            if(_curTween != null)
            {
                _curTween.Kill();
            }
            _curTween =  this.TweenScale(new UnityEngine.Vector2(1.2f, 1.2f), 0.2f);
        }

        private void OnTouchUp()
        {
            if (_curTween != null)
            {
                _curTween.Kill();
            }
            _curTween = this.TweenScale(new UnityEngine.Vector2(1.0f, 1.0f), 0.2f);
        }
    }
}
