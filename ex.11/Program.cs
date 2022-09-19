using System;

namespace ex._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que calcule a soma de duas notas e apresente a media final

            string nome;
            double nota1, nota2, media;

            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());


            media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.Clear();
                Console.WriteLine("O aluno " + nome + " obteve a média: " + media);
                Console.WriteLine("O aluno " + nome + " foi APROVADO");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("O aluno " + nome + " obteve a média: " + media);
                Console.WriteLine("O aluno " + nome + " foi REPROVADO");
            }
        }
    }
}
