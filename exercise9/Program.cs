using System;

namespace exercise9
{
    class Program
    {

        static void Main(string[] args)
        {
            A[] data = new A[10];
            Array.Sort(data, (x, y) => (x.n - y.n)==0?x.s.CompareTo(y.s):(x.n-y.n));
        }
    }
    class A:IComparable
    {
        public int n;
        public String s;
        public A() { n = 10; s = "check"; }


        public int CompareTo(object o)
        {
            if (o.GetType().Name == "A")
            {
                A c = o as A;
                return (this.n -c.n ) == 0 ? this.s.CompareTo(c.s) : (this.n - c.n);
            }
            else {
                throw new Exception("illegal object");
            }
        }
    }
}
