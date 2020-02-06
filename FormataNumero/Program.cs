using System;
using System.Globalization;

namespace FormataNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuSalario = 2000.00;

            Console.WriteLine(meuSalario.ToString("C"));
            Console.WriteLine(meuSalario.ToString("C2"));
            Console.WriteLine(meuSalario.ToString("C3"));

            Console.WriteLine(meuSalario.ToString("C4", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(meuSalario.ToString("C4", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(meuSalario.ToString("C4", CultureInfo.CreateSpecificCulture("jp-JP")));
            //utilizando interpolação
            Console.WriteLine($"{meuSalario:C2}");

            var idade = 18;

            Console.WriteLine($"Minha idade é {idade:N5}");
            Console.WriteLine($"Minha idade é {idade:N}");

            var valorTotal = 1500;
            Console.WriteLine($"Valor total a pagar: {valorTotal:F2}");
             
        }
    }
}
