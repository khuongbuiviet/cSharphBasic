using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator_TacTuTamPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int TriMot = 10;
            int TriHai = 20;
            int maxValue = TriMot > TriHai ? TriMot : TriHai; // maxValue = TriHai do không thỏa điều kiện.
            Console.WriteLine("TriMot: {0}, TriHai: {1}, maxValue: {2}", TriMot, TriHai, maxValue);
            Console.ReadLine();
        } // end main
    } // end class
}
