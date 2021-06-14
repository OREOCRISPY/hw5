using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    abstract class A
    {
        int x;
        public abstract void f(int n);
    protected virtual void g(uint n)
    {
        x = (int)n;
    }
    public string ToString()
    {
        return x.ToString();
    }
}

}
