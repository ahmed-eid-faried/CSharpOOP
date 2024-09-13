using System;

namespace CSharpOOP
{
    internal class clsInterface
    {
        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }

            void Introduce();
            void Print();

            string To_String();
        }


        public abstract class Person9 : IPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public abstract void Introduce();

            public void Print()
            {
                Console.WriteLine("Hi I'm the print method");
            }

            public string To_String()
            {
                return "Hi this is the complete string....";
            }

            public void SayGoodbye()
            {
                Console.WriteLine("Goodbye!");
            }
            public void SendEmail()
            {
                Console.WriteLine("Email Sent :-)");
            }

        }


        public class Employee9 : Person9
        {
            public int EmployeeId { get; set; }
            public override void Introduce() 
            {
                Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
            }
    }
    public static void InterfaceEx()
    {
        //You cannot create an object of an Interface, you can only Implement it.
        // IPerson9 Person1 = new IPerson();

        Employee9 employee = new Employee9();
        employee.FirstName = "Mohammed";
        employee.LastName = "Abu-Hadhoud";
        employee.EmployeeId = 123;
        employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
        employee.SayGoodbye(); // Output: "Goodbye!"
        employee.Print();
        employee.SendEmail();
    }

    public static void MultipleInterfaceEx()
    {
    }
}
}