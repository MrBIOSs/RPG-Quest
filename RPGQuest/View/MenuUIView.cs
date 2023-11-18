
using RPGQuest.Modal;
using System;

namespace RPGQuest.View
{
    internal class MenuUIView : DisplayTextView
    {
        private ColorChange _colorChange = new ColorChange();

        private string _newGame = "1 - Новая игра";
        private string _loadSave = "2 - Загрузить сохранение";
        private string _howToPlay = "3 - Как играть?";
        private string _exit = "/q - Выход";

        public void ShowMenu()
        {
            _colorChange.Text(_colorChange.Title, "Добро пожаловать в RPG Quest v0.2b by Mr.BIOSs");
            Print("Здесь вы сами выбираете как закончится история вашего персонажа.\n");

            _colorChange.Text(_colorChange.Menu, _newGame);
            _colorChange.Text(_colorChange.Menu, _loadSave);
            _colorChange.Text(_colorChange.Menu, _howToPlay);
            _colorChange.Text(_colorChange.Menu, _exit);
        }

        public void ShowNewGame()
        {
            Console.Clear();

            _colorChange.Text(_colorChange.Title, "Новая игра");
            Print("Вы уверены что хотите начать новую игру?\n");

            _colorChange.Text(_colorChange.Menu, "1 - Да!\n");

            _colorChange.Text(_colorChange.Menu, _loadSave);
            _colorChange.Text(_colorChange.Menu, _howToPlay);
            _colorChange.Text(_colorChange.Menu, _exit);
        }

        public void ShowLoadSave()
        {
            Console.Clear();

            _colorChange.Text(_colorChange.Title, "Загрузить сохранение");
            Print("Выберите файл сохранения:\n");

            _colorChange.Text(_colorChange.Menu, "2 - Загрузить..\n");

            _colorChange.Text(_colorChange.Menu, _newGame);
            _colorChange.Text(_colorChange.Menu, _howToPlay);
            _colorChange.Text(_colorChange.Menu, _exit);
        }

        public void ShowHowToPlay()
        {
            Console.Clear();

            _colorChange.Text(_colorChange.Title, "Как играть?");
            Print("Выберите расу и класс за который будете играть.\n" +
                "У каждой расы и класса свое место появления персонажа, история, характеристики и способности.\n\n" +
                "Гравные правила игры:\n" +
                "1) Смерть = конец игры.\n" +
                "2) Сохраниться можно только поспав.\n" +
                "3) Творите свою историю и завершите одну из концовок.\n\n" +
                "Вам помогут:\n" +
                "1) Различные предметы, которые можно найти, купить или сделать.\n" +
                "2) Способности, которые можно изучить от других НПС или книг.\n" +
                "3) Характеристики, которые прокачиваются выполняя действия в игре.\n\n" +
                "Приятной игры!\n");

            Print("https://github.com/MrBIOSs \n");

            _colorChange.Text(_colorChange.Menu, _newGame);
            _colorChange.Text(_colorChange.Menu, _loadSave);
            _colorChange.Text(_colorChange.Menu, _exit);
        }
    }
}
