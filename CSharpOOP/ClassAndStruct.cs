﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Employee13
    {
        public string name;
    }

    struct Employee14
    {
        public string name;
    }
    internal class ClassAndStruct
    {
        //Property              Class                            Struct
        //------------------------------------------------------------------------------------------
        //Type                  Reference Type                   Value Type
        //Memory Storage        Heap                             Stack
        //Copying               Copies the reference             Copies the value
        //Inheritance           Supports inheritance             Does not support inheritance
        //Default Constructor   Has a default constructor        No default constructor
        //Performance           Slower, stored in Heap           Faster, stored in Stack
        //Memory Management     Managed in Heap, more flexible   Stored in Stack, limited memory
        //Mutability            Changes via reference            Independent copy
        //Methods & Properties  Can contain complex methods      Simpler, basic methods
        //Use Cases             Used for large, complex data     Used for simple, lightweight data



        public static void ClassEx()
        {
            Employee13 emp1 = new Employee13();
            emp1.name = "John";
            Employee13 emp2 = emp1;
            emp2.name = "Ahmed Mady";
            Console.WriteLine("Employee1 name: " + emp1.name); // النتيجة: Ahmed Mady
        }
        public static void StructEx()
        {
            Employee14 emp1 = new Employee14();
            emp1.name = "Ahmed Mady";
            Employee14 emp2 = emp1;
            emp2.name = "Ali";
            Console.WriteLine("Employee1 name: " + emp1.name); // النتيجة: Ahmed Mady
        }
        public static void StructVsClassEx()
        {
            // Define table headers
            string[] headers = { "Property", "Class", "Struct" };

            // Define table content
            string[,] table = {
            { "Type", "Reference Type", "Value Type" },
            { "Memory Storage", "Heap", "Stack" },
            { "Copying", "Copies the reference", "Copies the value" },
            { "Inheritance", "Supports inheritance", "Does not support inheritance" },
            { "Default Constructor", "Has a default constructor", "No default constructor" },
            { "Performance", "Slower, stored in Heap", "Faster, stored in Stack" },
            { "Memory Management", "Managed in Heap, more flexible", "Stored in Stack, limited memory" },
            { "Mutability", "Changes via reference", "Independent copy" },
            { "Methods & Properties", "Can contain complex methods", "Simpler, basic methods" },
            { "Use Cases", "Used for large, complex data", "Used for simple, lightweight data" }
        };

            // Define the table width for each column
            int columnWidth = 30;

            // Print table headers
            Console.WriteLine("{0,-30} {1,-30} {2,-30}", headers[0], headers[1], headers[2]);
            Console.WriteLine(new string('-', columnWidth * headers.Length));

            // Print table rows
            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.WriteLine("{0,-30} {1,-30} {2,-30}", table[i, 0], table[i, 1], table[i, 2]);
            }

        }
    }
}
