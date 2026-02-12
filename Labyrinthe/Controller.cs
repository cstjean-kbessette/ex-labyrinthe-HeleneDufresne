using System.Collections.Generic;

namespace Labyrinthe
{
    internal class Controller
    {
        private Labyrinthe labirynthe;
        private View view;
        public Controler(Labyrinthe labirynthe, View view)
        {
            this.view = view;
            this.labirynthe = labirynthe;
        }


        public void Run()
        {
            
            while (true)
            {
                view.AfficherEntete();
                ConsoleKeyInfo cki = Console.ReadKey(true);
                char choix = cki.KeyChar;
                switch (choix)
                {
                    case '1':

                      break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                }
            }
        }
    }
}
