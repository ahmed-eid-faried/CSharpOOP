using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        //In C#, both classes and structures are used to define custom data types that can
        //contain fields, properties, methods, and events. However, there are some
        //differences between them. Here are some of the main differences between classes
        //and structures in C#:
        //Syntax: Classes are defined using the "class" keyword, followed by the class
        //name and the class body, which contains the class members. Structures are
        //defined using the "struct" keyword, followed by the struct name and the struct
        //body, which also contains the struct members.
        //Inheritance: Classes can be inherited by other classes to create a hierarchy
        //of related classes, whereas structures cannot be inherited or derived from other
        //structures.
        //Default constructor: Classes have a default constructor that is automatically
        //provided by the compiler if a constructor is not explicitly defined.Structures,
        //on the other hand, do not have a default constructor and require all fields to
        //be initialized explicitly.
        //Reference type vs Value type: Classes are reference types, which means that when
        //an instance of a class is created, a reference to that instance is returned.
        //Structures are value types, which means that when an instance of a structure
        //is created, the value of the instance is returned.
        //Performance: Structures are generally faster than classes for small, simple
        //types, as they are stored on the stack rather than the heap.This means that
        //accessing and manipulating a structure's fields can be faster than accessing
        //and manipulating a class's fields.
        //Memory management: Since structures are value types, they are allocated on
        //the stack, which is a limited resource, while classes are allocated on the heap,
        //which is a larger, more flexible memory pool. This means that using too many
        //structures or large structures can quickly consume the available stack memory,
        //causing a stack overflow error.

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
