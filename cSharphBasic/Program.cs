using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_HangSo
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int NhietDoDongLanh = 32; //độ F
            const int NhietDoSoi = 212;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Độ nước đông lạnh: {0}", NhietDoDongLanh);
            Console.WriteLine("Độ nước sôi: {0}", NhietDoSoi);
            // NhietDoSoi = 21; //Không thể gán lại giá trị cho 1 hằng
            Console.ReadLine();            
        }
    }
}
