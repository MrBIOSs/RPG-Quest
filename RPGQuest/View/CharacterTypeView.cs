
using RPGQuest.Modal;
using System;

namespace RPGQuest.View
{
    internal class CharacterTypeView
    {
        public void ShowList(ColorChange colorChange, string[] names)
        {
            ConsoleColor defaultColorText = Console.ForegroundColor;
            Console.ForegroundColor = colorChange.Menu;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }

            Console.ForegroundColor = defaultColorText;
        }
    }
}
