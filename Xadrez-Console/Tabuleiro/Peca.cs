using System.Runtime.Intrinsics.Arm;

namespace Tabuleiro
{
    internal abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabu tab { get; protected set; }

        public Peca(Tabu tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            qtdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis(); 
    }
}
