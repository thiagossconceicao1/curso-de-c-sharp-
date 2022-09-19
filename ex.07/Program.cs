using System;
using System.Globalization;

namespace Ex._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());



            Console.WriteLine("Digite o valor do comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor do m²: ");
            double valorm2 = double.Parse(Console.ReadLine());


            double area = largura * comprimento;
            double valorTotal = area * valorm2;


            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("============= Resultado ===============");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Area do terreno é: " + area + " m²");
            Console.WriteLine("Valor do metro quadrado é: R$ " + valorm2 + " m²");
            Console.WriteLine("Valor á pagar: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
