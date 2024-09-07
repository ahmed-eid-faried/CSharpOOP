C# Access Modifiers
In C#, access modifiers specify the accessibility of types (classes, interfaces, etc) and type members (fields, methods, etc).

Access modifiers, are used to set the access level/visibility for classes, fields, methods and properties.

For example,

 using System;

namespace AccessModifiers
{
    class clsA
    {
        public int x1 = 10;
        private int x2 = 20;
        protected int x3 = 30;

       public  int fun1()
        {
            return 100;
        }

        private int fun2()
        {
            return 200;
        }

        protected  int fun3()
        {
            return 300;
        }
    }

    class clsB : clsA
    { 
        public int fun4()
        {
            //x1 is public and x3 is protected in the base class so you can access them.
            //You cannot access any private members of the base class.
            return x1 + x3 ;
        }
    
    }


        internal class Program
    {
        static void Main(string[] args)
        {
            //Create object from class
            clsA A = new clsA();

            //all public members are accessable and internal 
            Console.WriteLine("All public members are accessable");
            Console.WriteLine("x1={0}" , A.x1);
            Console.WriteLine("result of fun1={0}", A.fun1());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2={0}", A.x2);

            //you cannot access protected members in the folling line.
            // Console.WriteLine("x3={0}", A.x3);

            //you cannot access private members in the folling line.
            // Console.WriteLine("result of fun2={0}", A.fun2());

            //you cannot access protected members in the folling line.
            // Console.WriteLine("result of fun3={0}", A.fun3());

            clsB B = new clsB();
            Console.WriteLine("\nObjects from class B expose all public members from the base class");
            Console.WriteLine("x1={0}", B.x1);
            Console.WriteLine("result of fun1={0}", B.fun1());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2={0}", B.x2);
           // Console.WriteLine("result of fun1={0}", B.fun2());

            //you cannot access protected members in the folling line.
            // Console.WriteLine("x3={0}", B.x3);
            //Console.WriteLine("result of fun3={0}", B.fun3());

            Console.ReadKey();
        }
    }
}




Types of Access Modifiers

In C#, there are 4 basic types of access modifiers.

public : The code is accessible for all classes
private : The code is only accessible within the same class
protected : The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal : The code is only accessible within its own assembly (dll), but not from another assembly. internal is equivalent to friend in c++.


Public/Private access modifier
When we declare a type or type member public, it can be accessed from anywhere. When we declare a type member with the private access modifier, it can only be accessed within the same class or struct.

Protected access modifier
When we declare a type member as protected, it can only be accessed from the same class and its derived classes (the classes that inherits myclass) .



Internal access modifier
When we declare a type or type member as internal, it can be accessed only within the same assembly.

An assembly is a collection of types (classes, interfaces, etc) and resources (data). They are built to work together and form a logical unit of functionality.

That's why when we run an assembly all classes and interfaces inside the assembly run together.

Example: internal within the same Assembly
using System;

namespace Assembly {

  class Student {
   internal string name = "Mohammed Abu-Hadhoud";
  }

  class Program {
    static void Main(string[] args) {
    
      // creating object of Student class
      Student theStudent = new Student();
      
      // accessing name field and printing it
      Console.WriteLine("Name: " + theStudent.name);
      Console.ReadLine();
    }
  }
}
Output

Name: Mohammed Abu-Hadhoud
In the above example, we have created a class named Student with a field name. Since the field is internal, we are able to access it from the Program class as they are in the same assembly.

If we use internal within a single assembly, it works just like the public access modifier.

Summary:﻿
![File](file.png)
There's also two combinations: protected internal and private protected.

For now, lets focus on public and private and protectedmodifiers.