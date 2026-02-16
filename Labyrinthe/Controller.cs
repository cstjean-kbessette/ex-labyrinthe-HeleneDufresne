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
            while (true)
            {
                Console.Clear();
                view.AfficherLabyrinthe(labyrinthe);
                
                if (labyrinthe.IsExit())
                {
                    view.AfficherVictoire();
                    break;
                }

                ConsoleKeyInfo cki = Console.ReadKey(true);
                char choix = cki.KeyChar;
                switch (choix)
                {
                    case 'w':
                        labyrinthe.MoveUp();
                      break;
                    case 's':
                        labyrinthe.MoveDown();
                        break;
                    case 'a':
                        labyrinthe.MoveLeft();
                        break;
                    case 'd':
                        labyrinthe.MoveRight();
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            }
        }
    }
}
