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
    }
    class Car
    {

        string brand;
        int price;

        // parameterized constructor
        Car(string theBrand, int thePrice)
        {

            brand = theBrand;
            price = thePrice;
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

        }
    }
}
