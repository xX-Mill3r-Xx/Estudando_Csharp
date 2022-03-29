using System;

namespace Tipos_Referencia_Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Classes são tipos referencias;
            Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim 
            “tentáculos” (ponteiros) para caixas

            Valor "null"
            Tipos referência aceitam o valor "null", que indica que a variável aponta pra ninguém.

            Structs são tipos valor
            A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e 
            não ponteiros. 

            É possível criar seus próprios structs
            namespace Course 
            {
                    struct Point 
                    {
                      public double X, Y;
                        public override string ToString() 
                        {
                               return "(" + X + "," + Y + ")";
                        }
                     }
             }
             */

            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            Console.ReadLine();

            /*
             Valores padrão
                • Quando alocamos (new) qualquer tipo estruturado (classe, struct,
                array), são atribuídos valores padrão aos seus elementos
                • números: 0
                • bool: False
                • char: caractere código 0
                • objeto: null
                • Lembrando: uma variável apenas declarada, mas não instanciada,
                inicia em estado "não atribuída", e o próprio compilador não permite
                que ela seja acessada.
             */
        }
    }
}
