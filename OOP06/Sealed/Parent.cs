using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void PrintNameOfClass()
        {
            Console.WriteLine("I am Parent");
        }
    }
    internal class Child : Parent
    {

        public /*sealed*/ override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value + 500; }
        }

        public sealed override void PrintNameOfClass() // sealed keyword prevents further overriding can not be overridden in derived classes agian
        {
            Console.WriteLine("I am Child");
        }
    }
    sealed class GrandChild : Child // sealed class can not be inherited but can inherit from other class
    {
        public sealed override int Salary // can override because Salary is not sealed in Child class
        {
            get { return base.Salary; }
            set { base.Salary = value + 200; }
        }

        //public override void PrintNameOfClass() // Invalid override because PrintNameOfClass is sealed in Child class
        //{
        //    Console.WriteLine("I am GrandChild");
        //}


        // can use [ new ] keyword to hide the sealed method from Child class but it will not be override it is ownd GrandChild's method 
        public new void PrintNameOfClass()  // hiding the sealed method from Child class (delete override keyword and use [ new ] keyword)
        {
            Console.WriteLine("I am GrandChild");
        }

    }


    internal class GreatGrandChild /*: GrandChild*/ // Invalid inheritance because GrandChild is sealed class
    {
    }
}
