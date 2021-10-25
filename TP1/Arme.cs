using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Arme
    {
        private string _name;
        private int _damage, _criticalDamage;
        private Type _typeDamage;

        public Arme(string name, int damage, int criticalDamage, Type type)
        {
            Name = name;
            Damage = damage;
            CriticalDamage = criticalDamage;
            TypeDamage = type;
        }

        public string Name { get => _name; set => _name = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public int CriticalDamage { get => _criticalDamage; set => _criticalDamage = value; }
        public Type TypeDamage { get => _typeDamage; set => _typeDamage = value; }
        
        public enum Type
        {
            Direct,
            Explosif,
            Guidé
        }
    }
}
