using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class Player
    {
        public int Id;
        public List<Sensor> ListsensorP = new List<Sensor>();
        Dictionary<string, int> DictsensorW;
        public Player(int id)
        {
            this.Id = id;

        }
    }
}
