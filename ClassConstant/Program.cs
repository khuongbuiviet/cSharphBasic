using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstant_LopHangSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("myIntConst = {0}\nmyStringConst = {1}", MyConstants.myIntConst, MyConstants.myStringConst);
            Console.ReadLine();
        }
    }
}
