namespace Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o Numero 1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o Numero 2");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o Numero 3");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior é " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O maior é " + n2);
            }
            else
            {
                Console.WriteLine("O maior é " + n3);
            }
        }
    }
}
