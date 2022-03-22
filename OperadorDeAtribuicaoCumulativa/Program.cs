using System;
using System.Globalization;

namespace OperadorDeAtribuicaoCumulativa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Uma operadora de telefonia cobra R$ 50.00 por um plano basico que
            da direito a 100 mim de telefone. Cada min que excede a franquia de 100 mim custa R$ 2.00
            Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, dai mostrar o valor
            a ser pago;
             */

            int minutos;
            double conta;

            Console.Write("Entre com os minutos gastos: ");
            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;

            if(minutos > 100)
            {
                /* O operador de atribuição cumulativa += é o mesmo que 
                 escrever a variavel = variavel + (um atributo)  */
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine($"Valor a ser pago: R$ {conta.ToString("F2", CultureInfo.InvariantCulture)}");

            /*
             obs.: Os operadores de atribuição cumulativa pode ser atribuidos a todas as operaçoes basicas;
             */

            Console.ReadLine();
        }
    }
}
