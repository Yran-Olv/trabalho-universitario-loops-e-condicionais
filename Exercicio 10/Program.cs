namespace Atividade10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int multi = 0;

			Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());

            while (i <= 10)
            {
                multi = n * i;
                Console.WriteLine($"{n} x {i} = {multi}");
				i++;
			}
		}
    }
}
