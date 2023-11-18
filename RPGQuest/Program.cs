
using RPGQuest.Modal;
using RPGQuest.Modal.UI;
using RPGQuest.View;

namespace RPGQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuUI menuUI = new MenuUI();
            MenuUIView menuUIView = new MenuUIView();
            ErrorsView errorsView = new ErrorsView();

            Player player = new Player();

            menuUI.StartMainMenu(menuUIView, player, errorsView);
        }
    }
}
