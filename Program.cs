namespace projectTheInvestigationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sansor s1 = new Sansor("o");
            Sansor s2 = new Sansor("o");
            Sansor s3 = new Sansor("v");
            Sansor s4 = new Sansor("b");
            Sansor s5 = new Sansor("b");
            Agent agent = new();
            agent.ListSantorsw.Add(s1);
            agent.ListSantorsw.Add(s1);
            agent.ListSantorsw.Add(s5);


            Gammer gammer = new Gammer();
            gammer.ListsansorP.Add(s1);
            gammer.ListsansorP.Add(s1);
            gammer.ListsansorP.Add(s5);
            int count = 0;
            foreach (Sansor s in gammer.ListsansorP)
            {
                if (s.Activate(agent.ListSantorsw) == true) { count++; }
            }
            Console.WriteLine(count);



        }
    }
}
