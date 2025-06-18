using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class GameManager
    {
        Random random = new Random();
        string[] sensors = new string[] { "basic", "audio", "video" };
        public void Step1()
        {
            Agent agent = new Agent(1,"");
            Player player = new Player(1);
            AgentInitialization(agent,2);
            bool succes = false;
            while (!succes)
              succes =  Guessing(agent, player, 2);
        }
        //public void Step2(Agent agent, int sum,Player player)
        //{
            //AgentIn itialization(agent, sum);
            //Guessing(agent,player, sum);
        //}
        public void AgentInitialization(Agent agent,int sum)
        {
            for (int i = 0; i < sum; i++)
            {
                Sensor sensor = new Sensor(sensors[random.Next(0, 3)]);

                agent.ListSentorsW.Add(sensor);
                
            }
            agent.DictsensorW = ConvertArrtoDict(agent.ListSentorsW);
            foreach (Sensor s in agent.ListSentorsW)
            {
                Console.WriteLine(s.Type);
            }
        }

        public bool Guessing(Agent agent,Player player, int sum)
        {
            bool success = false;
            player.ListsensorP.Clear();
            Console.WriteLine($"Please select an option (1-{sum})");
            int option = 0;
            for (int i = 0; i < sum; i++)
            {
                option++;
                Console.WriteLine($"Please enter an option {option}");
                string inputoption = Console.ReadLine();
                player.ListsensorP.Add(CheckOption(inputoption));
            }
            success = PrintResult(agent, player);
            return success;
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
        public bool PrintResult(Agent agent,Player player)
        {
            bool success = false;
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
            string Exposed = (count == agent.ListSentorsW.Count) ? "The agent was exposed." : "The agent has not yet been revealed.";
            Console.WriteLine($"{TypeSuccess}, you guessded it. {count}/{agent.ListSentorsW.Count}");
            Console.WriteLine($"The success status is {SuccessStatus}");
            if (count == agent.ListSentorsW.Count)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Exposed);
                Console.ResetColor();  // מחזיר את הצבע הרגיל של הקונסול
                success = true;
                //Step2(agent, 3, player);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Exposed);
                Console.ResetColor();  // מחזיר את הצבע הרגיל של הקונסול
                agent.DictsensorW = ConvertArrtoDict(agent.ListSentorsW);
            }
            return success;
        }

    }
    

}