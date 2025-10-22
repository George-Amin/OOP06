using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(decimal Radius)
        {
            Dim01 = Dim02 = Radius;
        }
        public override decimal Perimeter
        {
            get { return 2 * Dim01 * 3.14m; }
            //get { return 2 * (decimal)Math.PI * Dim01; }
        }

        public override decimal CalcArea()
        {
            return 3.14m * Dim01 * Dim02; 
            //return Math.PI * Math.Pow(Dim01, 2);
        }
    }
}
