
using System;

namespace RPGQuest.Modal
{
    internal class ColorChange
    {
        private ConsoleColor _defaultColorText = Console.ForegroundColor;
        private ConsoleColor _defaultColorBackground = Console.BackgroundColor;

        public readonly ConsoleColor Title = ConsoleColor.Yellow;
        public readonly ConsoleColor Menu = ConsoleColor.White;
        public readonly ConsoleColor Error = ConsoleColor.Red;

        public void Text(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = _defaultColorText;
        }

        public void Background(ConsoleColor color, string space)
        {
            Console.BackgroundColor = color;
            Console.Write(space);
            Console.BackgroundColor = _defaultColorBackground;
        }
    }
}
