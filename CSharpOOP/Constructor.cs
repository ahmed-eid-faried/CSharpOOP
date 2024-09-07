using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class clsPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson()
        {
            Id = -1;
            Name = "Empty";
            Age = 0;
        }
        public clsPerson(int Id, string Name, short Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        static clsPerson()
        {
            Console.WriteLine("static Constructor called ==> 1 item only.");

        }
        // destructor
        ~clsPerson()
        {
            Console.WriteLine("Destructor called.");
        }


        public static clsPerson Find(int Id)
        {
            if (Id == 10)
            {
                return new clsPerson(10, "ahmed mady", 27);

            }
            else
            {
                return null;
            }
        }

    }
    class Car
    {

        public string brand;
        public int price;

        // parameterized constructor
        public Car(string theBrand, int thePrice)
        {

            brand = theBrand;
            price = thePrice;
        }
    }

    class clsPerson2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    static class Settings2
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

    }
    class Settings3
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

        //this is a private constructor to prevent creating object from this class
        private Settings3()
        {

        }
    }
    static class Settings4
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }


        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }


        public static string ProjectPath
        {
            get;
            set;
        }
        //this is a static constructor will be called once during the program
        static Settings4()
        {
            ProjectPath = @"C:\MyProjects\";
        }
    }
    internal class Constructor
    {
        public static void ConstructorEx()
        {
            clsPerson Person1 = new clsPerson();

            Console.WriteLine("ID:= {0}", Person1.Id);
            Console.WriteLine("Name:= {0}", Person1.Name);
            Console.WriteLine("Age:= {0}", Person1.Age);
            Console.ReadKey();
        }
        public static void ParameterizedConstructorEx()
        {
            // call parameterized constructor
            Car car1 = new Car("Bugatti", 50000);

            Console.WriteLine("Brand: " + car1.brand);
            Console.WriteLine("Price: " + car1.price);
            Console.ReadLine();
        }
        public static void DefaultConstructorEx()

        {
            clsPerson2 Person1 = new clsPerson2();
            Console.WriteLine("ID:= {0}", Person1.Id);
            Console.WriteLine("Name:= {0}", Person1.Name);
            Console.WriteLine("Age:= {0}", Person1.Age);
        }

        public static void PreventCreateObject()
        {
            //first method

            // You cannot create an object here because class is static
            //Settings2 Obj1 = new Settings2();

            //
            // Read the static properties.
            //
            Console.WriteLine(Settings2.DayNumber);
            Console.WriteLine(Settings2.DayName);

            //
            // Change the value of the static bool property.
            //
            Settings2.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(Settings2.ProjectPath);
            Console.ReadKey();
            ////////////////////////////////////////////////////////////////
            //second method

            // You cannot create an object here because class has private constructor
            //Settings3 Obj1 = new Settings3();

            //
            // Read the static properties.
            //
            Console.WriteLine(Settings3.DayNumber);
            Console.WriteLine(Settings3.DayName);

            //
            // Change the value of the static bool property.
            //
            Settings3.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(Settings3.ProjectPath);
            Console.ReadKey();

        }

        public static void MultipleConstructorsUsingOverloading()
        {
            Console.WriteLine("Calling Parameterless Construcor");
            clsPerson Person1 = new clsPerson();
            Console.WriteLine("ID:= {0}", Person1.Id);
            Console.WriteLine("Name:= {0}", Person1.Name);
            Console.WriteLine("Age:= {0}", Person1.Age);


            Console.WriteLine("\n\nCalling Parametarized Construcor");
            clsPerson Person2 = new clsPerson(10, "Mohammed Abu-Hadhoud", 45);
            Console.WriteLine("ID:= {0}", Person2.Id);
            Console.WriteLine("Name:= {0}", Person2.Name);
            Console.WriteLine("Age:= {0}", Person2.Age);
        }

        public static void StaticConstructer()
        {
            // You cannot create an object here because class is static
            // Settings4 Obj1 = new Settings4();

            //
            // Read the static properties.
            //
            Console.WriteLine(Settings4.DayNumber);
            Console.WriteLine(Settings4.DayName);
            //
            // Change the value of the static bool property.
            //

            Console.WriteLine(Settings4.ProjectPath);
        }

        public static void FindObject()
        {
            clsPerson person1 = clsPerson.Find(10);
            if (person1 == null)
            {
                Console.WriteLine("Not Found it.");
            }
            else
            {
                Console.WriteLine("Id = {0}", person1.Id);
                Console.WriteLine("Name = {0}", person1.Name);
                Console.WriteLine("Age = {0}", person1.Age);

            }
        }



    }

}
