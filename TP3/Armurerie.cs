using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class Armurerie
    {
        private List<Arme> _weaponsList = new List<Arme>();

        public Armurerie() {}

        public List<Arme> WeaponsList { get => _weaponsList; set => _weaponsList = value; }
    }
}
