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
                        break;
                    case "2":
                        break;
                        
                           

                }
            }
        }
        public void step1()
        {

        }
    }
}
