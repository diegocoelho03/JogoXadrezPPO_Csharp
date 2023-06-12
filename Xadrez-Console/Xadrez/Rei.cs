using Tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
        private PartidaDeXadrez partida;

       public Rei(Tabu tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor) 
        { 
            this.partida = partida; 
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

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qtdMovimentos == 0;
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

            // #JogadaEspecial roque
            if (qtdMovimentos == 0 && !partida.xeque)
            {
                // #JogadaEspecial roque pequeno
                Posicao posT1 = new Posicao(posicao.linha, posicao.coluna + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if(tab.peca(p1) == null && tab.peca(p2) == null)
                    {
                        mat[posicao.linha, posicao.coluna + 2] = true;
                    }
                }

                // #JogadaEspecial roque grande
                Posicao posT2 = new Posicao(posicao.linha, posicao.coluna - 4);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao p3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                    {
                        mat[posicao.linha, posicao.coluna - 2] = true;
                    }
                }
            }



            return mat;


        }


    }
}
