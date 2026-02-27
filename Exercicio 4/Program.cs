namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Digite a nota do primeiro bimestre: ");
			double p1 = double.Parse(Console.ReadLine());

			Console.Write("Digite a nota do segunda bimestre: ");
			double p2 = double.Parse(Console.ReadLine());

			Console.Write("Digite a nota avaliações finais: ");
			double p3 = double.Parse(Console.ReadLine());

			double m = (p1 * 2 + p2 * 3 + p3 * 5) / 10;

			Console.WriteLine("Média ponderada = " + m);
		}
    }
}
