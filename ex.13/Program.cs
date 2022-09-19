using System;

namespace ex._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("=== Programa de aumento de salário ===");
            Console.WriteLine("======================================");

            Console.WriteLine("Insira o nome do funcionário: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual % de aumento deseja para o funcionário " + Nome + "?");
        }
    }
}
