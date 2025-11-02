using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace OOP06.Partial
{
    internal partial class Employee
    {

        public partial void Print(int id)
        { // Implementation of partial method
            Console.WriteLine($"partial method not Implementated in main class {id}");
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Age: {Age}");
            Print(Id);
            // from other part of partial class (Employee)
        }
    }
}
