namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabu tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabu tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }
    }
}
