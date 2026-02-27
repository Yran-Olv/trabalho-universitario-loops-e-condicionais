namespace Atividade7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior é " + numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O maior é " + numero2);
            }

            else
            {
                Console.WriteLine("Numeros são iguais");
            }
        }
    }
}
