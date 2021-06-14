using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            A x = new A(), y = new A();
            x.f();
            x.Report();
            y.f();
            y.Report();
        }
    }
}
