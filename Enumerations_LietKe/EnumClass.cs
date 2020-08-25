using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_LietKe
{
    class EnumClass
    {
        public enum Temperatures
        {
            WickedCold = 0,
            FeezingCold = 32,
            LightJacketWeather = 60,
            SwimmingWeather = 72,
            BoilingPoint = 212
        }

        public enum SomeValues
        {
            // Giá trị của First là 0, Second là 1, Third là 20 thì Fourth sẽ là 21
            First,
            Second,
            Third = 20,
            Fourth
        }

        public enum EmpType: byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VP = 9
        }

        public static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Contractor:
                    Console.WriteLine("bạn đã có quá nhiều tiền mặt...");
                    break;

                case EmpType.Grunt:
                    Console.WriteLine("Anh bạn giỡn hả...");
                    break;

                case EmpType.Manager:
                    Console.WriteLine("Thị trường chứng khoán sao rồi?");
                    break;

                case EmpType.VP:
                    Console.WriteLine("VERY GOOD, SIR!");
                    break;

                default:break;
            }
        }
    }
}
