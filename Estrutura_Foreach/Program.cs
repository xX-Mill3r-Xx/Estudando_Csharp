using System;
using System.Globalization;

namespace Estrutura_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura repetitiva do-While, menos utilizada, mas em alguns casos se encaixa melhor ao problema.

            O bloco de comandos executa pelo menos uma vez, pois a condição é verificada no final;

            a sintaxe para se escrever a estrutura do-While é a seguinte;

            do{
                comandos;
            } while(condição)

            regra: Verdadeiro = volta; Falso = sai fora;

            exemplo com exercicio:
            Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em Fahrenheit. Perguntar se o usuario deseja repetir (s/n). Caso o usuario digite "s", repetir o programa;

            Formula: F = 9c/5 + 32;
             */

            double tempC, tempF;
            Inicio:
            Console.Write("Digite uma temperatura em C: ");
            tempC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            tempF = ((tempC * 9) / 5) + 32;
            Console.WriteLine($"A temperatura em F é: {tempF.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.Write("Deseja Repetir (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's')
            {
                goto Inicio;
            }
            else
            {
                Console.WriteLine("Fim do programa!");
            }

            Console.ReadLine();
        }
    }
}
