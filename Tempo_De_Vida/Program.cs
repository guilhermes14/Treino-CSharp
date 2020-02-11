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
            Console.WriteLine($"Você nasceu em uma {data:ddd}");
            //Tipos de datas possíveis
            Console.WriteLine($"A data atual é {dataAtual:d}");
            Console.WriteLine($"A data atual é {dataAtual:D}");
            Console.WriteLine($"A data atual é {dataAtual:F}");
            Console.WriteLine($"A data atual é {dataAtual:f}");
            Console.WriteLine($"A data atual é {dataAtual:dd}");
            Console.WriteLine($"A data atual é {dataAtual:ddd}");
        }
    }
}
