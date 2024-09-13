using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        //Abstract Class
        //In C#, we cannot create objects of an abstract class. We use the abstract keyword to
        //create an abstract class.

        //The abstract keyword is used for classes and methods:

        //Abstract class: is a restricted مقيدة class that cannot be used to create objects(to access it,
        //it must be inherited from another class).
        //Abstract method: can only be used in an abstract class, and it does not have a body.
        //The body is provided by the derived class (inherited from).
        public static void AbstractClassEx()
        {
            //You cannot create an object of an abstract class, you can only inherit it.
            //  Person Person1= new Person();

            Employee8 employee = new Employee8();
            employee.FirstName = "Ahmed";
            employee.LastName = "Mady";
            employee.EmployeeId = 12345;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"

        }
    }
}
