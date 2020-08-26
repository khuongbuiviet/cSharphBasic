using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
                if (i % 10 == 0)
                {
                    Console.WriteLine("\t{0}", i);
                } // end if
            } //end for
            Console.ReadLine();
        } // end main
    }
}
