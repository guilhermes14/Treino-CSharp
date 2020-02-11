using System;

namespace Tempo_De_Vida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua data de nascimento (dd/mm/yyyy):");
            var DataNascimento = Console.ReadLine();

            var data = DateTime.Parse(DataNascimento);
            var dataAtual = DateTime.Now;
            var DiasVividos = dataAtual - data;

            Console.WriteLine($"Você viveu {DiasVividos.Days} dias.");
        }
    }
}
