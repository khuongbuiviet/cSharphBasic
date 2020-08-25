using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_method
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Democrat = 0;
            const int LiberalRepublican = 1;
            const int Republican = 2;
            const int Libertarian = 3;
            const int NewLeft = 4;
            const int Progressive = 5;

            int myChoice = Libertarian;

            Console.OutputEncoding = Encoding.UTF8;
            switch (myChoice)
            {
                case Democrat:
                    Console.WriteLine("Bạn bỏ phiếu cho Democrat.\n");
                    break;
                case LiberalRepublican: //nhảy thằng xuống case Republican
                                        //Console.WriteLine("LiberalRepublican bỏ phiếu cho Republican\n");
                case Republican:
                    Console.WriteLine("Bạn bỏ phiếu cho Republican.\n");
                    break;
                case Libertarian:
                    Console.WriteLine("Libertarian bỏ phiếu cho Republican.\n");
                    goto case Republican;
                case NewLeft:
                    Console.WriteLine("NewLeft bây giờ Progressive.\n");
                    goto case Progressive;
                case Progressive:
                    Console.WriteLine("Bạn bỏ phiếu cho Progressive.\n");
                    break;

                default:
                    Console.WriteLine("Bạn chọn không đúng rồi.\n");
                    break;
            } // end switch
            Console.WriteLine("Cám ơn bạn đã bỏ phiếu.");
            Console.ReadLine();
        } // end main
    }
}
