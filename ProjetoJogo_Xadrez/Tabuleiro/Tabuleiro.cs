
namespace tabuleiro
{
    class Tabuleiro
    {
        //Atributos
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        /*--------------------------------------------------------------------------------------------------------*/
        //Construtor
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        /*--------------------------------------------------------------------------------------------------------*/
        //Peça
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //Peça(Sobrecarga)
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        /*--------------------------------------------------------------------------------------------------------*/
        //Existe Peça?
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        /*--------------------------------------------------------------------------------------------------------*/
        //Colocar Peça
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroExeption("Já existe uma peça nesta posição!");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        /*--------------------------------------------------------------------------------------------------------*/
        //Posição Valida
        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna<0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        /*--------------------------------------------------------------------------------------------------------*/
        //Validar Posição
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroExeption("Posição Invalida!");
            }
        }
    }
}
