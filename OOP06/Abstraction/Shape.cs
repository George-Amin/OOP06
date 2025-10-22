using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public abstract decimal CalcArea();
        //public int MyProperty { get; set; }
        public abstract decimal Perimeter { get; }
    }
    abstract class RecBase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
