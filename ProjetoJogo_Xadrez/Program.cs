using System;
using tabuleiro;

namespace ProjetoJogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Este sistema ira utilizar de um sistema de camadas.
                Serão tres camadas basicas;
                - 1° sera o tabuleiro;
                - 2° sera a inteligencia do jogo
                - 3° sera a camada de aplicação
            */


            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine($"{tab}");
            Console.ReadLine();
        }
    }
}
