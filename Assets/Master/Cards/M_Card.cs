using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Master.Cards
{
    [Serializable]
    public class M_Card : ScriptableObject
    {
        public string title;
        public string description;

        public TargetType target;
    }

}
