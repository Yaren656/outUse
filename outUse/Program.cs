using System;

namespace outUse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; //değer atayabiliriz fakat out'da gerek yok.
            int number2 = 3;
            var result = Multiply(out number1, number2);

            Console.WriteLine("Sonuç : " + result);
        }
        
        static int  Multiply (out int number1, int number2)
        {
            number1 = 20; //out'da bunu eklemek zorundayız.
            return number1 * number2;
        }
    }
}
