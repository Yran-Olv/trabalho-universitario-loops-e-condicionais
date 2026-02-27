namespace Atividade18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade 1");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade 2");
            int idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade 3");
            int idade3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade 4");
            int iidade4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade 5");
            int idade5 = int.Parse(Console.ReadLine());

            double media = (double) (idade1 + idade2 + idade3 + iidade4 + idade5) / 5;

            Console.WriteLine($"A media é = {media}");

		}
    }
}
