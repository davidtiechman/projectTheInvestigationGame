using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class PulseSensor : Sensor
    {
        public bool Broken;
        public PulseSensor(string type) :base(type)
        {
            this.Type = type;
            Broken = true;
        }
        public override bool Activate(Dictionary<string, int> dictsensor)
        {
            return base.Activate(dictsensor);
        return true;
        }
}
}
