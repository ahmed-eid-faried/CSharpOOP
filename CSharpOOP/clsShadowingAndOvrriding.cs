using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class SuperClass
    {
        public virtual void Print1()
        {
            Console.WriteLine("SuperClass ===>> Print1");
        }
        public virtual void Print2()
        {
            Console.WriteLine("SuperClass ===>> Print2");
        }
    }
    class DerivedClass : SuperClass
    {
        public override void Print1()
        {
            Console.WriteLine("DerivedClass ===>> override ===>> Print1");
        }
        public new void Print2()
        {
            Console.WriteLine("DerivedClass ===>> Shadowing(new) ===>> Print2");
        }
    }

    internal class clsShadowingAndOvrriding
    {
        public static void ShadowingAndOvrridingEx()
        {
            Console.WriteLine("=======================Super Class=======================");
            SuperClass superClass = new SuperClass();
            superClass.Print1();
            superClass.Print2();
            Console.WriteLine("======================Derived Class======================");
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Print1();
            derivedClass.Print2();
            Console.WriteLine("=====================After UpCasting=====================");
            DerivedClass superClass2 = (DerivedClass)derivedClass;
            superClass2.Print1();
            superClass2.Print2();
            Console.WriteLine("=========================================================");
        }
    }
}
