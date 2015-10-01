﻿namespace Minesweeper.Logic.Common
{
    using static System.Console;

    public static class GlobalConstants
    {
        public static readonly int ConsoleHeight = 36;
        public static readonly int ConsoleWidth = 121;

        public const char CommandParametersDivider = ' ';

        public const int MatrixRowsDimensionIndex = 0;
        public const int MatrixColsDimensionIndex = 1;

        public const string ColsRenderingDivider = "*  ";
        public const string GameCellsDivider = "  ";

        public const int BeginnerLevelNumberOfBoardRows = 9;
        public const int BeginnerLevelNumberOfBoardCols = 9;
        public const int BeginnerLevelNumberOfBoardBombs = 10;

        public const int IntermediateLevelNumberOfBoardRows = 16;
        public const int IntermediateLevelNumberOfBoardCols = 16;
        public const int IntermediateLevelNumberOfBoardBombs = 40;

        public const int ExpertLevelNumberOfBoardRows = 20;
        public const int ExpertLevelNumberOfBoardCols = 24;
        public const int ExpertLevelNumberOfBoardBombs = 99;

        public const char StandardUnrevealedBoardCellCharacter = '■';

        public const int BoardStartRenderRow = 3;
        public const int BoardStartRenderCol = 1;

        public const int LeftSidebarWidth = 3;
        public const int TopBarColsOffset = 2;
        public const int TopBarSeparatorsOffset = 1;

        private static readonly string ScoreboardBasePath = System.Reflection.Assembly
            .GetExecutingAssembly().Location;

        public static readonly string ScoreboardFilePath = ScoreboardBasePath.Substring(0, ScoreboardBasePath.IndexOf("Minesweeper.UI.Console")) + "Minesweeper.Logic\\Data\\leaders.msr";

        public const string SelectionChar = ">";
        public const string SelectionPrefix = "   ";

        public const string MenuTitleAsString = "SELECT DIFFICULTY";
        public static readonly string[] MenuTitle = new string[]
        {
            new string('=', (ConsoleWidth - 1) / 2 + 1),
            new string(' ', ((ConsoleWidth - 1) / 2 + 1 - MenuTitleAsString.Length) / 2) + MenuTitleAsString + new string(' ', ((ConsoleWidth - 1) / 2 + 1 - MenuTitleAsString.Length) / 2),
            new string('=', (ConsoleWidth - 1) / 2 + 1)
        };

        public static readonly int MenuTitleRowsCount = MenuTitle.Length;

        public const string GameTitleAsString = "Minesweeper";
        public static readonly string[] GameTitle = new string[]
        {
            new string('=', ConsoleWidth),
            new string(' ', (ConsoleWidth - GameTitleAsString.Length) / 2) + GameTitleAsString + new string(' ', (ConsoleWidth - GameTitleAsString.Length) / 2),
            new string('=', ConsoleWidth)
        };
    }
}
