using System;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Garbage collector
                • É um processo que automatiza o gerenciamento de memória de um
                programa em execução
                • O garbage collector monitora os objetos alocados dinamicamente
                pelo programa (no heap), desalocando aqueles que não estão mais
                sendo utilizados.

            Desalocação por escopo

            void method1() {
                int x = 10;
                if (x > 0) {
                  int y = 20;
                }
                  Console.WriteLine(x);
              }

            Resumo
                • Objetos alocados dinamicamente, quando não possuem mais
                referência para eles, serão desalocados pelo garbage collector
                • Variáveis locais são desalocadas imediatamente assim que seu escopo
                local sai de execução
             */
        }
    }
}
