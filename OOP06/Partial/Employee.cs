using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Partial
{

    internal partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Nullable reference type
        public int Age { get; set; }

        //public void Print()
        //{
        //    Console.WriteLine("Partial Class Employee");
        //}
        public partial void Print(int id); // Declaration of partial method in anther part of partial class
 
    }
}
