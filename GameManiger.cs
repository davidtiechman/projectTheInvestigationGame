using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{gi
    internal class GameManiger
    {
        Random random = new Random();
        string[] sensors = new string[] { "basic", "audio", "video" };
        Agent agent = new Agent(1);
        Player player = new Player(1);
        public void Step1()
        {
            for (int i = 0; i < 3; i++)
            {
                Sensor sensor = new Sensor(sensors[random.Next(0, 3)]);

                this.agent.ListSentorsW.Add(sensor);
                
            }
            agent.DictsensorW = ConvertArrtoDict(agent.ListSentorsW);
            Console.WriteLine(this.agent.ListSentorsW[0].Type);
            Console.WriteLine(this.agent.ListSentorsW[1].Type);
            Console.WriteLine(this.agent.ListSentorsW[2].Type);
            Guessing();
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
            //player.ListsansorP.Add();
            Console.WriteLine(player.ListsensorP[0].Type);
            Console.WriteLine(player.ListsensorP[1].Type);
            Console.WriteLine(player.ListsensorP[2].Type);
            //CompatibilityChecker(player, agent);

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
        //public void CompatibilityChecker(Player player, Agent agent)
        //{
        //    //int count = 0;
            //List<Sensor> newlist = agent.ListSentorsW.ToList();

            //for (int i = 0; i < 3; i++)
            //{
                //if (player.ListsensorP[i].Activate(newlist) == true) { count++; }
            //}  
            
            //Console.WriteLine(count);
        //}
        public Dictionary<string,int> ConvertArrtoDict(List<Sensor> listsensor) 
        {
            Dictionary<string, int> newdict = new Dictionary<string, int>();
            foreach ( Sensor s in listsensor) 
            {
                if (newdict.ContainsKey(s.Type))
                    newdict[s.Type]++;
                newdict[s.Type] = 1;
            }
            return newdict;
        }

        
        
    }
    

}