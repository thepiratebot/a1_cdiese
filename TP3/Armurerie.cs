using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public class Armurerie
    {
        /* ATTRIBUTES */
        private List<Arme> _weaponsList = new List<Arme>();

        /* CONSTRUCTORS */
        public Armurerie() {}

        /* GETTERS & SETTERS */
        public List<Arme> WeaponsList { get => _weaponsList; set => _weaponsList = value; }
    }
}
