using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("ClassA");
        }
    }

    class ClassB : ClassA { }
    class ClassC : ClassA
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("ClassB");
        }
    }
    internal class clsOverriding
    {
        //If the same method is present in both the base class and the derived class,
        //the method in the derived class overrides the method in the base class. 
        //This is called method overriding in C#.  


        //In that case, we use the base keyword to call the method of the base class from the derived class.
        //base keyword is used to call the Print method in the base class.



        public static void OverridingEx()
        {
            Console.WriteLine("================================");
            ClassA Aa = new ClassA();
            Aa.Print();
            Console.WriteLine("================================");
            ClassB B = new ClassB();
            B.Print();
            Console.WriteLine("================================");
            ClassC C = new ClassC();
            C.Print();
            Console.WriteLine("================================");
        }
    }
}
