using Assets.Battles.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Master
{

    [Serializable]
    public class M_Dungeon : ScriptableObject
    {
        public string key;
        public string name;
        public string backgroundimage;
        public string rank;
        public M_Battle[] battles;
    }

}
