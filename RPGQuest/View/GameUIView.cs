

using System;

namespace RPGQuest.View
{
    internal class GameUIView : DisplayTextView
    {
        private void BorderInterface()
        {
            Print("\n** " + new string ('-', 25) + " **");
        }

        public void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            int _minHealth = 1;
            string _bar = "";

            for (int i = 0; i < value; i++)
            {
                _bar += " ";
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
    
            Console.Write(_bar);
            

            _bar = "";

            for (int i = value; i < maxValue; i++)
            {
                _bar += " ";
            }

            Console.Write(_bar + ']');
        }

        //char[] _bag = new char[1];
        // Console.Write("Сумка: ");
        //    for (int i = 0; i < _bag.Length; i++)
        //    {
        //        Console.Write(_bag[i] + " ");
        //    }

        //char[] _tempBag = new char[_bag.Length + 1];

        //        for (int i = 0; i < _bag.Length; i++)
        //        {
        //            _tempBag[i] = _bag[i];
        //        }

        //        _tempBag[_tempBag.Length - 1] = 'X';
        //        _bag = _tempBag;
    }
}
