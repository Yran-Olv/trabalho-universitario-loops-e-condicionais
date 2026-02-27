namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resposta1 = ReadInt("Digite o Numero 1");
            int resposta2 = ReadInt("Digite o Numero 2");

            int somar = resposta1 + resposta2;
            double sub = (double) resposta1 - resposta2;
            int multi = resposta1 * resposta2;
            double dividir = (double) resposta1 / resposta2;

            Console.WriteLine("Soma = " + somar);

            Console.WriteLine("Subitração = " + sub);

            Console.WriteLine("Multiplicação = " + multi);

            Console.WriteLine("Divisão = " + dividir);
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string? line = Console.ReadLine();
                if (int.TryParse(line, out int value))
                    return value;
                Console.WriteLine("Digite apenas numero.");
            }
        }
    }
}
