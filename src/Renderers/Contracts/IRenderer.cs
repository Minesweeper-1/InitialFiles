﻿namespace Minesweeper.Renderers.Contracts
{
    using Boards.Contracts;

    public interface IRenderer
    {
        void Render(string line);

        void RenderLine(string line);

        void RenderBoard(IBoard board, int row, int col);

        void RenderWelcomeScreen(string welcomeScreen);

        void SetCursorPosition(int row, int col);

        void Clear();

        void ClearCurrentConsoleLine();
    }
}
