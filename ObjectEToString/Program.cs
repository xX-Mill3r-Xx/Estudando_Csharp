using System;

namespace ObjectEToString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Uma das formas de escrever dados na tela de uma forma automatica e ja pré definida, uma das alternativas
            seria usar o ToString()

             - Toda classe em C# é uma subClasse de Object;

             Object possui os seguintes métodos:
             - GetType - retorna o tipo do objeto;
             - Equals - compara se o objeto é igual a outro;
             - GetHashCode - retorna um codigo hash do objeto;
             - ToString - converte o objeto para string;
             */

            Teste t = new Teste();

            Console.WriteLine(t);

            Console.ReadLine();
        }
    }
}
