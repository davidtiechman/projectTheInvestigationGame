using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class Agent
    {
        public int Id { get; set; }
        public string Rank { get; set; }
        public List<Sansor> ListSantorsw = new();
        public Agent()
        {

        }
    }
}
