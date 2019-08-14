 using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Rocky : Player
    {
        public Rocky(string Name) : base(Name)
        {
        }

        public override string generateRoShamBo()
        {
            return RPSEnum.rock.ToString();
        }
    }
}
