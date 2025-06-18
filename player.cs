using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class Player
    {
        public int Id { get; set; }
        public List<Sensor> ListsensorP{ get; set; }
        public Dictionary<string, int> DictsensorW { get; set; }
        public int NumAttempts;
        public Player(int id)
        {
            this.Id = id;
            this.ListsensorP = new List<Sensor>();
            this.DictsensorW = new Dictionary<string, int>();
            this.NumAttempts = 0;

        }
    }
}
