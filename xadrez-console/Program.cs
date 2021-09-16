using System;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board tab = new Board(8, 8);
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
