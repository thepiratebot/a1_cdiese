using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class SpaceInvaders
    {
        private List<Joueur> _playerList = new List<Joueur>();

        public SpaceInvaders()
        {
            Init();
        }

        public static void Main(string[] args)
        {
            SpaceInvaders spaceInvaders = new SpaceInvaders();
            
            foreach (Joueur player in spaceInvaders.PlayerList)
            {
                Console.WriteLine(player.ToString());
            }
        }

        private void Init()
        {
            Joueur _playerOne = new Joueur("Weber", "Brice", "ThePirateBot");
            Joueur _playerTwo = new Joueur("Harlé", "Maxime", "El Professor");
            Joueur _playerThree = new Joueur("Muller", "Jean-Marc", "Sidi Raïs");

            PlayerList.Add(_playerOne);
            PlayerList.Add(_playerTwo);
            PlayerList.Add(_playerThree);
        }

        public List<Joueur> PlayerList { get => _playerList;}
    }
}
