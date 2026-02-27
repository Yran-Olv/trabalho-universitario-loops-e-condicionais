namespace Atividade13

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação ( +, -, * , / ) ");
            char op = char.Parse(Console.ReadLine());


			if (op == '+')
            {
                double soma = n1 + n2;
                Console.WriteLine("Soma = " + soma);
            }
            else if (op == '-')
            {
                double subtracao = n1 - n2;
                Console.WriteLine("Subtração = " + subtracao);
            }
            else if (op == '*')
            {
                double multiplicacao = n1 * n2;
                Console.WriteLine("Multiplicação = " + multiplicacao);
            }
            else if (op == '/')
            {
                double divisao = n1 / n2;
                Console.WriteLine("Divisão = " + divisao);
               
            }
            else
            {
                Console.WriteLine("Operação inválida");
			}

			
		}
    }
}
