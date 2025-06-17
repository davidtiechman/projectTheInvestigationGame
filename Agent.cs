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
        public List<Sensor> ListSentorsW;
        public Dictionary<string, int> DictsensorW;
        public Agent(int id,string rank)
        {
            this.Id = id;
            this.Rank = rank;
            this.ListSentorsW = new List<Sensor>();
            this.DictsensorW = new Dictionary<string, int>();
            
        }
    }
}
