namespace Atividade14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

			Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
			}
		}
    }
}
