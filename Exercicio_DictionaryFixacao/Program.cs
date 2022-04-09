using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio_DictionaryFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Na contagem de votos de uma eleição, são gerados vários registrosde votação contendo o nome do candidato quantidade de votos (formato .csv) que ele obteve em uma urna de votação. Você deve fazer um programa para ler os registros de votação a partir de um arquivo, e daí gerar um relatório consolidado com os totais de cada candidato.
             */

            #region Exercicio
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}
