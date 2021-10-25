using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Vaisseau
    {
        private int _maxStructure, _maxShield;
        private bool _isAlive;
        private Armurerie _armory;

        public Vaisseau()
        {
            MaxStructure = 3;
            MaxShield = 5;
            IsAlive = true;
            Armory = new Armurerie();
        }

        public int MaxStructure { get => _maxStructure; set => _maxStructure = value; }
        public int MaxShield { get => _maxShield; set => _maxShield = value; }
        public bool IsAlive { get => _isAlive; set => _isAlive = value; }
        public Armurerie Armory { get => _armory; set => _armory = value; }

        public void WeaponAdd(Arme weapon)
        {
            if (Armory.WeaponsList.Count < 3)
                Armory.WeaponsList.Add(weapon);
        }

        public void WeaponRemove(int index)
        {
            if (Armory.WeaponsList.Count > 0)
                Armory.WeaponsList.RemoveAt(index);
        }

        public void ShowWeapons()
        {
            int averageDamage = 0;

            foreach (Arme Weapon in Armory.WeaponsList)
            {
                Console.WriteLine($"Nom : { Weapon.Name } Dégât : { Weapon.Damage } Dégât critique : { Weapon.CriticalDamage } Type de dégât : { Weapon.TypeDamage }");
                averageDamage += Weapon.Damage;
            }

            averageDamage /= Armory.WeaponsList.Count;

            Console.WriteLine($"Dégât moyen du vaisseau : { averageDamage }");
        }
    }
}
