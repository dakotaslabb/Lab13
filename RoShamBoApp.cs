using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RoShamBoApp
    {
        Random rando;
        public RoShamBoApp()
        {

        }
        public string PlayerSelection(string answer)
        {
            if (answer == "r")
            {
                string npc1 = "Rocky";
                Rocky r = new Rocky(npc1);
                return r.generateRoShamBo();
            }
            else if (answer == "d")
            {
                string npc1 = "Dwayne Johnson";
                DwayneJohnson d = new DwayneJohnson(npc1);
                return d.generateRoShamBo();
            }
            else
            {
                return "Error";
            }
        }
    }
}
