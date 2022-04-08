using System;
using Entities;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  GetHashCode e Equals
             *  
                • São operações da classe Object utilizadas para comparar se um objeto é igual a outro
                • Equals: lento, resposta 100%
                • GetHashCode: rápido, porém resposta positiva não é 100%
                • Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs personalizados precisam sobrepô-las.*/

            /*
               Equals
                Método que compara se o objeto é igual a outro, retornando true ou false.
             */

            #region Exemplo Equals
            //Console.Write("Entre com um nome para A: ");
            //string a = Console.ReadLine();
            //Console.Write("Entre com um nome para B: ");
            //string b = Console.ReadLine();
            //Console.WriteLine($"A comparação de A e B é: {a.Equals(b)}");
            #endregion

            //Console.ReadLine();

            /*
              GetHashCode
               Método que retorna um número inteiro representando um código gerado a partir das informações do objeto
             */

            #region Exemplo GetHashCode
            Console.Write("Entre com um nome para 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Entre com um Email para 1: ");
            string email1 = Console.ReadLine();

            Console.Write("Entre com um nome para 2: ");
            string name2 = Console.ReadLine();
            Console.Write("Entre com um Email para 2: ");
            string email2 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Se o numero GetHashCode for igual, siguinifica que o valor digitado é igual");
            #endregion

            Console.ReadLine();

            /*
             Regra de ouro do GetHashCode
              • Se o código de dois objetos for diferente, então os dois objetos são diferentes
              • Se o código de dois objetos for igual, muito provavelmente os objetos são iguais (pode haver colisão)
             */

            #region Programa Comparando Emails
            Client A = new Client(name1, email1);
            Client B = new Client(name2, email2);

            if(A.Email == B.Email)
            {
                Console.WriteLine($"{A.Equals(B)}, {A.Email} é igual {B.Email}");
                Console.WriteLine($"A: {A.GetHashCode()}, B: {B.GetHashCode()}");
            }
            else
            {
                Console.WriteLine($"{A.Equals(B)}, {A.Email} não é igual {B.Email}");
                Console.WriteLine($"A: {A.GetHashCode()}, B: {B.GetHashCode()}");
            }
            #endregion

        }
    }
}
