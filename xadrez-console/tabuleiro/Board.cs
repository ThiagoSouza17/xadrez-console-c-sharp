namespace Tabuleiro
{
    class Board
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Board (int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }
    }
}
