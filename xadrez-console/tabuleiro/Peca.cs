namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Board Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Board tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
