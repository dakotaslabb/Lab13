using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Player
    {
        public Random rando;

        public Player(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }

        public virtual string generateRoShamBo()
        {
            int pick = rando.Next(1, 4);

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
