using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class Sensor
    {
        public string Type;
        public string Name;
        public string m;



        public Sensor(string type)
        {
            this.Type = type;
        }

        public virtual bool  Activate(Dictionary<string,int> dictsensor)
        {
            bool exist = false;
            foreach (string key in dictsensor.Keys)
            {
                if (key == this.Type && dictsensor[key] >0)
                {
                    dictsensor[key] -= 1;
                    exist = true;
                }
            }
                return exist;


        }

    }     
    
}
