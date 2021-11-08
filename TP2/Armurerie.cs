using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class Armurerie
    {
        private List<Arme> _weaponsList = new List<Arme>();

        public Armurerie()
        {
            Init();
        }

        public List<Arme> WeaponsList { get => _weaponsList; set => _weaponsList = value; }

        public void Init()
        {
            Arme _weaponOne = new Arme("AK FA", 15, 25, Arme.Type.Direct);
            Arme _weaponTwo = new Arme("Space RPG", 50, 75, Arme.Type.Guidé);
            Arme _weaponThree = new Arme("C4 Propagation", 21, 45, Arme.Type.Explosif);

            WeaponsList.Add(_weaponOne);
            WeaponsList.Add(_weaponTwo);
            WeaponsList.Add(_weaponThree);
        }
    }
}
