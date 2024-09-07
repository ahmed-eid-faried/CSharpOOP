using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class clsEmployee
    {
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

            Console.WriteLine("Employee Id:={0}", Employee1.ID);
            Console.WriteLine("Employee Name:={0}", Employee1.Name);
            Console.WriteLine("Employee JobTitle:={0}", Employee1.JobTitle);
            Console.ReadLine();


        }
    }
}
