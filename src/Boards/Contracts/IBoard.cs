﻿namespace Minesweeper.Boards.Contracts
{
    public interface IBoard
    {
        char[,] Matrix
        {
            get;
            set;
        }

        bool[,] Bombs
        {
            get;
        }

        int Rows
        {
            get;
        }

        int Cols
        {
            get;
        }

        int NumberOfMines
        {
            get;
        }

        void RevealCell(int x, int y);

        bool IsInsideBoard(int x, int y);

        bool IsMine(int x, int y);

        bool IsAlreadyShown(int x, int y);
    }
}
