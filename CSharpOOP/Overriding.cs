using System;
using System.Collections.Generic;
using System.Linq;
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
