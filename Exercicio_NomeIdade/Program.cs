using System;
using System.Globalization;

namespace Exercicio_NomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercicio Nome Idade;
            Enunciado:

            Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
            Ao final, mostrar uma mensagem com os nomes e a idade média entre essas pessoas,
            com uma casa decimal.
             */

            //Leitura dos dados;

            #region Uma das formas que encontrei para resolver o problema
            //Console.Write("Entre com o nome da primeira pessoa: ");
            //string nome1 = Console.ReadLine();
            //Console.Write($"Entre com a idade de {nome1} aqui: ");
            //int idade1 = int.Parse(Console.ReadLine());

            //Console.Write("Entre com o nome da segunda pessoa: ");
            //string nome2 = Console.ReadLine();
            //Console.Write($"Entre com a idade de {nome2} aqui: ");
            //int idade2 = int.Parse(Console.ReadLine());
            #endregion

            #region Forma mais correta
            string nome1, nome2;
            int idade1, idade2;

            string[] vet; //Declarar um vetor para armazenar nome e idade na mesma linha;
            Console.Write("Entre com os dados da primeira pessoa na mesma linha: ");
            vet = Console.ReadLine().Split(' '); //usar o .Split(' ') para separar os espaços entre nome e idade;
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            Console.Write("Entre com os dados da segunda pessoa na mesma linha: ");
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);
            #endregion

            double media = (idade1 + idade2) / 2.0;

            //Saida;
            Console.WriteLine($"A idade média de {nome1} e {nome2} é de {media.ToString("F1", CultureInfo.InvariantCulture)} anos");
            Console.ReadLine();
        }
    }
}
