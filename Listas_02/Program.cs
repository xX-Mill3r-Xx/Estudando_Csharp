using System;
using System.Collections.Generic;

namespace Listas_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Demo
                • Inserir elemento na lista: Add, Insert
                • Tamanho da lista: Count
                • Encontrar primeiro ou último elementos da lista que satisfaça um predicado: 
                list.Find, list.FindLast
                • Encontrar primeira ou última posição de elemento da lista que satisfaça um 
                predicado: list.FindIndex, list.FindLastIndex
                • Filtrar a lista com base em um predicado: list.FindAll
                • Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange
                • Assuntos pendentes:
                • Generics
                • Predicados (lambda)
             */

            List<string> list = new List<string>();

            //Para add elementos na lista;
            list.Add("Alex");
            list.Add("Maria");

            //Para inserir um elemento em uma determinada posição;
            list.Insert(0,"João");

            //Para mostrar o tamanho da lista;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"O tamanho da lista é de {list.Count} elementos");

            /*Encontrar primeiro ou último elementos da lista que satisfaça um predicado: 
                list.Find, list.FindLast*/
            Console.WriteLine("-----------------------------------");
            string s1 = list.Find(x => x[0] == 'A' /*Expressão Lambda*/);
            Console.WriteLine($"First 'A': {s1}");
            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine($"Last 'M': {s2}");

            /*Encontrar primeira ou última posição de elemento da lista que satisfaça um 
              predicado: list.FindIndex, list.FindLastIndex*/
            Console.WriteLine("-----------------------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Firt position 'A': {pos1}");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            /*Filtrar a lista com base em um predicado: list.FindAll*/
            List<string> list2 = list.FindAll(x => x.Length == 5);

            /*Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange*/
            list.Remove("Alex");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------");
            foreach (string obj2 in list2)
            {
                Console.WriteLine(obj2);
            }
        }
    }
}
