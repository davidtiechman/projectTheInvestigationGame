using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTheInvestigationGame
{
    internal class Sansor
    {
        public string Name;
        public string m;



        public Sansor(string name)
        {
            this.Name = name;
        }

        public bool Activate(List<Sansor> listsansor)
        {
            bool existe = false;
            if (listsansor.Contains(this))
            {
                existe = true;
                foreach (Sansor s in listsansor)
                {
                    if (s.Name == this.Name) { listsansor.Remove(s); }
                    break;
                }
            }
            else
            {
                existe = false;
            }
                    return existe;
                }
            
        }

             
    
}
