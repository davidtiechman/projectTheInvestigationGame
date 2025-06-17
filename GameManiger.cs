using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class GameManiger
    {
        Random random = new Random();
        string[] sensors = new string[] { "basic", "audio", "video" };
        Agent agent = new Agent(1);
        Player player = new Player(1);
        public void AgentInitialization(int sum)
        {
            for (int i = 0; i < sum; i++)
            {
                Sensor sensor = new Sensor(sensors[random.Next(0, 3)]);

                this.agent.ListSentorsW.Add(sensor);
                
            }
            agent.DictsensorW = ConvertArrtoDict(agent.ListSentorsW);
            foreach (Sensor s in agent.ListSentorsW)
            {
                Console.WriteLine(s.Type);
            }
        }

        public void Guessing()
        {
            
            Console.WriteLine("Please select an option (1-3)");
            Console.WriteLine("Please enter an option 1");
            string option1 = Console.ReadLine();
            player.ListsensorP.Add(CheckOption(option1));
            Console.WriteLine("Please enter an option 2");
            string option2 = Console.ReadLine();
            player.ListsensorP.Add(CheckOption(option2));
            Console.WriteLine("Please enter an option 3");
            string option3 = Console.ReadLine();
            player.ListsensorP.Add(CheckOption(option3));
            player.DictsensorW = ConvertArrtoDict(player.ListsensorP);
            Console.WriteLine(player.ListsensorP[0].Type);
            Console.WriteLine(player.ListsensorP[1].Type);
            Console.WriteLine(player.ListsensorP[2].Type);
            PrintResult();
        }
        public Sensor CheckOption(string num)
        {
            string option = "";
;            switch (num)
            {
                case "1":
                    option = "basic";
                    break;
                case "2":
                    option = "audio";
                    break;
                case "3":
                    option = "video";
                  break;     
            }
            Sensor sensor = new Sensor(option);
            return sensor;
        }
        
        public Dictionary<string,int> ConvertArrtoDict(List<Sensor> listsensor) 
        {
            Dictionary<string, int> newdict = new Dictionary<string, int>();
            foreach (Sensor s in listsensor)
            {
                if (newdict.ContainsKey(s.Type))
                {
                    newdict[s.Type]++;
                }
                else
                {
                    newdict[s.Type] = 1;

                }
            }
            return newdict;
        }
        public void PrintResult()
        {
            int count = 0;
            foreach (Sensor s in player.ListsensorP)
            {
                if (s.Activate(agent.DictsensorW) == true)
                {
                    count++;
                }
            }
            string TypeSuccess = (count == agent.ListSentorsW.Count) ? "Very nice" : (count >= 1 ? "Beautiful" : "Oops");
            string SuccessStatus = (count == agent.ListSentorsW.Count) ? "Complete success" : (count >= 1 ? "Partial success" : "Failed to succeed");
            Console.WriteLine($"{TypeSuccess}, you guessded it. {count}/{agent.ListSentorsW.Count}");
            Console.WriteLine($"The success status is {SuccessStatus}");
        }
        
    }
    

}