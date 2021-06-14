using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class A
    {
        static int n =1;
        public void f()
        {
            n++;
        }
        public void Report()
                        {
            Console.WriteLine(n.ToString());
        }
    }
}