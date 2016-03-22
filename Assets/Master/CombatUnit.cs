using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Master
{
    [Serializable]
    public abstract class CombatUnit : ScriptableObject
    {
        public string displayName;
        public string description;
        public Texture image;
    }

}
