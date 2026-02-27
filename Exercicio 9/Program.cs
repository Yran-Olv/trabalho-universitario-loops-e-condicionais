using System;

namespace Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {
               int i = 1;
            int soma = 0;
            while (i <= 100)
            {
                soma = soma + i;
                i++;
            }


            Console.WriteLine("Soma = " + soma);
        }
    }
}
