namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite o valor de X1");
			double x1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Digite o valor de Y1");
			double y1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Digite o valor de X2");
			double x2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Digite o valor de Y2");
			double y2 = double.Parse(Console.ReadLine());

			double D1 = x1 - y1;

			double D2 = x2 - y2;

			double D = Math.Sqrt((D1 * D1) + (D2 * D2));

			Console.WriteLine("A Distancia será: " + D);
			
		}
	}
}
