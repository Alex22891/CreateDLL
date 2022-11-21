using System;

namespace MyLib
{
    public class Global
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Здравствуйте, {name}");
        }

        public void Question()
        {
            Console.WriteLine("Как твои дела?");
        }

        public int Age(int x)
        {
            return x + 5;
        }

        public int Sum(int x, int y)
        {
            return x * y;
        }

        public double division(int a, int b)
        {
            return a / b;
        }
    }
}
