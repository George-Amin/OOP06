using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction.Static
{
    internal class Utilty
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Utilty(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double MterToCM(double _value)
        {
            return _value * 100;
        }

      
         

       
    }
}
