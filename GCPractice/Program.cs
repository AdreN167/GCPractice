using System;
using System.Collections.Generic;

namespace GCPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------1---------------------
            var substringMethod = typeof(string).GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
            var value = substringMethod.Invoke("Hello, world!!!", new object[2] { 0, 6 });

            Console.WriteLine(value);
            Console.WriteLine();

            //-----------------2---------------------
            var listConstructors = Type.GetType("System.Collections.Generic.List`1").GetConstructors();
            foreach (var constructor in listConstructors)
            {
                Console.WriteLine("public List<T>");
                Console.WriteLine("(");

                foreach (var parameter in constructor.GetParameters())
                {
                    Console.WriteLine($"\t{parameter.ParameterType} {parameter.Name}");
                }

                Console.WriteLine(")");
            }
        }
    }
}
