
using RPGQuest.Modal;
using RPGQuest.Modal.Unit;
using System;

namespace RPGQuest.View
{
    internal class СharacterСreationView : DisplayTextView
    {
        private ColorChange _colorChange = new ColorChange();

        public void ShowRaces(Races races)
        {
            Console.Clear();

            _colorChange.Text(_colorChange.Title, "Выбор расы персонажа\n");

            races.ShowList(_colorChange, races.Names);
        }

        public void ShowClasses(Classes classes)
        {
            Console.Clear();

            _colorChange.Text(_colorChange.Title, "Выбор класса персонажа\n");
            classes.ShowList(_colorChange, classes.Names);
            _colorChange.Text(_colorChange.Menu, "\n0 - Назад");
        }

        public void SetNamePlayer()
        {
            Console.Clear();

            _colorChange.Text(_colorChange.Title, "Дайте имя персонажу\n");
            _colorChange.Text(_colorChange.Menu, "0 - Назад");
        }
    }
}
