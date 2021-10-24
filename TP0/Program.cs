using System;
using System.Linq;

namespace tp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool current_status = true;

            while (current_status)
            {
                string prenom = "", nom = "";
                int taille = 0, poids = 0, age = 0;

                Console.WriteLine("Squala bienvenu !");

                bool test = true;

                /* PRENOM */

                Console.Write("(votre prénom svp, c'est pour la suite du scénanar) : ");
                while (test)
                {
                    prenom = Console.ReadLine();
                    if (prenom.Any(char.IsDigit))
                        Console.WriteLine("Votre prénom contient au moins un chiffre !");
                    else
                        test = !test;
                }

                /* NOM */

                Console.Write("(la meme pour le nom, je sais c'est relou) : ");
                while (!test)
                {
                    nom = Console.ReadLine();
                    if (nom.Any(char.IsDigit))
                        Console.WriteLine("Votre nom contient au moins un chiffre !");
                    else
                        test = !test;
                }

                Console.WriteLine(Environment.NewLine + "Mhmhmh bon sang, qu'est-ce que l'on peut s'ennuyer ici !");
                Console.WriteLine($"Mon petit {call(prenom, nom)} ! Cette paix et se pourquoi lutte tout les vrais guerriers !");

                /* TAILLE */

                Console.Write("(votre taille en cm a cause du tapis de squalala) : ");
                while (test)
                {
                    string local_test = Console.ReadLine();

                    if (int.TryParse(local_test, out taille))
                    {
                        if (taille < 0)
                            Console.WriteLine("Ce n'est pas bon !");
                        else
                            test = !test;
                    }
                    else
                        Console.WriteLine("Ce n'est pas bon !");
                }

                /* POIDS */

                Console.Write("(le poids en kg svp, je jure on juge pas) : ");
                while (!test)
                {
                    string local_test = Console.ReadLine();

                    if (int.TryParse(local_test, out poids))
                    {
                        if (poids < 0)
                            Console.WriteLine("Ce n'est pas bon !");
                        else
                            test = !test;
                    }
                    else
                        Console.WriteLine("Ce n'est pas bon !");
                }


                Console.WriteLine($"Votre imc au fait : { imc(poids, taille).ToString("0.0") } !");
                commentary(imc(poids, taille));

                /* AGE */

                Console.Write("(l'age en année de vie parce que la vie) : ");
                while (test)
                {
                    string local_test = Console.ReadLine();

                    if (int.TryParse(local_test, out age))
                    {
                        if (age < 0)
                            Console.WriteLine("Ce n'est pas bon !");
                        else
                            test = !test;
                    }
                    else
                        Console.WriteLine("Ce n'est pas bon !");
                }

                Console.WriteLine("Et un petit baiser pour me porter chance ? ");
                if (age >= 18)
                    Console.WriteLine("Tu veux plaisanter ?");
                else
                    Console.WriteLine("NON TU N'EST PAS MAJEUR, JE NE SUIS PAS UNE PEDOPHILE" + Environment.NewLine +
                        "         ▄              ▄    " + Environment.NewLine +
                        "        ▌▒█           ▄▀▒▌   " + Environment.NewLine +
                        "        ▌▒▒█        ▄▀▒▒▒▐   " + Environment.NewLine +
                        "       ▐▄█▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐   " + Environment.NewLine +
                        "     ▄▄▀▒▒▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐   " + Environment.NewLine +
                        "   ▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌   " + Environment.NewLine +
                        "  ▐▒▒▒▄▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄▒▌  " + Environment.NewLine +
                        "  ▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐  " + Environment.NewLine +
                        " ▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌ " + Environment.NewLine +
                        " ▌░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌ " + Environment.NewLine +
                        "▌▒▒▒▄██▄▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▐ " + Environment.NewLine +
                        "▐▒▒▐▄█▄█▌▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▌" + Environment.NewLine +
                        "▐▒▒▐▀▐▀▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▐ " + Environment.NewLine +
                        " ▌▒▒▀▄▄▄▄▄▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▌ " + Environment.NewLine +
                        " ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▄▒▒▐  " + Environment.NewLine +
                        "  ▀▄▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▄▒▒▒▒▌  " + Environment.NewLine +
                        "    ▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀   " + Environment.NewLine +
                        "      ▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀     " + Environment.NewLine +
                        "         ▀▀▀▀▀▀▀▀▀▀▀▀    #RIP");


                /* JEU DES CHEVEUX */

                while (!test)
                {
                    int nbrCheveux = 0;

                    Console.Write("Combien avez vous de cheveux ? ");
                    while (!int.TryParse(Console.ReadLine(), out nbrCheveux))
                    {
                        Console.WriteLine("Ce n'est pas un chiffre !");
                    }

                    if (nbrCheveux >= 100000 && nbrCheveux <= 150000)
                    {
                        Console.WriteLine("Vous semblez avoir bon !");
                        test = !test;
                    }
                }

                /* SELECTION */

                int choix;

                Console.WriteLine("Que souhaitez-vous faire ? " + Environment.NewLine +
                                    "1 - Quitter le programme" + Environment.NewLine +
                                    "2 - Recommencer le programme" + Environment.NewLine +
                                    "3 - Compter jusqu'à 10" + Environment.NewLine +
                                    "4 - Téléphoner à Tata Jacqueline" + Environment.NewLine);
                choix = int.Parse(Console.ReadLine());

               switch (choix)
                {
                    case 1:
                        Console.WriteLine("Giscard d'Estaing : 'Au revoir' #sondelamarseillaise");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    case 3:
                        for (int i = 1; i <=10; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.WriteLine("Giscard d'Estaing : 'Au revoir' #sondelamarseillaise");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    case 4:
                        Console.WriteLine("Salut dü ! Wie getz ? Des ech d messagerie von mini smartphone, jetz benne ich net do, du kanch lachmich am arch ech leui net, over des est velicht wechtig so ruf mich an nor a mal.");
                        Console.WriteLine("Giscard d'Estaing : 'Au revoir' #sondelamarseillaise");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                }
                
            }
        }

        public static string call(string prenom, string nom)
        {
            return prenom.ToLower() + " " + nom.ToUpper();
        }

        public static float imc(int poids, int taille)
        {
            return poids / ((float) Math.Pow(taille, 2) / 10000 );
        }

        public static void commentary(float imc)
        {
            const string a = "Attention à l'anorexie !";
            const string b = "Vous êtes un peu maigrichon !";
            const string c = "Vous êtes de corpulence normale !";
            const string d = "Vous êtes en surpoids !";
            const string e = "Obésité modérée !";
            const string f = "Obésité sévère !";
            const string g = "Obésité morbide !";


            if (imc < 16.5)
                Console.WriteLine(a);
            else if (imc < 18.5)
                Console.WriteLine(b);
            else if (imc < 25)
                Console.WriteLine(c);
            else if (imc < 30)
                Console.WriteLine(d);
            else if (imc < 35)
                Console.WriteLine(e);
            else if (imc < 40)
                Console.WriteLine(f);
            else if (imc >= 40)
                Console.WriteLine(g);
        }
    }
}
