using System;

namespace ex._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um programa que leia um numero e retorne se é positivo ou negativo

            Console.WriteLine("Me diga um número");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    Você escolheu o número " + n);
                Console.WriteLine();
                Console.WriteLine("    Seu número é NEGATIVO");
                Console.WriteLine();


            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    Você escolheu o número " + n);
                Console.WriteLine();
                Console.WriteLine("    Seu número é POSITIVO");
                Console.WriteLine();

            }
            if (n == 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    Você escolheu o número " + n);
                Console.WriteLine();
                Console.WriteLine("    Seu número é NEUTRO");
                Console.WriteLine();


            }
        }
    }
}
