using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpOOP.Car;

namespace CSharpOOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ClassObject.PersonEx();
            //AccessModifiers.AccessModifiersEx();
            //StaticMembers.StaticMembersEx();
            //GetSetProperty.PropertiesSetAndGet();
            //StaticPropertiesAndStaticClass.StaticPropertiesAndStaticClassEx();
            //Constructor.ConstructorEx();
            //Constructor.ParameterizedConstructorEx();
            //Constructor.DefaultConstructorEx();
            Constructor.PreventCreateObject();
            Constructor.MultipleConstructorsUsingOverloading();

            Console.ReadKey();

        }
    }
}
