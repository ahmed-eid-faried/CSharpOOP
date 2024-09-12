using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{

    public class Person7
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
        }
    }
    public class Employee7 : Person7
    {
        public int Employee7Id { get; set; }
        public decimal Salary { get; set; }


        public void Work()
        {
            Console.WriteLine($"Employee with ID {Employee7Id} and salary {Salary:C} is working.");
        }
    }
    public class User : Person7
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }


        public void Info()
        {
            Console.WriteLine($"User: {Username} and Password {Password} .");
        }
    }
    internal class clsHierarchalInheritance
    {
        public static void HierarchalInheritanceEx()
        {
            Employee7 Employee71 = new Employee7();
            Employee71.Name = "John";
            Employee71.Age = 35;
            Employee71.Employee7Id = 123;
            Employee71.Salary = 100000.00M;
            Console.WriteLine("\nEmployee:");
            Employee71.Introduce(); // Output: "Hi, my name is John and I'm 35 years old."
            Employee71.Work(); // Output: "Employee with ID 123 and salary $100,000.00 is working."

            User User1 = new User();
            User1.Name = "Ali";
            User1.Age = 45;
            User1.Username = "User1";
            User1.Password = "1234";


            Console.WriteLine("\nUser:");
            User1.Introduce(); // Output: "Hi, my name is John and I'm 35 years old."
            User1.Info(); //Output: "User: User1 and Password 1234 ." }
        }
    }
}