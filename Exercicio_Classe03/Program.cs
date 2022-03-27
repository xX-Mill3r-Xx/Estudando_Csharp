using System;
using System.Globalization;

namespace Exercicio_Classe03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler o nome de um aluno e as tres notas que ele obteve nos tres trimestres
            do ano (primeiro trimestre vale 30 e os demais 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer tambem se o aluno esta APROVADO ou REPROVADO e em caso negativo, quantos pontos faltam para o aluno
            obter o minimo para ser aprovado (60 pontos). Voce deve criar uma classe Aluno para este problema.
             */

            Aluno a = new Aluno();
            double nota1, nota2, nota3;

            Console.Write("Nome do aluno: ");
            a.Name = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = a.NotaFinal(nota1, nota2, nota3);
            Console.WriteLine($"Nota final: {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");

            if (notaFinal < 60.0)
            {
                double rest = 60 - notaFinal;
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltam {rest.ToString("F2", CultureInfo.InvariantCulture)} pontos");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }

            Console.ReadLine();

        }
    }
}
