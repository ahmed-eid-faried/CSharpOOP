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

        public interface ICommunicate
        {
            void SendEmail(string Title, string Body);
            void SendFax(string Title, string Body);
            void SendSMS(string Title, string Body);
            void CallPhone();
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

        public abstract class Person10 : IPerson, ICommunicate
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

            public void SendEmail(string Title, string Body)
            {
                Console.WriteLine("Email Sent :-)");
            }
            public void SendFax(string Title, string Body)
            {
                Console.WriteLine("Fax Sent :-)");
            }
            public void SendSMS(string Title, string Body)
            {
                Console.WriteLine("SMS Sent :-)");
            }
            public void CallPhone()
            {
                Console.WriteLine("CallPhone :-)");
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
        public class Employee10 : Person10
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
            employee.Introduce(); // Output: "Hi, my name is Ahmed Mady, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"
            employee.Print();
            employee.SendEmail();
        }

        public static void MultipleInterfaceEx()
        {
            //You cannot create an object of an Interface, you can only Implement it.
            // IPerson Person1 = new IPerson();

            Employee10 employee = new Employee10();
            employee.FirstName = "Ahmed";
            employee.LastName = "Mady";
            employee.EmployeeId = 12345;
            employee.Introduce(); // Output: "Hi, my name is Ahmed Mady, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"
            employee.Print();
            employee.CallPhone();
            employee.SendEmail("hi", "Body");
            employee.SendSMS("hi", "Body");
            employee.SendFax("hi", "Body");

        }
    }
}