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
            function.Question();
            Console.WriteLine($"Через пять лет вам будет: {function.Age(18)}");
            Console.WriteLine($"Сумма в результате умножения будет равна: {function.Sum(5,5)}");
            Console.WriteLine($"Сумма в результате деления будет равна: {function.division(5,5)}");
        }
    }
}
