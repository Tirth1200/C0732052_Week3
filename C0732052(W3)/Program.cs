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
            Alst.VillageName = "Alst";
            Maeland = new Village();
            Maeland.VillageName = "Maeland";
            Schenig = new Village();
            Schenig.VillageName = "Schenig";
            Maeland.isAstrildeHere = true;
            Alst.NextVillage = Maeland;
            Schenig = new Village();
            
        }
        public void WalkAround()
        {
          Village CurrentVillage = this.Maeland;
            Village NextVillage;
            NextVillage = CurrentVillage = Alst;
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
