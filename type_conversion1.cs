using System;

namespace type_conversion1
{
    class type_conversion1
    {
        static void Main(string[] args)
        {
            //类型转换
            //不兼容
            string s = "123";

            double d = Convert.ToDouble(s);

            int i = Convert.ToInt32(s);

            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
