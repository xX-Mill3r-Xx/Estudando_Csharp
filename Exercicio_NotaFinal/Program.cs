using System;
using System.Globalization;

namespace Exercicio_NotaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercicio Nota Final;

            fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestre de uma 
            diciplina anual. Em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto
            explicativo. Caso a nota final do aluno seja inferior a 60.00, mostrar a msg "REPROVADO". Todos os valores
            devem ter uma casa decimal;
             */

            //Minha solução;

            double nota1, nota2, notaFinal;
            Console.Write("Entre com o valor da nota #1: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor da nota #2: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = nota1 + nota2;
            Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F1", CultureInfo.InvariantCulture)}");

            if(notaFinal < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();
        }
    }
}
