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

        public Utilty(int x, int y) // obj member constructor non static
        {
            X = x;
            Y = y;
            // pi = 3.14; // [ static ] readonly can not be assigned in constructor
            // pi = 3.14; // can be assigned in constructor if it is not static
        }
        //private static double Pi = 3.14;
            // pi = 3.14159; // static readonly can be assigned in static constructor only
        private static readonly double pi ; // read only attribute can not have a set method  

        public  double Pi // without set will be readonly property
        {
            get { return pi; }
            //set { pi = value; } // readonly cannot be assigned to (except in a constructor or a variable initializer)
        }
        public static int i = 1; // static variable can be assigned in static method if it is not readonly 


        public static double CalcArea(double _redius)
        {
            //  pi = 3.14159; // static readonly can be assigned in static method
          //  pi = 1.14; // static variable can be assigned in static method if it is not readonly
            return pi * _redius * _redius;
            //return Math.PI * Math.Pow(_redius, 2);  
        }

        public static double MterToCM(double _value)
        {
            return _value * 100;
        }

      
         

       
    }
}
