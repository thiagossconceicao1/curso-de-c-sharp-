using System;
using System.Globalization;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 Fazer um programa para calcular o aumento de salário
de um funcionario x exibindo

- % de aumneto do salário
- Aumento em reais
- Salário Final
*/

            Console.WriteLine("======================================");
            Console.WriteLine("=== Programa de aumento de salário ===");
            Console.WriteLine("======================================");

            Console.WriteLine("Insira o nome do funcionário: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual % de aumento deseja para o funcionário " + Nome + "?");
            double perc = double.Parse(Console.ReadLine());

            double percemdecimal = perc / 100;


            double SalárioFinal = SalarioInicial + SalarioInicial * percemdecimal;


            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("=========== Resultado Final ==========");
            Console.WriteLine("======================================");

            Console.WriteLine("Salário Inicial: " + SalarioInicial);
            Console.WriteLine("Percentual de aumento: " + perc + "%");
            Console.WriteLine("Total de aumento" + "R$ " + SalarioInicial * percemdecimal);
            Console.WriteLine("Salário Final: " + "R$ " + SalárioFinal.ToString("F2",
                CultureInfo.InvariantCulture));
        }
    }
}

