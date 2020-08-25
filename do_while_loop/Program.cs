using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            do
            {
                // vòng lặp do...while chạy ít nhất 1 lần cho dù điều kiện là false
                Console.WriteLine("i: {0}", i);
                i++;
            } while (i < 10);
            Console.ReadLine();
        }
    }
}
