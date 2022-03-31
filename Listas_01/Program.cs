using System;
using System.Collections.Generic;

namespace Listas_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Checklist
                • Conceito de lista
                • Tipo List - Declaração, instanciação
                • Referência: https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx
                • Assuntos pendentes: 
                • generics
                • predicados (lambda)
             */

            /*
             Listas
                • Lista é uma estrutura de dados:
                • Homogênea (dados do mesmo tipo)
                • Ordenada (elementos acessados por meio de posições)
                • Inicia vazia, e seus elementos são alocados sob demanda
                • Cada elemento ocupa um "nó" (ou nodo) da lista
                • Classe: List
                • Namespace: System.Collections.Generic
                • Vantagens: 
                • Tamanho variável
                • Facilidade para se realizar inserções e deleções
                • Desvantagens:
                • Acesso sequencial aos elementos *
             */

            //Instanciação de uma lista
            List<string> list = new List<string>();

            //Forma para instanciar e ja inserir valores;
            List<string> list2 = new List<string> { "teste1", "teste2" };
        }
    }
}
