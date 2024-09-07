using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class clsEmployee
    {
       public clsEmployee() { Age = 27; }
        // Private fields
        private int _ID;
        private string _Name = string.Empty;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string JobTitle { get; set; }
        //read only
        public int Age { get; }
        private float _Salary = 2000;
        public float Salary { get { return _Salary; } }
    }
    internal class GetSetProperty
    {
        public static void PropertiesSetAndGet()
        {

            //Create an object of Employee class.

            clsEmployee Employee1 = new clsEmployee();

            Employee1.ID = 7;
            Employee1.Name = "Ahmed Mady";
            Employee1.JobTitle = "Developer";
            //Employee1.Age =27;
            //Employee1.Salary = 27;

            Console.WriteLine("Employee Id:={0}", Employee1.ID);
            Console.WriteLine("Employee Name:={0}", Employee1.Name);
            Console.WriteLine("Employee JobTitle:={0}", Employee1.JobTitle);
            Console.WriteLine("Employee Age:={0}", Employee1.Age);
            Console.WriteLine("Employee Salary:={0}", Employee1.Salary);
            Console.ReadLine();


        }
    }
}
