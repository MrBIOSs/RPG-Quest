
using RPGQuest.Modal.Unit;
using RPGQuest.View;
using System;

namespace RPGQuest.Modal.UI
{
    internal class CharacterCreation
    {
        private СharacterСreationView _сharacterСreationView = new СharacterСreationView();
        private Classes _classes = new Classes();
        private Races _races = new Races();

        public void StartCharacterCreation(Player player, ErrorsView errorsView)
        {
            ChooseRacePlayer(player, errorsView);

            ChooseClassPlayer(player, errorsView);

            PlayerNameInput(player, errorsView);

            //
            Console.WriteLine("\nначало игры..");
            Console.ReadLine();
        }

        private void Back(Player player, ErrorsView errorsView)
        {
            if (player.Input == "0")
            {
                StartCharacterCreation(player, errorsView);
            }
        }

        private void ChooseRacePlayer(Player player, ErrorsView errorsView)
        {
            _сharacterСreationView.ShowRaces(_races);

            while (true)
            {
                _сharacterСreationView.InputMessage();
                player.GetInput(Console.ReadLine());

                int choice = int.Parse(player.Input);

                if (choice >= 1 && choice <= _races.Names.Length)
                {
                    player.GetRace(_races.Names[choice - 1]);
                    _races.SetParameters(player);
                    break;
                }
                else
                {
                    errorsView.ShowInputError();
                }
            }  
        }

        public void ChooseClassPlayer(Player player, ErrorsView errorsView)
        {
            _сharacterСreationView.ShowClasses(_classes);

            while (true)
            {
                _сharacterСreationView.InputMessage();
                player.GetInput(Console.ReadLine());

                int choice = int.Parse(player.Input);

                Back(player, errorsView);

                if (choice >= 1 && choice <= _classes.Names.Length)
                {
                    player.GetClass(_classes.Names[choice - 1]);
                    _classes.SetParameters(player);
                    break;
                }
                else
                {
                    errorsView.ShowInputError();
                }
            } 
        }

        private void PlayerNameInput(Player player, ErrorsView errorsView)
        {
            _сharacterСreationView.SetNamePlayer();

            while (true)
            {
                _сharacterСreationView.InputMessage();
                player.GetInput(Console.ReadLine());

                Back(player, errorsView);

                player.GetName(player.Input);

                if (player.Name.Length >= 3 && player.Name.Length <= 13)
                {
                    break;
                }
                else
                {
                    errorsView.TextError("Введите корректное имя персонажа.");
                }
            }
        }
    }
}
