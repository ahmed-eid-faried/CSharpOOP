﻿using System;

namespace CSharpOOP
{
    internal class clsPolymorphism
    {
        public class ClsC
        {
            public void Sum(int x, int y)
            {
                Console.WriteLine(x + y);
            }
            public void Sum(int x, int y, int z)
            {
                Console.WriteLine(x + y + z);
            }
            public void Sum(int[] List)
            {
                int sum = 0;
                foreach (int x in List)
                {
                    sum += x;
                }
                Console.WriteLine(sum);
            }
        }

        public class ClsAA
        {
            public virtual void Print()
            {
                Console.WriteLine("Method: ClsAA");
            }
        }
        public class ClsBB : ClsAA
        {
            public override void Print()
            {
                Console.WriteLine("Method: ClsBB");
            }
        }
        public class ClsCC : ClsAA
        {
            public override void Print()
            {
                Console.WriteLine("Method: ClsCC");
            }
        }

        //Polymorphism in C# refers to the ability of an object to take on multiple forms, i.e.,
        //objects of different types can be treated as objects of a common base type.
        internal static void CompileTimePolymorphismEx()
        {
            //overloading ====>> >> Compile-Time Polymorphism
            //-----------------------------------------------
            //compile - time polymorphism(also known as method overloading) : Method overloading
            //allows multiple methods to have the same name, but with different parameters.
            //The compiler selects the appropriate method to call based on the number, types,
            //and order of the parameters.

            //overloading
            ClsC ObjC = new ClsC();
            ObjC.Sum(1, 2);
            ObjC.Sum(1, 2, 3);
            int[] marks = new int[] { 99, 98, 92, 97, 95 };
            ObjC.Sum(marks);
            ObjC.Sum(new int[] { 99, 98, 92, 97, 95 });

        }
        internal static void RunTimePolymorphismEx()
        {
            //overriding ====>> >> RunTime Polymorphism
            //-----------------------------------------
            //Runtime polymorphism (also known as method overriding): Method overriding allows
            //a subclass to provide a specific implementation of a method that is already provided
            //by its parent class. The method in the subclass must have the same signature
            //(name, return type, and parameters) as the method in the parent class.

            //overriding
            ClsAA ObjA = new ClsAA();
            ObjA.Print();
            ClsBB ObjB = new ClsBB();
            ObjB.Print();
            ClsCC ObjC = new ClsCC();
            ObjC.Print();


        }
        internal static void InheritancePolymorphismEx()
        {
            //Inheritance Polymorphism
            //------------------------
            //inheritance is also a form of polymorphism known as "subtyping" or "subtype
            //polymorphism".


            //overriding
            ClsAA ObjA = new ClsAA();
            ObjA.Print();
            ClsBB ObjB = new ClsBB();
            ObjB.Print();

        }
    }
}