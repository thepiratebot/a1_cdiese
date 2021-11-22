using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TP3
{
    public class ArmeImporteur
    {
        /* ATTRIBUTES */
        private Dictionary<string, int> _extract = new Dictionary<string, int>();
        private List<string> _blackList = new List<string>();
        private List<Arme> _weaponImport = new List<Arme>();

        /* CONSTRUCTORS */
        public ArmeImporteur(int StringLenght) 
        {
            StreamReader _file = new StreamReader($"C:\\Users\\Brice - DevOps\\Desktop\\test.txt");
            StreamReader _fileBlackList = new StreamReader($"C:\\Users\\Brice - DevOps\\Desktop\\blacklist.txt");

            // Permet de récupérer une liste de mot en liste noire depuis un fichier source
            foreach (string _word in _fileBlackList.ReadToEnd().Split())
            {
                if (_word != "")
                {
                    string _cleanWord = Regex.Replace(_word, @"[^\w\s\d]", "").ToLower();

                    if (!_blackList.Contains(_cleanWord))
                        _blackList.Add(_cleanWord);
                }
            }

            // Permet de récupérer une liste de mot depuis un fichier source
            foreach (string _word in _file.ReadToEnd().Split())
            {
                if (_word != "" && _word.Length >= StringLenght && !BlackList.Contains(_word))
                {
                    string _cleanWord = Regex.Replace(_word, @"[^\w\s\d]", "").ToLower();

                    if (_extract.ContainsKey(_cleanWord))
                        _extract[_cleanWord]++;
                    else
                        _extract.Add(_cleanWord, 1);
                }
            }

            // Permet de générer des armes et les stocks dans la liste _weaponImport
            foreach (KeyValuePair<string, int> _word in _extract)
            {
                Array values = Enum.GetValues(typeof(Arme.Type));
                Random random = new Random();

                Arme.Type randomType = (Arme.Type)values.GetValue(random.Next(values.Length));

                if (_word.Value > _word.Key.Length)
                    _weaponImport.Add(new Arme(_word.Key, _word.Key.Length, _word.Value, 1, randomType));
                else
                    _weaponImport.Add(new Arme(_word.Key, _word.Value, _word.Key.Length, 1, randomType));
            }
        }

        /* GETTERS & SETTERS */
        public Dictionary<string, int> Extract { get => _extract; set => _extract = value; }
        public List<string> BlackList { get => _blackList; set => _blackList = value; }
        public List<Arme> WeaponImport { get => _weaponImport; set => _weaponImport = value; }
    }
}