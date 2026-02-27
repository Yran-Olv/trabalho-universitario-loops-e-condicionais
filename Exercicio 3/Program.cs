namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de C");
            int c = int.Parse(Console.ReadLine());

            int r = (a + b) * (a + b);
            int s = (b + c) * (b + c);
            int d = r + s;

            Console.WriteLine("D é igual a:  " + d);
		}
    }
}
