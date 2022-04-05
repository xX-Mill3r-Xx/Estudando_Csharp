using System;
using Tabuleiro;

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

            Posicao p = new Posicao(3, 4);
            Console.WriteLine($"Posição {p}");

            Console.ReadLine();
        }
    }
}
