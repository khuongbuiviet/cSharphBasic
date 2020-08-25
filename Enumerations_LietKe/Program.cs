using System;
using System.Text;

namespace Enumerations_LietKe
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhiệt độ nước đông lạnh: {0}", (int)EnumClass.Temperatures.FeezingCold);// phải cast để lấy giá trị của enum
            Console.WriteLine("Nhiệt độ nước sôi: {0}", (int)EnumClass.Temperatures.BoilingPoint);

            EnumClass.EmpType fred;
            fred = EnumClass.EmpType.VP;
            Console.WriteLine("Anh là {0}",Enum.Format(typeof(EnumClass.EmpType),fred,"G"));
            EnumClass.AskForBonus(fred);

            Console.WriteLine("Giá trị của First: {0}", (int)EnumClass.SomeValues.First);
            Console.WriteLine("Giá trị của Second: {0}", (int)EnumClass.SomeValues.Second);
            Console.WriteLine("Giá trị của Fourth: {0}", (int)EnumClass.SomeValues.Fourth);

            // Đi tìm kiểu dữ liệu nằm đằng sau của enum bằng hàm Enum.GetUnderlyingType
            Console.WriteLine("Kiểu dữ liệu của enum Emptype: {0}", Enum.GetUnderlyingType(typeof(EnumClass.EmpType)));
            Console.WriteLine("Kiểu dữ liệu của enum Temperatures: {0}", Enum.GetUnderlyingType(typeof(EnumClass.Temperatures)));
            Console.WriteLine("Kiểu dữ liệu của enum SomeValues: {0}", Enum.GetUnderlyingType(typeof(EnumClass.SomeValues)));

            // Lấy thống kê đối với EmpType
            Array obj = Enum.GetValues(typeof(EnumClass.EmpType));
            Console.WriteLine("Enum này có {0} thành viên", obj.Length);
            // Bây giờ cho hiển chuỗi và các giá trị gắn liền
            foreach(EnumClass.EmpType e in obj)
            {
                Console.Write("Tên chuỗi: {0}", Enum.Format(typeof(EnumClass.EmpType), e, "G"));
                Console.Write(" ({0})", Enum.Format(typeof(EnumClass.EmpType), e, "D"));
                Console.Write(" hex: {0}\n", Enum.Format(typeof(EnumClass.EmpType), e, "x"));
            }
            Console.ReadLine();
        }
    }
}
