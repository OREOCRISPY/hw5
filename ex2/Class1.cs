using System;

namespace ex2
{
    class A
    {
        protected int n = 1;
        public A()
        {
            n++;
            Console.WriteLine("n =" + n.ToString());
        }
    }


    class B : A
    {
        public B()
        {
            n = 10;
            Console.WriteLine("n =" + n.ToString());
        }
    }
}
      
