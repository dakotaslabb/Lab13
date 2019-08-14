using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Validation
    {
        public Validation()
        {
        }
        public bool Validator(string a)
        {
            if (a == "" || a == " ")
            {
                Console.WriteLine($"\nPlease enter a valid answer\n");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
