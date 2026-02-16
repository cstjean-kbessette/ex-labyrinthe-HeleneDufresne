using System.Collections.Generic;

namespace Labyrinthe
{
    internal class View
    {

        public void AfficherLabyrinthe(Labyrinthe labyrinthe)
        {
            for (int y = 0; y < labyrinthe.Hauteur(); y++)
            {
                for (int x = 0; x < labyrinthe.Largeur(); x++)
                {
                    if (labyrinthe.PosJoueur(x,y))
                        Console.Write('P');
                    else
                        Console.Write(labyrinthe.Carte(x, y));
                }
                Console.WriteLine();
            }
        }

        public void AfficherEntete()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenue dans le Labyrinthe !");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Atteignez la sortie 'E' pour gagner !");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
        }

        public void AfficherVictoire()
        {
            Console.Clear();
            Console.WriteLine("Félicitations ! Vous avez trouvé la sortie !");
            Console.WriteLine("Merci d'avoir joué !");
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
