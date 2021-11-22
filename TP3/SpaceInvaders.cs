using System;
using System.Collections.Generic;
using System.Text;
using TP2.VesselChild;

namespace TP2
{
    public class SpaceInvaders
    {
        /* ATTRIBUTES */
        private List<Joueur> _playersList = new List<Joueur>();
        private List<Vaisseau> _ennemyList = new List<Vaisseau>();

        /* CONSTRUCTORS */
        public SpaceInvaders()
        {
            Init();
        }

        /** MAIN **/
        public static void Main(string[] args)
        {
            SpaceInvaders spaceInvaders = new SpaceInvaders();
            bool isPlaying = true;

            foreach (Joueur Player in spaceInvaders.PlayersList)
            {
                Console.WriteLine(Player.ToString());
                Player.Vessel.ShowWeapons();
                Console.WriteLine();
            }

            while(isPlaying)
            {
                spaceInvaders.Round();

                // Vérification des conditions pour continuer la partie.
                foreach(Joueur Player in spaceInvaders.PlayersList)
                {
                    if (!Player.Vessel.IsAlive)
                    {
                        isPlaying = false;
                    }
                }
                foreach(Vaisseau Ennemy in spaceInvaders.EnnemyList)
                {
                    if (Ennemy.IsAlive)
                    {
                        isPlaying = true;
                        break;
                    }
                }
            }
        }

        /* GETTERS & SETTERS */
        public List<Joueur> PlayersList { get => _playersList; }
        public List<Vaisseau> EnnemyList { get => _ennemyList; }

        /* METHODS */
        private void Init()
        {
            // PlayersList.Add(new Joueur("Weber", "Brice", "ThePirateBot"));
            // PlayersList.Add(new Joueur("Harlé", "Maxime", "El Professor"));
            PlayersList.Add(new Joueur("Muller", "Jean-Marc", "Sidi Raïs"));

            EnnemyList.Add(new B_Wings());
            EnnemyList.Add(new Dart());
            EnnemyList.Add(new F_18());
            EnnemyList.Add(new Rocinante());
            EnnemyList.Add(new Tardis());
        }

        public void Round()
        {
            Random random = new Random();
            foreach (Vaisseau EnnemyVessel in EnnemyList)
            {
                int indice = random.Next(0, EnnemyList.Count);

                if (EnnemyList[indice].IsAlive)
                {
                    if (indice > 1)
                    {
                        PlayersList[0].Vessel.Attack(EnnemyList[indice]);
                        Console.WriteLine("Joueur a tiré");
                    }
                    else
                    {
                        EnnemyVessel.Attack(PlayersList[0].Vessel);
                        Console.WriteLine("Ennemie a tiré");
                        Console.WriteLine($"Il vous reste : { PlayersList[0].Vessel.Shield } points de bouclier et { PlayersList[0].Vessel.Structure } points de structure");
                    }
                }
            }

            // Redonne des points de bouclier.
            foreach (Vaisseau EnnemyVessel in EnnemyList)
            {
                if (EnnemyVessel.Shield != EnnemyVessel.MaxShield)
                {
                    if (EnnemyVessel.Shield <= EnnemyVessel.MaxShield - 2)
                    {
                        EnnemyVessel.Shield += 2;
                    } 
                    else
                    {
                        EnnemyVessel.Shield++;
                    }
                }
            }
            foreach (Joueur PlayerVessel in PlayersList)
            {
                if (PlayerVessel.Vessel.Shield != PlayerVessel.Vessel.MaxShield)
                {
                    if (PlayerVessel.Vessel.Shield <= PlayerVessel.Vessel.MaxShield)
                    {
                        PlayerVessel.Vessel.Shield += 2;
                    } 
                    else
                    {
                        PlayerVessel.Vessel.Shield++;
                    }
                }
            }
        }
    }
}
