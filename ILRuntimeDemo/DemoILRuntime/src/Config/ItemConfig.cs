using System;
using System.Collections.Generic;
[Serializable]
public class ItemConfig : IConfig
{

    public List<SubConfig> allItems;
    public void Parse()
    {

    }

    [Serializable]
    public class SubConfig
    {
        public int id;
        public string name;
        public string icon;
        public int type;
        public int subType;
        public int parameters;
        public int level;
        public int quality;
        public int stackCount;
        public int bagTab;
        public int displayType;
        public int autoUse;
        public int minUseLevel;
        public int maxUseLevel;
        public string desc;
        public int chip;

        public List<int> getWay;
        public List<int> useFor;
        public List<List<int>> compose;
        public List<List<int>> resolve;
    }
}