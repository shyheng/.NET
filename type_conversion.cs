using System;

namespace type_conversion
{
    class type_conversion
    {
        static void Main(string[] args)
        {
            /*            int m = 10;
                        double d = m;*///自动类型转换 隐式

            double m = 21.15;
            int i = (int)m;//强制类型转换 显性

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
