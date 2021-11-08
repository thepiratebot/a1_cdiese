﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP2.VesselChild
{
    public class Rocinante : Vaisseau
    {
        /* CONSTRUCTORS */
        public Rocinante()
        {
            MaxStructure = 3;
            MaxShield = 5;

            Structure = MaxStructure;
            Shield = MaxShield;

            IsAlive = true;

            WeaponAdd(new Arme("Torpille", 3, 3, 2, Arme.Type.Guidé));
        }

        /* GETTERS & SETTERS */
        public override int MaxStructure { get => _maxStructure; set => _maxStructure = value; }
        public override int MaxShield { get => _maxShield; set => _maxShield = value; }
        public override bool IsAlive { get => _isAlive; set => _isAlive = value; }
        public override Armurerie Armory { get => _armory; set => _armory = value; }
        public override int Structure { get => _structure; set => _structure = value; }
        public override int Shield { get => _shield; set => _shield = value; }

        /* METHODS */
        public override void WeaponAdd(Arme weapon)
        {
            if (Armory.WeaponsList.Count < 3)
                Armory.WeaponsList.Add(weapon);
        }

        public override void WeaponRemove(int index)
        {
            if (Armory.WeaponsList.Count > 0)
                Armory.WeaponsList.RemoveAt(index);
        }

        public override void ShowWeapons()
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

        public override void Damage(int damage)
        {
            if (damage > Structure + Shield)
            {
                IsAlive = false;
            }
            else
            {
                damage -= Shield;
                if (damage > 0)
                {
                    Shield = 0;
                    Structure -= damage;
                }
                else
                {
                    Shield -= damage;
                }
            }
        }

        public override void Attack(Vaisseau vessel)
        {
            if (Armory.WeaponsList.Count == 1)
            {
                vessel.Damage(Armory.WeaponsList[0].Damage);
            }
            else
            {
                Console.WriteLine($"Veuillez choisir l'arme avec laquel vous souhaitez tirer : ");

                int indice = 0;
                foreach (Arme Weapon in Armory.WeaponsList)
                {
                    Console.WriteLine($"[{ indice }] - { Weapon.Name }");
                    indice++;
                }

                bool wait = true;
                while (wait)
                {
                    int choose = Int32.Parse(Console.ReadLine());
                    if (choose <= Armory.WeaponsList.Count && choose >= 0)
                    {
                        vessel.Damage(Armory.WeaponsList[choose].Damage);
                        wait = false;
                    }
                }
            }
        }
    }
}
