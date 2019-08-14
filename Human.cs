using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Human : Player
    {
        public Human(string Name) : base(Name)
        {
        }

        public override string generateRoShamBo()
        {
            Console.WriteLine("\nPlease select you move!\n");
            Console.WriteLine($"1) rock \n2) paper\n3) scissors\n");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "1")
            {
                return RPSEnum.rock.ToString();
            }
            else if (input == "2")
            {
                return RPSEnum.paper.ToString();
            }
            else if (input == "3")
            {
                return RPSEnum.scissors.ToString();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a 1, 2, or 3");
                return generateRoShamBo();
            }
        }
    }
}
