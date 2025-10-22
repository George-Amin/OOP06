using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction
{
    // Concreate Class => Fully Implemented Class
    internal class Rectangle : RecBase
    {
        public override decimal Perimeter
        {
            get { return Dim01 * Dim02 * 2; }
        }

    }
}
