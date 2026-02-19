using System.Collections.Generic;

namespace Labyrinthe
{
    internal class Controller
    {
        private Labyrinthe labyrinthe;
        private View view;
        public Controller(Labyrinthe labyrinthe, View view)
        {
            this.view = view;
            this.labyrinthe = labyrinthe;
        }
        public void Run()
        {
            view.AfficherEntete();
            Console.ReadKey();
            while (true) // (!labyrinthe.IsExit())  => Une seconde possibilité de sortie de ma boucle
            {
                Console.Clear();
                view.AfficherLabyrinthe(labyrinthe);
                
                if (labyrinthe.IsExit())
                {
                    view.AfficherVictoire();
                    break;
                }

                ConsoleKeyInfo cki = Console.ReadKey(true); // ConsoleKey key = Console.Key().Key;
                char choix = cki.KeyChar;
                switch (choix) // switch(key)
                {
                    case 'w': //ConsoleKey.UpArrow;
                        labyrinthe.MoveUp();
                      break;
                    case 's': //ConsoleKey.DownArrow;
                        labyrinthe.MoveDown();
                        break;
                    case 'a': //ConsoleKey.LeftArrow;
                        labyrinthe.MoveLeft();
                        break;
                    case 'd': //ConsoleKey.RightArrow;
                        labyrinthe.MoveRight();
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            }
            // view.AfficherVictoire(); (une seconde possibilité)
        }
    }
}
