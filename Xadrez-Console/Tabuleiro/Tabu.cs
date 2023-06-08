namespace Tabuleiro
{
    internal class Tabu
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabu (int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[ linhas, colunas ];
        }

    }
}
