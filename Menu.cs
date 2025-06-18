using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class Menu
    {
        GameManager game = new GameManager();
        public void Option(string option)
        {
            bool exit = false;
            while(!exit)
            {
                switch (option)
                {
                    case "1":
                        game.Step1();
                        exit = true;
                        Console.WriteLine("You have successfully completed step 1. To move to the next step, press 2. To exit, press #.");
                        Option(Console.ReadLine());
                        break;
                    case "2":
                        game.Step2();
                        exit = true;
                        break;
                    case "#":
                        exit = true;
                        break;
                           

                }
            }
        }
        public void step1()
        {

        }
    }
}
