using System;
using Enum_enumeracoes.Entities;
using Enum_enumeracoes.Entities.Enums;

namespace Enum_enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Checklist
                • Definição / discussão
                • Exemplo: estados de um pedido
                • Conversão de string para enum
                • Representação UML
            */

            /*Enumerações
                • É um tipo especial que serve para especificar de forma literal um conjunto 
                de constantes relacionadas
                • Palavra chave em C#: enum
                • Nota: enum é um tipo valor
                • Vantagem: melhor semântica, código mais legível e auxiliado pelo 
                compilador
                • Referência: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum
            */

            Order order = new Order()
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStaus.PendingPayment

            };

            Console.WriteLine(order);

            //Conversoes

            /*Para o tipo original: use casting*/
            //OrderStaus os1 = (OrderStaus)2;
            //int n1 = (int)OrderStaus.Processing;

            //String - enum:
            string txt = OrderStaus.PendingPayment.ToString();
            OrderStaus os = Enum.Parse<OrderStaus>("Delivered");
            //Console.WriteLine(os1);
            Console.WriteLine(os);
            Console.WriteLine(txt);

            Console.ReadKey();
        }
    }
}
