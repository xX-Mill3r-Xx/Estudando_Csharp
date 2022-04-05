﻿using System;
using tabuleiro;
using Xadrez;

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

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            try
            {
                #region Sem uso no momento
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                //tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                //Tela.ImprimirTabuleiro(tab);
                #endregion

                Console.WriteLine($"");
            }
            catch(TabuleiroExeption e) 
            {
                Console.WriteLine(e.Message);
            }

            
            Console.ReadLine();
        }
    }
}
