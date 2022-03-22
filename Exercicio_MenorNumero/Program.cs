using System;

namespace Exercicio_MenorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler tres numeros inteiros. Em seguida, mostrar qual o menor dentre os tres numeros lidos. Em caso de empate, mostrar apenas uma vez;
             */

            int a, b, c;
            Console.Write("Entre com os tres numeros inteiros: Obs.: Na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if(a < b && a < c)
            {
                Console.WriteLine($"Menor = {a}");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"Menor = {b}");
            }
            else
            {
                Console.WriteLine($"Menor = {c}");
            }

            Console.ReadLine();
        }
    }
}
