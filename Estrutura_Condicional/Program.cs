using System;

namespace Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura condicional é uma estrutura de controle que permite definir que um certo bloco de comandos somente
            será executado dependendo de uma condição;
             */

            //Sintaxe da estrutura condicional simples;
            /*           
            if (condição)
            {
                 comandos caso a condição seja verdadeira;
            }
            */

            //exemplo:

            Console.Write("Entre com um valor que corresponde a um Horario: ");
            int hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Bom dia");
            if (hora < 0)
            {
                //este bloco só sera executado se a condição for verdadeira;
                Console.WriteLine("Boa tarde");
            }
            Console.WriteLine("Boa noite");

            //Sintaxe de uma estrutura condicional composta;

            /*
              
              if (condição)
              {
                  comandos caso a condição seja verdadeira;
              }
              else
              {
                  comandos caso a condição seja falsa;
              }

            */

            //Exemplo:
            Console.Write("Que horas são? ");
            int horas = int.Parse(Console.ReadLine());
            if(horas < 12)
            {
                Console.WriteLine("Bom Dia");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("Boa Tarde");
                }
                else
                {
                    Console.WriteLine("Boa Noite");
                }
            }

            Console.ReadLine();
        }
    }
}
