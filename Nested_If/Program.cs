using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int NhietDo = 32;
            Console.OutputEncoding = Encoding.UTF8;
            if (NhietDo <= 32)
            {
                Console.WriteLine("Coi chừng! Băng đá trên đường!");
                if (NhietDo == 32)
                {
                    Console.WriteLine("Nhiệt độ đang đông lạnh, coi chừng nước");
                }
                else
                {
                    Console.WriteLine("Để ý băng đá đen! Nhiệt độ: {0}", NhietDo);
                }
            }
            Console.ReadLine();
        }
    }
}
