using System;

namespace MyLib
{
    public class Global
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Здравствуйте, {name}");
        }

        public int Age(int x)
        {
            return x + 5;
        }
    }
}
