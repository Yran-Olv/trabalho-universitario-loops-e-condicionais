using System;

namespace Atividade5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                int n;
            Console.WriteLine("Digite um número que irei te falar se é impar");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("apenas numero:");
            }

            Console.WriteLine(n % 2 == 0 ? "Par" : "Impar");
        }
    }
}
