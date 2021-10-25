using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Arme
    {
        public string _name;
        public int _damage, _criticalDamage;
        public enum _type
        {
            Direct,
            Explosif,
            Guidé
        }
    }
}
