using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance_Encapsulation
{
    class Person : Group
    {
        public string name;
        string surname;
        protected string address;
        private int age;
        public int MyProperty {
            get
            {
                if (age < 18)
                {
                    Console.WriteLine("Can't see");
                    return -1; 
                }return 1;
            }
            set
            {
                age = value;
            }
        }

        //public Person(string phone)
        //{
        //    surname = "safarov";
        //}

        public void ShowSurname()
        {
            Console.WriteLine(surname);
        }
    }
}
