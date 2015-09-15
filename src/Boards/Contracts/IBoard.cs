﻿namespace Minesweeper.Boards.Contracts
{
    public interface IBoard
    {
        char[,] Matrix
        {
            get;
            set;
        }

        void RevealCell(int x, int y);

        bool IsInsideBoard(int x, int y);

        bool IsMine(int x, int y);

        bool IsAlreadyShown(int x, int y);
    }
}
