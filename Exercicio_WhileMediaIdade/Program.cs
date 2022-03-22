using System;
using System.Globalization;

namespace Exercicio_WhileMediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um numero indeterminado de dados, contendo cada um, a idade de um individuo.
            O ultimo dado, que não entrará nos calculos, contem um valor de idade negativa. Calcular e imprimir a 
            idade media deste grupo de individuos. Se for entrado um valor negativo na primeira vez, mostrar a msg
            "Impossivel calcular";
             */
            Console.Write("Entre com a idade de um individuo: ");
            double idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double soma = 0.0;
            int cont = 0;
            while(idade >= 0)
            {
                soma += idade;
                cont += 1;
                Console.Write("Entre com a idade de um individuo: ");
                idade = int.Parse(Console.ReadLine());
            }
            if(cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
