﻿using System;
using Exercicio_Fixacao.Entities;
using System.Globalization;
using System.IO;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler o caminho de um arquivo .csv
                contendo os dados de itens vendidos. Cada item possui um
                nome, preço unitário e quantidade, separados por vírgula. Você
                deve gerar um novo arquivo chamado "summary.csv", localizado
                em uma subpasta chamada "out" a partir da pasta original do
                arquivo de origem, contendo apenas o nome e o valor total para
                aquele item (preço unitário multiplicado pela quantidade),
                conforme exemplo.
             */

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto prod = new Produto(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
