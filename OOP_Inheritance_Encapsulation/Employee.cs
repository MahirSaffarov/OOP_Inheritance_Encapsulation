using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance_Encapsulation
{
    class Employee : Person
    {
        public Employee(string PhoneNumber) : base(PhoneNumber)
        {
            Console.WriteLine(PhoneNumber);

            address = "Ehmedli";
        }


    }
}
