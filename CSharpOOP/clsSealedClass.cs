using System;

namespace CSharpOOP
{
    internal class clsSealedClass
    {
        sealed class clsA { }

        // trying to inherit sealed class
        // Error Code
        //class clsB : clsA { }
        class clsB { }
        internal static void SealedClassEx()
        {
            // create an object of B class
            clsB B1 = new clsB();
            Console.WriteLine("error CS0509: 'B': cannot derive from sealed type 'Al'\r\n");

        }
    }
}