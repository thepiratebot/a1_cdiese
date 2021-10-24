using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Vaisseau
    {
        private int _maxStructure, _maxShield;
        private bool _isAlive;


        public Vaisseau()
        {
        }

        public int MaxStructure { get => _maxStructure; set => _maxStructure = value; }
        public int MaxShield { get => _maxShield; set => _maxShield = value; }
        public bool IsAlive { get => _isAlive; set => _isAlive = value; }
    }
}
