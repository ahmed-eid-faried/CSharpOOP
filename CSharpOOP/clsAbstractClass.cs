using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public abstract class Person8
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void Introduce();
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }

    public class Employee8 : Person8
    {
        public int EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
        }

    }
    internal class clsAbstractClass
    {
        public static void AbstractClassEx()
        {
            //You cannot create an object of an abstract class, you can only inherit it.
            //  Person Person1= new Person();

            Employee8 employee = new Employee8();
            employee.FirstName = "Mohammed";
            employee.LastName = "Abu-Hadhoud";
            employee.EmployeeId = 123;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"

        }
    }
}
