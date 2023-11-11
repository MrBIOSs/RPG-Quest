
using RPGQuest.Modal;
using System;

namespace RPGQuest.View
{
    internal class MenuUIView
    {
        private ColorChange _colorChange;
        private MenuUI _menuUI;

        private string _newGame = "1 - Новая игра";
        private string _loadSave = "2 - Загрузить сохранение";
        private string _howToPlay = "3 - Как играть?";
        private string _exit = "/q - Выход";

        private ConsoleColor _titleColor = ConsoleColor.Yellow;
        private ConsoleColor _menuColor = ConsoleColor.White;

        public void ShowMenu()
        {
            _colorChange = new ColorChange();

            _colorChange.Text(_titleColor, "Добро пожаловать в RPG Quest v0.1b by Mr.BIOSs");
            Print("Здесь вы сами выбираете как закончится история вашего персонажа.\n");

            _colorChange.Text(_menuColor, _newGame);
            _colorChange.Text(_menuColor, _loadSave);
            _colorChange.Text(_menuColor, _howToPlay);
            _colorChange.Text(_menuColor, _exit);

            Input();
        }

        public void ShowNewGame()
        {
            _colorChange = new ColorChange();

            Console.Clear();

            _colorChange.Text(_titleColor, "Новая игра");
            Print("Вы уверены что хотите начать новую игру?\n");

            _colorChange.Text(_menuColor, "1 - Да!\n");

            _colorChange.Text(_menuColor, _loadSave);
            _colorChange.Text(_menuColor, _howToPlay);
            _colorChange.Text(_menuColor, _exit);

            Input();
        }

        public void ShowLoadSave()
        {
            _colorChange = new ColorChange();

            Console.Clear();

            _colorChange.Text(_titleColor, "Загрузить сохранение");
            Print("Выберите файл сохранения:\n");

            _colorChange.Text(_menuColor, "2 - Загрузить..\n");

            _colorChange.Text(_menuColor, _newGame);
            _colorChange.Text(_menuColor, _howToPlay);
            _colorChange.Text(_menuColor, _exit);

            Input();
        }

        public void ShowHowToPlay()
        {
            _menuUI = new MenuUI();
            _colorChange = new ColorChange();

            Console.Clear();

            _colorChange.Text(_titleColor, "Как играть?");
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

            _colorChange.Text(_menuColor, _newGame);
            _colorChange.Text(_menuColor, _loadSave);
            _colorChange.Text(_menuColor, _exit);

            Input();
        }

        private void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Input()
        {
            Console.Write("\nВыберите действие: ");
        }
    }
}
