using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction
{
    internal class Square : RecBase
    {
        public Square(decimal side) {
            Dim01 = Dim02 = side;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }


    }
}
