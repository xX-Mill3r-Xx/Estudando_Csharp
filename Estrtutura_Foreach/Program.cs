using System;

namespace Estrtutura_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Estrutura Foreach
             O foreach se aplica para coleçoes. É utilizado quando precisa-se percorrer todos os elemantos de uma
            coleção.
             */

            /*
             Fazer um programa para ler um valor N e depois o nome de N pessoas. Em seguida, mostrar os nomes lidos;
             */

            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];

            for(int i = 0; i < N; i++)
            {
                Console.Write("Entre com o nome da pessoa: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes Lidos");
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
