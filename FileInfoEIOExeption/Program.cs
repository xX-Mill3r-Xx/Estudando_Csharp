using System;
using System.IO; // Importação para usar a classe File

namespace FileInfoEIOExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             File, FileInfo
            - Namespace System.IO;
            - Realiza operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStrem.

            File
                • static members (simples, mas realiza verificação de segurança para cada operação)
                • https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx

            FileInfo
                • instance members
                • https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx
             */

            /*
             IOException
                Namespace System.IO
                • IOException
                • DirectoryNotFoundException
                • DriveNotFoundException
                • EndOfStreamException
                • FileLoadException
                • FileNotFoundException
                • PathTooLongException
                • PipeException
             */

            //Demo
            #region File
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            try
            {
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion

            //Demo FileInfo
            #region FileInfo
            string sourcePath1 = @"c:\temp\file1.txt";
            string targetPath1 = @"c:\temp\file2.txt";
            try
            {
                FileInfo fileInfo1 = new FileInfo(sourcePath1);
                fileInfo1.CopyTo(targetPath1);
                string[] lines1 = File.ReadAllLines(sourcePath1);
                foreach (string line1 in lines1)
                {
                    Console.WriteLine(line1);
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
