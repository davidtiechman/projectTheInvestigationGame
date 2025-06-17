namespace projectTheInvestigationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManiger gameManiger = new GameManiger();
            gameManiger.AgentInitialization(3);
            gameManiger.Guessing();


        }
    }
}
