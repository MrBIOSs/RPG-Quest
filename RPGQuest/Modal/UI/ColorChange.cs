
using System;

namespace RPGQuest.Modal
{
    internal class ColorChange
    {
        private ConsoleColor _defaultColorText = Console.ForegroundColor;
        //private ConsoleColor _defaultColorBackground = Console.BackgroundColor;

        public void Text(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = _defaultColorText;
        }

        //public void Background(ConsoleColor color)
        //{
        //    Console.BackgroundColor = color;

        //    Console.BackgroundColor = _defaultColorBackground;
        //}
    }
}
