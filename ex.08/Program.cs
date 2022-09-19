using System;

namespace ex._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)

                Console.WriteLine("Maior de idade");


            else

                Console.Clear();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxx Bloqueio xxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxx Menor de idade xxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
    }
}
