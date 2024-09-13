using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class AccessModifiers
    {
        class clsA
        {
            public int x1 = 10;
            private int x2 = 20;
            protected int x3 = 30;

            public int fun1() { return x1 * 100; }
            private int fun2() { return x2 * 100; }
            protected int fun3() { return x3 * 100; }
        }
        class clsB : clsA
        {
            public int x4 = 40;

            public int fun4() { return x1 * x3 * x4; }

        }
        public static void AccessModifiersEx()
        {
            Console.WriteLine("Class A: ");
            clsA ObjA = new clsA();
            //all public members are accessable and internal 
            Console.WriteLine("x1 = {0} ", ObjA.x1);
            Console.WriteLine("fun1 = {0} ", ObjA.fun1());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2 = {0} ", ObjA.x2);
            //Console.WriteLine("fun2 = {0} ", ObjA.fun2());

            //you cannot access protected members in the folling line.
            //Console.WriteLine("x3 = {0} ", ObjA.x3);
            //Console.WriteLine("fun3 = {0} ", ObjA.fun3());
            ////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////

            Console.WriteLine("Class B: ");
            clsB ObjB = new clsB();
            //all public members are accessable and internal (from class A)
            Console.WriteLine("x1 = {0} ", ObjB.x1);
            Console.WriteLine("fun1 = {0} ", ObjB.fun1());
            //Class B cannot inherit the private members of Class A, so it does not exist in B at all.
            //Console.WriteLine("x2 = {0} ", ObjB.x2);
            //Console.WriteLine("fun2 = {0} ", ObjB.fun2());

            //you cannot access protected members in the folling line. (from class A)
            //Console.WriteLine("x3 = {0} ", ObjB.x3);
            //Console.WriteLine("fun3 = {0} ", ObjB.fun3());

            //all public members are accessable and internal (In class B)
            Console.WriteLine("x2 = {0} ", ObjB.x4);
            Console.WriteLine("fun2 = {0} ", ObjB.fun4());
            ////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////
            //internal access modifier
            //When we declare a type or type member as internal, it can be accessed only within
            //the same assembly(Same DLL).

            //An assembly is a collection of types(classes, interfaces, etc) and resources(data).
            //They are built to work together and form a logical unit of functionality.

            //That's why when we run an assembly all classes and interfaces inside the assembly
            //run together.

            //Note: Internal in C# is equivalent to friend in C++.
            ////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////


        }
    }
}
