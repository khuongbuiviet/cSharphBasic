using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            Console.OutputEncoding = Encoding.UTF8;
            t.DisplayCurrentTime();
            Console.ReadLine();
        }// end Main
    }
}
