using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class Joueur
    {
        private string _name, _firstname, _nickname;
        private Vaisseau _vessel;

        public Joueur(string name, string firstname, string nickname)
        {
            _name = FirstUpper(name);
            _firstname = FirstUpper(firstname);
            _nickname = nickname;

            Vessel = new Vaisseau();
        }

        public string Nickname { get => _nickname;}
        public Vaisseau Vessel { get => _vessel; set => _vessel = value; }

        private static string FirstUpper(string statement)
        {
            if (statement == null || statement.Length == 0)
                return "";
            else if (statement.Length == 1)
                return statement.ToUpper();
            else
                return char.ToUpper(statement[0]) + statement.Substring(1).ToLower();
        }

        public string getPlayer()
        {
            return $"{_firstname} {_name}";
        }

        public override string ToString()
        {
            return $"{Nickname} ({getPlayer()})";
        }

        public override bool Equals(object obj)
        {
            Joueur objTest = obj as Joueur;

            return objTest is Joueur && objTest._nickname == _nickname;
        }
    }
}
