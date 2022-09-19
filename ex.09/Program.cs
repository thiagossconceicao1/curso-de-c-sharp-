using System;

namespace ex._09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa que leia quantos metros quadrados existe no ap
            //Se o apartamento for menor que 50m² o programa deve retornar: Apartamento Compacto
            //Caso seja Maior que 50m² o programa deve retornar: Apartamento Super Luxo

            Console.WriteLine("Digite o valor da largura do Apartamento: ");
            double largura = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor do comprimento do Apartamento: ");
            double comprimento = double.Parse(Console.ReadLine());


            double area = largura * comprimento;

            if (area <= 50)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    O Apartamento é de " + area + "m²");
                Console.WriteLine();
                Console.WriteLine("    Apartamento Compacto");
                Console.WriteLine();

            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    O Apartamento é de " + area + "m²");
                Console.WriteLine();
                Console.WriteLine("    Apartamento Super Luxo");
                Console.WriteLine();

            }
        }
    }
}
