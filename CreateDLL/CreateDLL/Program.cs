using System;
using MyLib;

namespace CreateDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Global function = new Global();

            function.SayHello("Александр");
            Console.WriteLine($"Через пять лет вам будет: {function.Age(18)}");
        }
    }
}
