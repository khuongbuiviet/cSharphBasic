using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        public static int Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i: {0}", i);
                i++;
            }
            Console.ReadLine();
            return 0;
        } // end main
    }
}
