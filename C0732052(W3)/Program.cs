using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732052_W3_
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Countryside
    { Village Alst;
      Village Maeland;
      Village Schenig;
        public void InitializeMap()
        {
             Alst = new Village();
            Maeland = new Village();
            Schenig = new Village();
            Maeland.isAstrildeHere = true;
            Alst.NextVillage = Maeland;
            Schenig = new Village();
            
        }
        public void WalkAround()
        {
          Village InitialVillage = this.Maeland;
        }
    }
    class Village
    {
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }
    }
}
