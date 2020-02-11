using System;

namespace Maior_Numero_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois números: ");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            var MaiorNum = Math.Max(num1, num2);

            Console.WriteLine($"O maior número é {MaiorNum}");
        }
    }
}
