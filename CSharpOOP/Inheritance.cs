using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class clsPerson5
    {
        //properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        //read only property
        public string FullName
        {
            //Get is use for Reading field
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
        public clsPerson5() { }
        public clsPerson5(int ID, string FirstName, string LastName, string Title)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
        }
    }

    public class clsEmployee5 : clsPerson5
    {
        public clsEmployee5() { }
        public clsEmployee5(int ID, string FirstName, string LastName, string Title, string DepartmentName,
            float Salary) : base(ID, FirstName, LastName, Title)
        {
            this.Salary = Salary;
            this.DepartmentName = DepartmentName;
        }

        public float Salary { get; set; }
        public string DepartmentName { get; set; }


        public void IncreaseSalaryBy(float Amount)
        {
            Salary += Amount;
        }



    }

    internal class Inheritance
    {
        public static void InheritanceEx()
        {
            //C# Inheritance
            //In C#, inheritance allows us to create a new class from an existing class. It is a key feature of
            //Object-Oriented Programming (OOP).

            //In C#, it is possible to inherit fields and methods from one class to another. We group the
            //"inheritance concept" into two categories:

            //Derived Class(child) - the class that inherits from another class
            //Base Class(parent) - the class being inherited from
            //To inherit from a class, use the : symbol.

            //The class from which a new class is created is known as the base class (parent or superclass or base class ).
            //And, the new class is called derived class (child or subclass or derived class)

            //The derived class inherits the fields and methods of the base class. This helps with the code reusability in C#.


            //is -a relationship
            //In C#, inheritance is an is-a relationship. We use inheritance only if there is an is-a relationship
            //between two classes. For example,

            //Employee is a Person
            //We can derive Employee from Person class.

            //What can you inherit?
            //you can only inherit the public and protected members, private members are not inherited.


            //Create an object of Empoyee
            clsEmployee5 Employee1 = new clsEmployee5();

            //the following inherited from base class person
            Employee1.ID = 10;
            Employee1.Title = "Mr.";
            Employee1.FirstName = "Ahmed";
            Employee1.LastName = "Mady";

            //the following are from derived class Employee
            Employee1.DepartmentName = "IT";
            Employee1.Salary = 5000;

            Console.WriteLine("Accessing Object 1 (Employee1):\n");
            Console.WriteLine("ID := {0}", Employee1.ID);
            Console.WriteLine("Title := {0}", Employee1.Title);
            Console.WriteLine("Full Name := {0}", Employee1.FullName);
            Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
            Console.WriteLine("Salary := {0}", Employee1.Salary);

            Employee1.IncreaseSalaryBy(100);
            Console.WriteLine("Salary after increase := {0}", Employee1.Salary);
            Console.ReadKey();
        }

        public static void InheritanceConstructorEx()
        {
            //Create an object of Empoyee
            clsEmployee5 Employee1 = new clsEmployee5(10, "Mr.", "Ahmed", "Mady", "IT", 5000);


            Console.WriteLine("Accessing Object 1 (Employee1):\n");
            Console.WriteLine("ID := {0}", Employee1.ID);
            Console.WriteLine("Title := {0}", Employee1.Title);
            Console.WriteLine("Full Name := {0}", Employee1.FullName);
            Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
            Console.WriteLine("Salary := {0}", Employee1.Salary);

            Employee1.IncreaseSalaryBy(100);
            Console.WriteLine("Salary after increase := {0}", Employee1.Salary);
            Console.ReadKey();
        }


    }
}
