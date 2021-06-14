using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Hello";
            f(s);
            Console.WriteLine(s);
        }
        static void f(string s)
        {
            s += "world";

        }

    }
}
