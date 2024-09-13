﻿using System;
using static CSharpOOP.OuterClass;

namespace CSharpOOP
{
    public class OuterClass
    {
        private int outerVariable;

        public OuterClass(int outerVariable)
        {
            this.outerVariable = outerVariable;
        }

        public void OuterMethod()
        {
            Console.WriteLine("Outer method called.");
        }

        public class InnerClass
        {
            private int innerVariable;


            public InnerClass(int innerVariable)
            {
                this.innerVariable = innerVariable;
            }

            public void InnerMethod()
            {
                Console.WriteLine("Inner method called with innerVariable = " + innerVariable);
            }

            public void AccessOuterVariable(OuterClass outer)
            {
                Console.WriteLine("Accessing outerVariable from inner class: " + outer.outerVariable);
            }
        }
    }

    internal class clsNestedClass
    {
        internal static void NestedClassEx()
        {
            //we have created the class InnerClass inside the class OuterClass.
            //The InnerClass is called the nested class.

            // create an instance of OuterClass
            OuterClass outer1 = new OuterClass(42);

            // create an instance of InnerClass
            OuterClass.InnerClass inner1 = new OuterClass.InnerClass(100);

            // call methods on the instances
            outer1.OuterMethod(); // prints "Outer method called."
            inner1.InnerMethod(); // prints "Inner method called with innerVariable = 100"
            inner1.AccessOuterVariable(outer1); // prints "Accessing outerVariable from inner class: 42"

            //In this example, InnerClass is defined inside OuterClass.It has its own
            //private innerVariable field and a method called InnerMethod that prints
            //the value of that variable.It also has a method called AccessOuterVariable
            //that takes an instance of OuterClass as a parameter and prints the value of
            //the outerVariable field.


        }
}
}