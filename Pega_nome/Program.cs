using System;

namespace Pega_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu primeiro nome: ");
            var primeiroNome = Console.ReadLine();
            
            Console.WriteLine("Informe seu segundo nome: ");
            var segundoNome = Console.ReadLine();
            
            Console.WriteLine($"Seu nome é {primeiroNome} {segundoNome}");
        }
    }
}
