using System;

namespace baseconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecimalConversion.ConvertToBase8(130));
            Console.WriteLine(DecimalConversion.ConvertToBase2(260));
            Console.WriteLine(BinaryConversion.ConvertToBase10("11111100011111111"));
            Console.WriteLine(BinaryConversion.ConvertToBase8("110111111101111111"));
            Console.WriteLine(OctalConversion.ConvertToBase2("369"));
            Console.WriteLine(OctalConversion.ConvertToBase10("360"));

            Console.WriteLine("\n\nTo change the numbers to be converted, reference and edit Program.cs");
        }
    }
}