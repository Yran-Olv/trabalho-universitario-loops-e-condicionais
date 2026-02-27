namespace Atividade19
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int numero, i;
			bool primo = true;

			Console.Write("Digite um número: ");
			numero = int.Parse(Console.ReadLine());

			if (numero <= 1)
			{
				primo = false;
			}
			else
			{
				i = 2;

				while (i < numero)
				{
					if (numero % i == 0)
					{
						primo = false;
						break;
					}

					i++;
				}
			}

			if (primo)
			{
				Console.WriteLine("É primo");
			}
			else
			{
				Console.WriteLine("Não é primo");
			}
		}
    }
}
