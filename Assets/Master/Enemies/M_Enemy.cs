using Assets.Master.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Master.Enemies
{
    [Serializable]
    public class M_Enemy : ScriptableObject
    {
        public string rank;
        public int exp;
        
        public M_Card[] deck;
    }
}
