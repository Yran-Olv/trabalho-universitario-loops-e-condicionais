namespace Atividade16
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int n = 1;
			int fatorial = 1;
			int i = 1;

			Console.Write("Digite um número: ");
			n = int.Parse(Console.ReadLine());

			while (i <= n)
			{
				fatorial = fatorial * i;
				i++;
			}

			Console.WriteLine("Fatorial = " + fatorial);
		}
    }
}
