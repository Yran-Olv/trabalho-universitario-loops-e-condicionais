namespace Atividade20

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double n = double.Parse(Console.ReadLine());

            double dobro = n * n;
            double triplo = n * n * n;
			double raiz = Math.Sqrt(n);

            Console.WriteLine($"Dobro = {dobro}");
            Console.WriteLine($"Triplo = {triplo}");
            Console.WriteLine($"Raiz Quadrada = {raiz}");
		}
    }
}
