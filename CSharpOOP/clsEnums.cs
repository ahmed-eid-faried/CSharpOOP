using System;

namespace CSharpOOP
{
    internal class clsEnums
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        enum Days
        {
            Sun = 0,
            Mon = 1,
            Thu,
            Won,
            Tue,
            Fri,
            Sat,
        }
        internal static void EnumsEx()
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
            Days myDay = Days.Fri;
            Console.WriteLine(myDay);
        }
    }
}