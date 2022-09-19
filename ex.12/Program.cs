using System;

namespace ex._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[3];
            numero[0] = 10;
            numero[1] = 11;
            numero[2] = 12;
            Console.WriteLine("Números");
            Console.WriteLine();
            Console.WriteLine(numero[0]);
            Console.WriteLine(numero[1]);
            Console.WriteLine(numero[2]);

            int[] pares = new int[3];
            pares[0] = 2;
            pares[1] = 4;
            pares[2] = 6;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pares");
            Console.WriteLine();
            Console.WriteLine(pares[0]);
            Console.WriteLine(pares[1]);
            Console.WriteLine(pares[2]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Impares");
            Console.WriteLine();
            int[] impares = new int[3];
            impares[0] = 1;
            impares[1] = 3;
            impares[2] = 5;
            Console.WriteLine(impares[0]);
            Console.WriteLine(impares[1]);
            Console.WriteLine(impares[2]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nomes");
            Console.WriteLine();
            string[] nomes = new[] { "João", "Guilherme", "Thiago", "Lucas", "William" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            Console.WriteLine(nomes[3]);
            Console.WriteLine(nomes[4]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Times");
            Console.WriteLine();
            string[] times = new[] { "Corinthians", "Santos", "São Paulo", "Palmeiras", "Atletico Mineiro" };
            Console.WriteLine(times[0]);
            Console.WriteLine(times[1]);
            Console.WriteLine(times[2]);
            Console.WriteLine(times[3]);
            Console.WriteLine(times[4]);

        }
    }
}
