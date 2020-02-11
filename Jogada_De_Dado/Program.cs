using System;

namespace Jogada_De_Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tente a sorte e acerte o lado do Dado:");
            var numeroEsperado = int.Parse(Console.ReadLine());

            var Dado = new Random();
            var jogada = Dado.Next(1, 7);

            if(numeroEsperado == jogada)
            {
                Console.WriteLine($"O dado deu {jogada}");
                Console.WriteLine("Boa! Você acertou!");
            }
            else
            {
                Console.WriteLine($"O dado deu {jogada}");
                Console.WriteLine("Você errou, tente novamente!");
            }
        }
    }
}
