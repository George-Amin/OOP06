using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Abstraction
{
    internal class Square : RecBase , ITwoDrawDim , IThreeDrawDim
    {
        public Square(decimal _side) : base(_side ,_side)
        {
            Dim01 = Dim02 = _side;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

        void ITwoDrawDim.Draw()
        {
            throw new NotImplementedException();
        }

        void IThreeDrawDim.Draw()
        {
            throw new NotImplementedException();
        }
    }
}
