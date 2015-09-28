﻿namespace MenuTest.Renderers.Common
{
    public class RenderersConstants
    {
        public const string SelectionChar = ">";
        public const string SelectionPrefix = "   ";
        public static readonly string[] MenuTitle = new string[]
        {
            "===============================",
            "       SELECT DIFFICULTY       ",
            "==============================="
        };

        public static readonly int MenuTitleRowsCount = MenuTitle.Length;
    }
}
