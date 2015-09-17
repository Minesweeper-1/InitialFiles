﻿namespace Minesweeper.Engine
{
    using Boards.Contracts;
    using Common;
    using Contracts;
    using InputProviders.Contracts;
    using Renderers.Contracts;

    public class StandardOnePlayerMinesweeperEngine : IMinesweeperEngine
    {
        public StandardOnePlayerMinesweeperEngine(IBoard board, IRenderer renderer, IInputProvider inputProvider)
        {
            this.Board = board;
            this.Renderer = renderer;
            this.InputProvider = inputProvider;
        }

        public IBoard Board { get; set; }

        public IRenderer Renderer { get; set; }

        public IInputProvider InputProvider { get; set; }

        public void Initialize(IGameInitializationStrategy initializationStrategy)
        {
            initializationStrategy.Initialize(this.Board);
            string welcomeLine = "Welcome to the all-time classic Minesweeper. Use your mind to tackle the mines.";
            this.Renderer.RenderLine(welcomeLine);
            this.Renderer.RenderMatrix(this.Board.Matrix);
        }

        public void Run()
        {
            while (true)
            {
                string command = this.InputProvider.Read();
                bool? commandResult = this.ExecuteCommand(command);

                if (commandResult == null)
                {
                    return;
                }
                else if (commandResult == false)
                {
                    continue;
                }
                else if (commandResult == true)
                {
                    this.Renderer.RenderMatrix(this.Board.Matrix);
                }
            }
        }

        private bool? ExecuteCommand(string command)
        {
            string commandToLowerCase = command.ToLower();
            switch (commandToLowerCase)
            {
                case "exit":
                    HandleEndGameCommand();
                    return null;
                case "top":
                    HandleShowTopScoresCommand();
                    return false;
                case "restart":
                    HandleRestartCommand();
                    return true;
                default:
                    {
                        bool? result = HandlePlayCommand(commandToLowerCase);
                        return result;
                    }
            }
        }

        private bool? HandlePlayCommand(string command)
        {
            string trimmedCommand = command.Trim();
            string[] commandComponents = trimmedCommand.Split(GlobalConstants.CommandParametersDivider);
            if (commandComponents.Length < 2 || commandComponents.Length > 2)
            {
                this.Renderer.RenderLine(GlobalMessages.InvalidCommand);
                return false;
            }

            int x, y;
            bool xIsNumeric = int.TryParse(commandComponents[0], out x);
            bool yIsNumeric = int.TryParse(commandComponents[1], out y);

            if(!(xIsNumeric && yIsNumeric))
            {
                this.Renderer.RenderLine(GlobalMessages.InvalidCommand);
                return false;
            }

            if (!this.Board.IsInsideBoard(x, y))
            {
                this.Renderer.Render(GlobalMessages.OutOfBorders);
            }
            else if (this.Board.IsAlreadyShown(x, y))
            {
                this.Renderer.Render(GlobalMessages.CellAlreadyRevealed);
            }

            else if (this.Board.IsMine(x, y))
            {
                this.Renderer.RenderLine(GlobalMessages.GameOver);
                return null;
            }

            else
            {
                this.Board.RevealCell(x, y);
                this.Renderer.Clear();
            }

            return true;
        }

        private void HandleRestartCommand()
        {

        }

        private void HandleShowTopScoresCommand()
        {

        }

        private bool? HandleEndGameCommand()
        {
            return null;
        }
    }
}
