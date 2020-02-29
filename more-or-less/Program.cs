using System;

namespace more_or_less
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisie de l'intervalle du nombre généré
            Console.WriteLine("Veuillez saisir l'intervalle max du nombre généré aléatoirement: ");
            Console.Write("> ");
            string saisieIntervalle = Console.ReadLine();
            saisieIntervalle.ToLower();
            // Si l'utilisateur saisie exit alors on quitte le jeu
            if (saisieIntervalle == "exit")
            {
                Console.WriteLine("Ok ! Bye !");
                Environment.Exit(0);
            }
            int intervalleNumber = 0;
            if (int.TryParse(saisieIntervalle, out intervalleNumber))
            {
                // Génération du nombre avec l'intervalle saisie par l'utilisateur
                intervalleNumber = int.Parse(saisieIntervalle);
                Console.WriteLine("Genration du nombre...");
                int numberGenerate = new Random().Next(1, intervalleNumber);
                bool nbTrouver = false;
                Console.WriteLine("Le nombre que vous devez trouver est donc entre 1 et " + intervalleNumber);


                // Initialisation de la boucle tant que le nombre n'est pas trouvé
                while (!nbTrouver)
                {
                    // Saisie du nombre à trouver
                    Console.Write("> ");
                    string saisie = Console.ReadLine();
                    saisie.ToLower();
                    // Si l'utilisateur saisie exit alors on quitte le jeu
                    if (saisie == "exit")
                    {
                        Console.WriteLine("Ok ! Bye !");
                        Environment.Exit(0);
                    }
                    int numberSaisie;
                    if (int.TryParse(saisie, out numberSaisie))
                    {
                        if (numberSaisie > intervalleNumber || numberSaisie < 1)
                        {
                            // Si le nombre saisie n'est pas valide
                            Console.WriteLine("Veuillez saisir un nombre qui est dans l'intervalle...");
                        }
                        else
                        {
                            numberSaisie = int.Parse(saisie);
                            // Si le nombre saisie est valide
                            if (numberSaisie > numberGenerate)
                            {
                                // Le nombre saisie est au dessus 
                                Console.WriteLine("Pas trouvé! Le nombre aléatoire est plus petit...");
                            }
                            else if (numberSaisie < numberGenerate)
                            {
                                // Le nombre saisie est en dessous
                                Console.WriteLine("Pas trouvé! Le nombre aléatoire est plus grand...");
                            }
                            else
                            {
                                // Le nombre saisie est le bon
                                Console.WriteLine("Bien joué tu as trouvée le nombre etait bien : " + numberGenerate);
                                nbTrouver = true;
                            }
                        }
                    }
                    else
                    {
                        // Si le nombre saisie n'est pas valide
                        Console.WriteLine("Le nombre que vous venez de saisir n'est pas valide...");
                    }
                }
            }
            else
            {
                // Si l'intervalle saisie n'est pas valide
                Console.WriteLine("Veuillez saisir une bonne intervalle.");
            }

            // Il a trouver le nombre
            Console.WriteLine("Bye !");
        }
    }
}
