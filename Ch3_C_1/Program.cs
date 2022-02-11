using System;

namespace Ch3_C_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 0x49;
            byte b = 0xE3;
            int c = (int)(a ^ b);
            
            Console.WriteLine("8 位元某數與 0x49 作 XOR 運算, 結果是 0xE3, 求某數是多少 ? " );
            Console.WriteLine($"某數是 :{c:X} ");
            
            Console.Read();
            
        }
    }
}
