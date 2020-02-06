using System;

namespace ProblemaFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var meuSalarioString = "2000,00";
            double meuSalarioDouble = Convert.ToDouble(meuSalarioString);
            Console.WriteLine(meuSalarioString);
            Console.WriteLine($"Meu Salário é : {meuSalarioDouble:C3}");*/
            //problema \/

            Console.WriteLine("Digite seu salário: ");
            var Salario = Console.ReadLine();
            double SalarioDouble = Convert.ToDouble(Salario);
            //pode ser convertido tbm usando Parse
            Console.WriteLine($"Seu salário é {SalarioDouble:C3}");
        }
    }
}
