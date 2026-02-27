namespace Atividade11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algum numero");
            double n = double.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"{n} é positivo");
            }
            else if ( n < 0)
            {
                Console.WriteLine($"{n} é negativo");
            }
			else
			{
                Console.WriteLine($"{n} é zero");
            }
		}
    }
}
