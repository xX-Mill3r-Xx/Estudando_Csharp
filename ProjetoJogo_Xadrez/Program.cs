using System;
using tabuleiro;
using Xadrez;

namespace ProjetoJogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            /*
             Este sistema ira utilizar de um sistema de camadas.
                Serão tres camadas basicas;
                - 1° sera o tabuleiro;
                - 2° sera a inteligencia do jogo
                - 3° sera a camada de aplicação
            */
            #endregion

            try
            {
                #region Usando no momento
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.WriteLine($"{partida.jogadorAtual} Jogando!");
                        Console.WriteLine($"-----------------");

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroExeption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);

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
