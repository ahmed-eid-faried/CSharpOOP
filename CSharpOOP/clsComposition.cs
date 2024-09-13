using System;

namespace CSharpOOP
{
    internal class clsComposition
    {
        class clsA
        {
            public void Method1()
            {
                Console.WriteLine("Method1 of class A is called");
            }
        }
        public class clsB
        {
            public void Method1() { Console.WriteLine("Class B"); }
            public void Method2()
            {
                Console.WriteLine("Now i will call method1 of class A...");
                clsA ObjA = new clsA();
                ObjA.Method1();
            }
        }
        internal static void CompositionEx()
        {
            //Create object from class
            clsB ObjectB1 = new clsB();
            ObjectB1.Method1();
            ObjectB1.Method2();
        }
    }
}