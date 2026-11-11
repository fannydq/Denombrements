using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Menu du programme
        /// </summary>
        /// <returns>Choix de l'utilisateur</returns>
        static int menu()
        {
            Console.WriteLine("Permutation ...................... 1");
            Console.WriteLine("Arrangement ...................... 2");
            Console.WriteLine("Combinaison ...................... 3");
            Console.WriteLine("Quitter .......................... 0");
            Console.Write("Choix :                            ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Saisie des données pour les calculs
        /// </summary>
        /// <returns>Nombre saisi</returns>
        static int saisie(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcul de r1
        /// </summary>
        /// <param name="t"></param>
        /// <returns>valeur de r1</returns>
        static long calculR1(int t)
        {
            long r1 = 1;
            for (int k = 1; k <= t; k++)
            {
                r1 *= k;
            }
            return r1;
        }

        /// <summary>
        /// Calcul de r2
        /// </summary>
        /// <param name="t"></param>
        /// <returns>valeur de r2</returns>
        static long calculR2(int t, int n)
        {
            long r2 = 1;
            for (int k = (t - n + 1); k <= t; k++)
            {
                r2 *= k;
            }
            return r2;
        }

        /// <summary>
        /// Effectuer des dénombrements (permutations, arrangements, combinaisons)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Traitements associés selon choix dans le menu
            int c = 1;
            do
            {
                c = menu();
                int t, n;
                long r1, r2;
                switch (c)
                {
                    case 1:
                        t = saisie("Nombre total d'éléments à gérer = ");
                        r1 = calculR1(t);
                        Console.WriteLine(t + "! = " + r1);
                        break;
                    case 2:
                        t = saisie("Nombre total d'éléments à gérer = ");
                        n = saisie("Nombre d'éléments dans le sous ensemble = ");
                        r2 = calculR2(t, n);
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r2);
                        break;
                    case 3:
                        t = saisie("Nombre total d'éléments à gérer = ");
                        n = saisie("Nombre d'éléments dans le sous ensemble = ");
                        r1 = calculR1(t);
                        r2 = calculR2(t, n);
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;
                }
            } while (c != 0) ;
            Console.ReadLine();
        }
    }
}
