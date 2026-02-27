namespace Atividade8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero 3");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 > 0 && n2 > 0 && n3 > 0)
            {
                double s = n1 + n2 + n3;

                Console.WriteLine("Soma = " + s);
            }
           
        }
    }
}
