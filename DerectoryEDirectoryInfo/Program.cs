using System;
using System.IO;

namespace DerectoryEDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Directory, DirectoryInfo
                • Namespace System.IO
                • Operações com pastas (create, enumerate, get files, etc.).
                • Directory
                • static members (simple, but performs security check for each operation)
                • https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
                • DirectoryInfo
                • instance members
                • https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx
             */

            /*
             Demo
                • Vamos listar as pastas a partir de uma pasta informada
                • Vamos listar os arquivos a partir de uma pasta informada
                • Vamos criar uma pasta
             */

            //Demo
            #region Directory
            string path = @"c:\temp\myfolder";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
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
