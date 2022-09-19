using System;
using System.Globalization;

namespace Ex._05
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("=======================================");
            Console.WriteLine("============= Mercado Tricolor ========");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Insira o nome do Comprador: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite se CPF: ");
            double cpf = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto foi a bolacha? ");
            double ValorBolacha = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto você deu de dinheiro?");
            double DinheiroDado = double.Parse(Console.ReadLine());


            double Troco = DinheiroDado - ValorBolacha;

            Console.Clear();

          
            Console.WriteLine("=======================================");
            Console.WriteLine("============= Mercado tricolor=========");
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine("============= Nota Fiscal =============");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Comprador: " + Nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine();
            Console.WriteLine("Bolacha Passatempo: " + "R$" + ValorBolacha);
            Console.WriteLine("Valor pago: " + "R$" + DinheiroDado);
            Console.WriteLine("Troco: " + "R$ " + Troco);

        }
    }
}

