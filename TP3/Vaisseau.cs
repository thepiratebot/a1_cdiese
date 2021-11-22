using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public abstract class Vaisseau
    {
        /* ATTRIBUTES */
        protected int _maxStructure, _maxShield, _structure, _shield;
        protected bool _isAlive;
        protected Armurerie _armory = new Armurerie();

        /* GETTERS & SETTERS */
        public abstract int MaxStructure { get; set; }
        public abstract int MaxShield { get; set; }
        public abstract bool IsAlive { get; set; }
        public abstract Armurerie Armory { get; set; }
        public abstract int Structure { get; set; }
        public abstract int Shield { get; set; }

        /* METHODS */
        public abstract void WeaponAdd(Arme weapon);
        public abstract void WeaponRemove(int index);
        public abstract void ShowWeapons();
        public abstract void Damage(int damage);
        public abstract void Attack(Vaisseau vessel);
    }
}
