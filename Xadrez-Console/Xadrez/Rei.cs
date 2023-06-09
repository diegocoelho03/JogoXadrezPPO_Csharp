using Tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
       public Rei(Tabu tab, Cor cor) : base(tab, cor) 
        { 
        }


        public override string ToString()
        {
            return "R";
        }

        private bool PoderMover (Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }


        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            // Acima
            pos.DefinirValores(posicao.linha - 1, posicao.coluna);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // NE
            pos.DefinirValores(posicao.linha - 1, posicao.coluna +1);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Direita
            pos.DefinirValores(posicao.linha, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // SE
            pos.DefinirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Abaixo
            pos.DefinirValores(posicao.linha + 1, posicao.coluna);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // SO
            pos.DefinirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Esquerda
            pos.DefinirValores(posicao.linha, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // NO
            pos.DefinirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PoderMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;


        }


    }
}
