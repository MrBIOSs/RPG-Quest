
using System;

namespace RPGQuest.View
{
    internal class DisplayTextView
    {
        protected void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void InputMessage()
        {
            Console.Write("\nВвод действия: ");
        }
    }
}
