using System;

namespace CSharpOOP
{
    internal class clsSealedClass
    {
        sealed class clsA { }

        // trying to inherit sealed class
        // Error Code
        //class clsB : clsA { }
        class clsB { }

        /// <summary>
        /// //////////////////////////////////////////////////
        /// </summary>
        public class Person
        {
            public virtual void Greet()
            {
                Console.WriteLine("The person says hello.");
            }
        }
        public class Employee : Person
        {
            public sealed override void Greet()
            {
                Console.WriteLine("The employee greets you.");
            }
        }
        public class Manager : Employee
        {
            //This will produce a compile-time error because the Greet method in Employee is
            //sealed and cannot be overridden.
            //public override void Greet()
            //{
            //    Console.WriteLine("The manager greets you warmly.");
            //}
        }

        internal static void SealedClassEx()
        {
            // create an object of B class
            clsB B1 = new clsB();
            Console.WriteLine("error CS0509: 'B': cannot derive from sealed type 'Al'\r\n");

        }
        internal static void SealedMethodsEx()
        {
            Person person = new Person();
            person.Greet(); // outputs "The person says hello."

            Employee employee = new Employee();
            employee.Greet(); // outputs "The employee greets you."

            Manager manager = new Manager();
            manager.Greet(); // outputs "The employee greets you."

            Console.WriteLine("This will produce a compile-time error because the Greet method in Employee is\r\nsealed and cannot be overridden.");

        }
    }
}