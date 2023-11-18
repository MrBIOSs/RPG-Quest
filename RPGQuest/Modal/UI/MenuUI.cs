
using RPGQuest.View;
using System;

namespace RPGQuest.Modal.UI
{
    internal class MenuUI
    {
        private CharacterCreation _characterCreation = new CharacterCreation();

        private bool _exit = false;
        public void StartMainMenu(MenuUIView menuUIView, Player player, ErrorsView errorsView)
        {
            menuUIView.ShowMenu();

            while (!_exit)
            {
                menuUIView.InputMessage();
                player.GetInput(Console.ReadLine());

                switch (player.Input)
                {
                    case "1":
                        StartNewGame(menuUIView, player, errorsView);
                        break;

                    case "2":
                        StartLoadSave(menuUIView, player, errorsView);
                        break;

                    case "3":
                        StartHowToPlayUI(menuUIView, player, errorsView);
                        break;

                    case "/q":
                        _exit = true;
                        break;

                    default:
                        errorsView.ShowInputError();
                        break;
                }
            }
        }

        private void StartNewGame(MenuUIView menuUIView, Player player, ErrorsView errorsView)
        {
            menuUIView.ShowNewGame();

            while (!_exit)
            {
                menuUIView.InputMessage();
                player.GetInput(Console.ReadLine());

                switch (player.Input)
                {
                    case "1":
                        _characterCreation.StartCharacterCreation(player, errorsView);
                        break;

                    case "2":
                        StartLoadSave(menuUIView, player, errorsView);
                        break;

                    case "3":
                        StartHowToPlayUI(menuUIView, player, errorsView);
                        break;

                    case "/q":
                        _exit = true;
                        break;

                    default:
                        errorsView.ShowInputError();
                        break;
                }
            }
        }

        private void StartLoadSave(MenuUIView menuUIView, Player player, ErrorsView errorsView)
        {
            menuUIView.ShowLoadSave();

            while (!_exit)
            {
                menuUIView.InputMessage();
                player.GetInput(Console.ReadLine());

                switch (player.Input)
                {
                    case "1":
                        StartNewGame(menuUIView, player, errorsView);
                        break;

                    case "2":
                        Console.WriteLine("Тут должна быть загрузка созранения... В следующем патче)");
                        Console.Read();
                        break;

                    case "3":
                        StartHowToPlayUI(menuUIView, player, errorsView);
                        break;

                    case "/q":
                        _exit = true;
                        break;

                    default:
                        errorsView.ShowInputError();
                        break;
                }
            }
        }

        void StartHowToPlayUI(MenuUIView menuUIView, Player player, ErrorsView errorsView)
        {
            menuUIView.ShowHowToPlay();

            while (!_exit)
            {
                menuUIView.InputMessage();
                player.GetInput(Console.ReadLine());

                switch (player.Input)
                {
                    case "1":
                        StartNewGame(menuUIView, player, errorsView);
                        break;

                    case "2":
                        StartLoadSave(menuUIView, player, errorsView);
                        break;

                    case "/q":
                        _exit = true;
                        break;

                    default:
                        errorsView.ShowInputError();
                        break;
                }
            }
        }
    }
}
