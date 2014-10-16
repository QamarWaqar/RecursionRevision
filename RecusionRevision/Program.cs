using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusionRevision
{
    class Program
    {
        static int sI = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Object Recursion");
            Program p = new Program();
            p.func();
            // Now Caliing Static Recursion //
            sI = 0;
            Console.WriteLine("Now Calling Static Recursion Function");
            dunc();
        }

        void func()
        {
            if (sI == 3) { return; }
            if (sI >= 0) { Program p = new Program(); sI++; Console.WriteLine("Calling"); p.func(); Console.WriteLine("Returning"); }
        }

        static void dunc()
        {
            if (sI == 3) { return; }
            if (sI >= 0) { sI++; Console.WriteLine("Calling"); dunc(); Console.WriteLine("Returning"); }
        }
    }
}
