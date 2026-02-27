namespace Atividade15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
			int n = 0;
			int par = 0;
			int impar = 0;

			do
			{
				Console.WriteLine("Digite um numero");
				n = int.Parse(Console.ReadLine());

				if ( n % 2 == 0)
				{
					par++;
				}
				else
				{
					impar ++;
				}

				i++;
			}

			while (i < 10);
			{
				Console.WriteLine($"Quantidade de pares = {par}");
				Console.WriteLine($"Quantidade de Impares = {impar}");
			}
		}
    }
}
