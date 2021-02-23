using System;

namespace escape_character
{
    class escape_character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义\" \t,\n sss\b");
            /*@按照原格式输出*/
            Console.WriteLine(@"shy
                heng");
        }
    }
}
