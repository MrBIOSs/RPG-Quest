
using RPGQuest.View;

namespace RPGQuest.Modal
{
    internal class MenuUI
    {
        private MenuUIView _menuUIView;

        public void ChooseNewGame()
        {
            _menuUIView = new MenuUIView();

            _menuUIView.ShowNewGame();
        }

        public void ChooseLoadSave()
        {
            _menuUIView = new MenuUIView();

            _menuUIView.ShowLoadSave();
        }

        public void СhooseHowToPlay()
        {

            _menuUIView = new MenuUIView();

            _menuUIView.ShowHowToPlay();
        }
    }
}

