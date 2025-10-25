using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction
{
    internal class Triangle : Shape

    {
        public decimal Dim03 { get; set; }

        public Triangle(decimal _dim01 , decimal _dim02 , decimal _dim03) : base(_dim01 , _dim02)
        {
            //Dim01 = _dim01; // => Will initialze in base class constructor
            //Dim02 = _dim02; // => Will initialze in base class constructor
            Dim03 = _dim03;
        }
        public override decimal Perimeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
