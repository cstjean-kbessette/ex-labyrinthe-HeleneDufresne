namespace Labyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe labyrinthe = new Labyrinthe(1,1);
            View view = new View();
            Controller controller = new Controller(labyrinthe, view);
            controller.Run();
        }
    }
}
