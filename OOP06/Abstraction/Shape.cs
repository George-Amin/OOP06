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


        protected Shape(decimal _dim01, decimal _dim02)
        {
            Dim01 = _dim01;
            Dim02 = _dim02;
        }

        public abstract decimal CalcArea();
        //public int MyProperty { get; set; }
        public abstract decimal Perimeter { get; }
    }
    abstract class RecBase : Shape
    {
        protected RecBase(decimal _dim01 , decimal _dim02) : base( _dim01,_dim02) 
        {
            
        }
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
