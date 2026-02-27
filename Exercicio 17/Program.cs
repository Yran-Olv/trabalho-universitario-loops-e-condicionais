namespace Atividade17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 1;

			Console.WriteLine("Digite um numero");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                if (n % i == 0 )
                {
                    Console.WriteLine(i);
                }
               i++;
			}
            
		}
    }
}
