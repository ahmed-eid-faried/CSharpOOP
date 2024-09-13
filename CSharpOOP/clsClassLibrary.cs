using System;
using MyFirstClassLibrary;
using MySecondClassLibrary;

namespace CSharpOOP
{
    internal class clsClassLibrary
    {
        internal static void clsClassLibraryEx()
        {
            clsMath math = new clsMath();
            Console.WriteLine(math.Sum(10, 20));
            Console.WriteLine("====>>>====>>> ADD REF BY DLL FILE ====>>>====>>>");
            clsString str = new clsString();
            Console.WriteLine(str.Sum("AHMED ", "MADY"));
        }
    }
}