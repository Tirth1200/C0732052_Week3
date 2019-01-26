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
            Village Alst = new Village();
            Village Maeland = new Village();
            Village Schenig = new Village();
            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
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
