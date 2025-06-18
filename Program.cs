namespace projectTheInvestigationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            //menu.Option("1");
            GameManager game = new GameManager();
            game.Step2();
        }
    }
}
