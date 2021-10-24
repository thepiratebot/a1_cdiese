﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Joueur
    {
        private string _name, _firstname, _nickname;

        public Joueur(string name, string firstname, string nickname)
        {
            _name = FirstUpper(name);
            _firstname = FirstUpper(firstname);
            _nickname = nickname;
        }

        public string Nickname { get => _nickname;}

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
