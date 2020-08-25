using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstant_LopHangSo
{
    class MyConstants
    {
        // Ví dụ tạo một vài hằng số cho vui...
        public const int myIntConst = 5;
        public const string myStringConst = "Tôi là kẻ bất tài!";

        // không để cho người sử dụng dùng lớp này
        // hàm contructor phải khai báo private
        private MyConstants() { }
    }
}
