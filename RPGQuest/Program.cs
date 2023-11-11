
using RPGQuest.Modal;
using RPGQuest.View;
using System;

namespace RPGQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuUIView _menuUIView;
            MenuUI _menuUI;
            Player _player;

            StartMainMenu();

            void StartMainMenu()
            {
                _menuUIView = new MenuUIView();
                _menuUI = new MenuUI();
                _player = new Player();

                _menuUIView.ShowMenu();

                while (true)
                {
                    _player.GetInput(Console.ReadLine());

                    if (_player.Input == "/q" || _player.Input == "1" || _player.Input == "2" || _player.Input == "3")
                    {
                        break;
                    }
                }

                switch (_player.Input)
                {
                    case "1":
                        StartNewGame();
                        break;

                    case "2":
                        StartLoadSave();
                        break;

                    case "3":
                        StartHowToPlayUI();
                        break;
                }
            }

            void StartNewGame()
            {
                _menuUI.ChooseNewGame();

                while (true)
                {
                    _player.GetInput(Console.ReadLine());

                    if (_player.Input == "/q" || _player.Input == "1" || _player.Input == "2" || _player.Input == "3")
                    {
                        break;
                    }
                }

                switch (_player.Input)
                {
                    case "1":
                        Console.WriteLine("Тут должна стартовать игра начиная с создания перса... Позже)");
                        Console.Read();
                        break;

                    case "2":
                        StartLoadSave();
                        break;

                    case "3":
                        StartHowToPlayUI();
                        break;
                }
            }

            void StartLoadSave()
            {
                _menuUI.ChooseLoadSave();

                while (true)
                {
                    _player.GetInput(Console.ReadLine());

                    if (_player.Input == "/q" || _player.Input == "1" || _player.Input == "2" || _player.Input == "3")
                    {
                        break;
                    }
                }

                switch (_player.Input)
                {
                    case "1":
                        StartNewGame();
                        break;

                    case "2":
                        Console.WriteLine("Тут должна быть загрузка созранения... В следующем патче)");
                        Console.Read();
                        break;

                    case "3":
                        StartHowToPlayUI();
                        break;
                }
            }

            void StartHowToPlayUI()
            {
                _menuUI.СhooseHowToPlay();

                while (true)
                {
                    _player.GetInput(Console.ReadLine());

                    if (_player.Input == "/q" || _player.Input == "1" || _player.Input == "2")
                    {
                        break;
                    }
                }

                switch (_player.Input)
                {
                    case "1":
                        StartNewGame();
                        break;

                    case "2":
                        StartLoadSave();
                        break;
                }
            }
        }
    }
}
