using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class SpaceInvaders
    {
        private List<Joueur> _playersList = new List<Joueur>();

        public SpaceInvaders()
        {
            Init();
        }

        public static void Main(string[] args)
        {
            SpaceInvaders spaceInvaders = new SpaceInvaders();
            
            foreach (Joueur Player in spaceInvaders.PlayersList)
            {
                Console.WriteLine(Player.ToString());
                Player.Vessel.ShowWeapons();
                Console.WriteLine();
            }
        }

        private void Init()
        {
            Joueur _playerOne = new Joueur("Weber", "Brice", "ThePirateBot");
            Joueur _playerTwo = new Joueur("Harlé", "Maxime", "El Professor");
            Joueur _playerThree = new Joueur("Muller", "Jean-Marc", "Sidi Raïs");

            PlayersList.Add(_playerOne);
            PlayersList.Add(_playerTwo);
            PlayersList.Add(_playerThree);
        }

        public List<Joueur> PlayersList { get => _playersList;}
    }
}
