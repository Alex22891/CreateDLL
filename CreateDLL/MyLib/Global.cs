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

        public float Sum(float x, float y)
        {
            return x * y;
        }

        public double division(double a, double b)
        {
            return a / b;
        }
    }
}
