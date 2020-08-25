using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int triMot = 10;
            int triHai = 20;

            Console.OutputEncoding = Encoding.UTF8;
            if (triMot > triHai)
            {
                Console.WriteLine("Trị Một: {0} lớn hơn Trị Hai: {1}", triMot, triHai);
            }
            else
            {
                Console.WriteLine("Trị Hai: {0} lớn hơn Trị Một: {1}", triHai, triMot);
            }

            triMot = 30; // cho triMot giá trị lớn hơn

            if (triMot > triHai)
            {
                triHai = triMot++;
                Console.WriteLine("\nCho Trị Hai về giá trị của Trị Một, ");
                Console.WriteLine("và tăng 1 đối với triMot. \n");
                Console.WriteLine("Trị Một: {0} Trị Hai: {1}", triMot, triHai);
            }
            else
            {
                triMot = triHai;
                Console.WriteLine("Cho 2 biến bằng nhau. ");
                Console.WriteLine("TriMot: {0} TriHai: {1}", triMot, triHai);
            }

            Console.ReadLine();
        }
    }
}
