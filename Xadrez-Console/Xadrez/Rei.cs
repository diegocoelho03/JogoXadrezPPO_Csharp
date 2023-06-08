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
    }
}
