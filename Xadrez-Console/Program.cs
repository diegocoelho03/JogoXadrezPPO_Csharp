using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosicao());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}