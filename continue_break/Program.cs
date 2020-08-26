using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_break
{
    class Program
    {
        static void Main(string[] args)
        {
            string signal = "O"; // khởi gán 1 giá trị
            Console.OutputEncoding = Encoding.UTF8;
            while (signal != "X") // khi nhập X thì ngưng
            {
                Console.Write("Nhập vào 1 tín hiệu: ");
                signal = Console.ReadLine(); // đọc tín hiệu

                // làm cái gì ở đây, bất kể nhận được tín hiệu gì
                Console.WriteLine("Tín hiệu nhận được: {0}", signal);

                if (signal == "A")
                {
                    // bỏ ngang và ghi theo dõi
                    Console.WriteLine("Sai! Bỏ ngang\n");
                    break;
                }

                if (signal == "O")
                {
                    // bình thường, ghi theo dõi và tiếp tục
                    Console.WriteLine("Mọi việc ổn.\n");
                    continue;
                }

                // Có vấn đề - Hành động, ghi theo dõi và tiếp tục
                Console.WriteLine("{0} - báo động!\n", signal);
            } // end while
        } // end main 
    }
}
