using System;

namespace Subtração
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os números para serem subtraíddos:");

            Console.WriteLine("Digite o numero 1:");
            var num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 2:");
            var num2 = Double.Parse(Console.ReadLine());

            var Resultado = num1-num2;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"{num1} menos {num2} é igual {Resultado}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
