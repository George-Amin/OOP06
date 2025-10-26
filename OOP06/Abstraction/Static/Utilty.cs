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
        //private static double Pi = 3.14;
        private static readonly double pi = 3.14;

        public  double Pi
        {
            get { return pi; }
            //set { pi = value; } // readonly cannot be assigned to (except in a constructor or a variable initializer)
        }


        public static double CalcArea(double _redius)
        {
            return pi * _redius * _redius;
            //return Math.PI * Math.Pow(_redius, 2);  
        }

        public static double MterToCM(double _value)
        {
            return _value * 100;
        }

      
         

       
    }
}
