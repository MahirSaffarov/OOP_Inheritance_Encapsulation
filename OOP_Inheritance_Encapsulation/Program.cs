using Domain;
using OOP_Inheritance_Encapsulation.Data;
using OOP_Inheritance_Encapsulation.Data.NewFolder;
using OOP_Inheritance_Encapsulation.Models;
using System;
using System.Reflection;

namespace OOP_Inheritance_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            //emp1.age = 12;
            //Console.WriteLine(emp1.age);

            //Person person = new Person();
            //person.age = 15;
            //Console.WriteLine(person.age);

            //Dog dog1 = new Dog("Reks");
            //Console.WriteLine(dog1.name);

            //Dog dog2 = new Dog("Jek");
            //Console.WriteLine(dog2.name);

            //Employee emp2 = new Employee("23214135");

            //Test test = new Test("Pitbull");

            //Person person2 = new Person("13123");
            //person2.ShowSurname();

            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person2, "Cracked");
            //var ShowSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance);

            //Console.WriteLine(ShowSurname);

            //person.MyProperty = 77;
            //Console.WriteLine(person.MyProperty);

            //person.MyProperty = 22;
            //Console.WriteLine(person.MyProperty);

            //Car car = new Car();

            //Test1 test1 = new Test1();

            //OOP_Inheritance_Encapsulation.Models.Car car1 = new OOP_Inheritance_Encapsulation.Models.Car();

            //MyCar car2 = new MyCar();


            Group group = new Group();
            group.Name = "P414";
            Console.WriteLine(group.Name);
        }
    }
}
