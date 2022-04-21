using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class SpineFactory
    {
        private static string _preUri = "Assets/GameMain/Assets/Spine/";
        private static Dictionary<string, SpineTemplete> _templeteDic = new Dictionary<string, SpineTemplete>();
        public static void CrateSkeleton(string name,string folder, SpineTemplete.SkeletonCreateCall callBack)
        {
            var uri = _preUri + folder + "/" + name + "_SkeletonData.asset";
            SpineTemplete templete;
            _templeteDic.TryGetValue(uri, out templete);
            if(templete == null)
            {
                templete = ObjectPool.Get<SpineTemplete>();
                templete.Init(uri); 
                _templeteDic.Add(uri, templete);
            }
            templete.CreateSkeleton(callBack);
        }
    }
}
