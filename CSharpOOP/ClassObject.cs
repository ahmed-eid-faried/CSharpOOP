using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class ClassObject
    {
        class clsPerson
        {
            public string FirstName;
            public string LastName;
            public string FullName()
            {
                return FirstName + " " + LastName;
            }
        }

        public static void PersonEx()
        {
            Console.WriteLine("========================================");
            clsPerson person1 = new clsPerson();
            person1.FirstName = "Ahmed";
            person1.LastName = "Mady";
            Console.WriteLine("Person1: ");
            Console.WriteLine(person1.FullName());
            Console.WriteLine("========================================");
            clsPerson person2 = new clsPerson();
            person2.FirstName = "Ahmed";
            person2.LastName = "Mady";
            Console.WriteLine("Person1: ");
            Console.WriteLine(person2.FullName());
            Console.WriteLine("========================================");
            Console.ReadKey();
        }











    }
}
