using System;
using System.IO;

namespace Exercicio_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Problema exemplo
                Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome de usuário e o instante em que o usuário acessou o site no padrão ISO 8601, separados por espaço, conforme exemplo. Fazer um programa que leia o log de acessos a partir de um arquivo, e daí informe quantos usuários distintos acessaram o site.

            #####################################################################################################################

              Example

               Input file:
                amanda 2020-08-26T20:45:08
                alex86 2020-08-26T21:49:37
                bobbrown 2020-08-27T03:19:13
                amanda 2020-08-27T08:11:00
                jeniffer3 2020-08-27T09:19:24
                alex86 2020-08-27T22:39:52
                amanda 2020-08-28T07:42:19
               
               Execution:
                Enter file full path: c:\temp\in.txt
                Total users: 4

            #####################################################################################################################
             */

            #region Exercicio
            Console.Write("Enter file full pah: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

        }
    }
}
