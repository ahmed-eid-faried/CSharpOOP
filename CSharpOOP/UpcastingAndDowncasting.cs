using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Person6
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
        }
    }

    public class Employee6 : Person6
    {
        public string Company { get; set; }
        public decimal Salary { get; set; }


        public void Work()
        {
            Console.WriteLine($"I work at {Company} and earn {Salary:C} per year.");
        }
    }

    internal class UpcastingAndDowncasting
    {
        public static void UpcastingAndDowncastingEx()
        {
            // Upcasting
            Employee6 employee = new Employee6 { Name = "John", Age = 30, Company = "Acme Inc.", Salary = 5000 };
            Person6 person = employee;
            person.Greet(); // Output: "Hi, my name is John and I am 30 years old."
 
            // Downcasting
            Person6 person2 = new Employee6 { Name = "Jane", Age = 25, Company = "XYZ Corp.", Salary = 60000 };
            Employee6 employee2 = (Employee6)person2;
            employee2.Work(); // Output: "I work at XYZ Corp. and earn $60,000.00 per year."

            // Invalid downcasting - throws InvalidCastException at runtime
            //  Person6 person3 = new Person6 { Name = "Bob", Age = 40 };
            // Employee6 employee3 = (Employee6)person3; // Runtime exception: InvalidCastException


        }
    }
}
