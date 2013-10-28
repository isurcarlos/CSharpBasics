using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = 236; // int
            var var2 = 236L; // long
            var var3 = 236U; // unsigned int
            var var4 = 236UL; // unsigned long
            var var5 = 236F; // float
            var var6 = 236.714; // double
            var var7 = .35192; // double
            var var8 = 6.338e-26; // double
            var var9 = 236.24D; // decimal
            var var10 = 0x000F; // hexadecimal

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);
            Console.WriteLine(var7);
            Console.WriteLine(var8);
            Console.WriteLine(var9);
            Console.WriteLine(var10);
            Console.ReadLine();
        }
    }
}
