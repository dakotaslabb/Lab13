using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class DwayneJohnson : Player
    {
        private Random Rando;

        public DwayneJohnson(string Name) : base(Name)
        {

        }


        public override string generateRoShamBo()
        {
            Random r = new Random();
            int pick = r.Next(1, 4);

            if (pick == 1)
            {
                return RPSEnum.rock.ToString();
            }
            else if (pick == 2)
            {
                return RPSEnum.paper.ToString();
            }
            else if (pick == 3)
            {
                return RPSEnum.scissors.ToString();
            }
            else
            {
                return generateRoShamBo();
            }
        }
    }
}
