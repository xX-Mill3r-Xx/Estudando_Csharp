using System;
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

            #region Sem uso no momento
            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            //Console.WriteLine(pos);

            //Console.WriteLine(pos.toPosicao());
            #endregion

            try
            {
                #region Usando no momento
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
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
