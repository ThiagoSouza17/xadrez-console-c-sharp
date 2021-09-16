namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Board Tab { get; protected set; }

        public Peca(Board tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public void incrementarMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
   
    }
}
