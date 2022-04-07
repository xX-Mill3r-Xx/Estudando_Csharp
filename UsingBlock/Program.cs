using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             using block
                https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
                Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
                Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser 
                manualmente fechados.
                Exemplos: Font, FileStream, StreamReader, StreamWriter
             */

            //Demo1
            #region Demo1
            string path = @"c:\temp\file1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion

            //Demo2
            #region Demo2
            string path1 = @"c:\temp\file1.txt";
            try
            {
                using (StreamReader sr1 = File.OpenText(path1))
                {
                    while (!sr1.EndOfStream)
                    {
                        string line1 = sr1.ReadLine();
                        Console.WriteLine(line1);
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
