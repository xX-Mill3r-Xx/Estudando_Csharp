using System;

namespace Exercicio_Uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercicio Uri Online Judge 1019

             leia um valor inteiro que é o tempo de duração em segundos de um determinado evento em uma fabrica,
            e informe-o expresso no formato horas:minutos:segundos;
             */
            Console.Write("Entre com o valor em segundos: ");
            int N = int.Parse(Console.ReadLine());

            int horas = N / 3600;
            int resto = N % 3600;

            int minutos = resto / 60;
            int segundos = resto % 60;


            Console.WriteLine($"O valor digitado corresponde a: {horas}:{minutos}:{segundos}");
            Console.ReadLine();
        }
    }
}
