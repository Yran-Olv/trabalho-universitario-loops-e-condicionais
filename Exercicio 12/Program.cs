namespace Atividade12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            int i = 1;
            double soma = 0;

            do
            {
                Console.WriteLine("Digite um numero");
                n = double.Parse(Console.ReadLine());

				soma = soma + n;

				i++;
            }

            while (i <= 5);
            {
                Console.WriteLine($"A soma dos numeros sera {soma}");
			}
		}

    }
}
