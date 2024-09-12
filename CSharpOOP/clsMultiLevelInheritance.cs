﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Person
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
        }
    }
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }
        public void Work()
        {
            Console.WriteLine($"Employee with ID {EmployeeId} and salary {Salary:C} is working.");
        }
    }
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public void Heal()
        {                                                                   //DUT TO THIS 100,000.00 USE :C
            Console.WriteLine($"Doctor {Name} with ID {EmployeeId}, salary {Salary:C}, and specialty {Specialty} is healing a patient.");
        }
    }
    internal class clsMultiLevelInheritance
    {
        public static void MultiLevelInheritanceEx()
        {
            Doctor doctor = new Doctor();
            doctor.Name = "John";
            doctor.Age = 35;
            doctor.EmployeeId = 123;
            doctor.Salary = 100000.00M;
            doctor.Specialty = "Cardiology";
            doctor.Introduce(); // Output: "Hi, my name is John and I'm 35 years old."
            doctor.Work(); // Output: "Employee with ID 123 and salary $100,000 is working."
            doctor.Heal(); // Output: "Doctor John with ID 123, salary $100,000, and specialty Cardiology is healing a patient."

        }
    }
}
