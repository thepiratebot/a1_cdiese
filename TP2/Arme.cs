using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class Arme
    {
        /* ATTRIBUTES */
        private string _name;
        private int _damage, _criticalDamage;
        private double _reloadTime, _roundCounter;
        private Type _typeDamage;

        /* CONSTRUCTORS */
        public Arme(string name, int damage, int criticalDamage, double reloadTime, Type type)
        {
            Name = name;
            Damage = damage;
            CriticalDamage = criticalDamage;
            TypeDamage = type;
            ReloadTime = reloadTime;
            RoundCounter = 0;

            ReloadTime = (type == Type.Explosif) ? ReloadTime * 2 : ReloadTime ; 
        }

        /* GETTERS & SETTERS */
        public string Name { get => _name; set => _name = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public int CriticalDamage { get => _criticalDamage; set => _criticalDamage = value; }
        public double ReloadTime { get => _reloadTime; set => _reloadTime = value; }
        public double RoundCounter { get => _roundCounter; set => _roundCounter = value; }
        public Type TypeDamage { get => _typeDamage; set => _typeDamage = value; }
        
        /* METHODS */
        public int SimulatedShoot()
        {
            if (RoundCounter > 0)
            {
                RoundCounter -= 1;
            } else
            {
                Random random = new Random();

                switch (TypeDamage)
                {
                    case Type.Direct:
                        return (random.Next(1, 10) > 1) ? random.Next(Damage, CriticalDamage) : 0;
                    case Type.Explosif:
                        if (random.Next(1, 4) > 1)
                        {
                            RoundCounter = ReloadTime * 2;
                            return random.Next(Damage, CriticalDamage) * 2;
                        } else
                        {
                            return 0;
                        }
                    case Type.Guidé:
                        return Damage;
                }
            }

            return 0;
        }
        
        /* OTHERS */
        public enum Type
        {
            Direct,
            Explosif,
            Guidé
        }
    }
}
