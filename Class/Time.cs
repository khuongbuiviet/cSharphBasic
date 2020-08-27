using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Time 
    {
        // khai báo hàm constructor
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }

        // các hàm hành sự public
        public void DisplayCurrentTime() // để private nếu không muốn bị truy xuất bởi lớp khác
        {
            Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}",Month,Date,Year,Hour,Minute,Second);
        }

        // các biến private
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;
    }// end Time class
}
