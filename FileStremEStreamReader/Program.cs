using System;
using System.IO;

namespace FileStremEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             FileStream
                https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.90).aspx
                Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura
                e escrita.
                Suporte a dados binários.
                Instanciação:
                • Vários construtores
                • File / FileInfo
             */

            /*
             StreamReader
                https://msdn.microsoft.com/en-us/library/system.io.streamreader(v=vs.90).aspx
                É uma stream capaz de ler caracteres a partir de uma stream binária (ex: 
                FileStream).
                Suporte a dados no formato de texto.
                Instanciação:
                • Vários construtores
                • File / FileInfo
             */

            //Demo 1
            #region FileStream
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            #endregion

            //Demo2
            #region StreamReader
            string path1 = @"c:\temp\file1.txt";
            StreamReader sr1 = null;
            try
            {
                sr = File.OpenText(path1);
                while (!sr1.EndOfStream)
                {
                    string line1 = sr1.ReadLine();
                    Console.WriteLine(line1);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr1 != null) sr1.Close();
            }
            #endregion
        }
    }
}
