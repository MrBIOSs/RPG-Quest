
using RPGQuest.Modal;

namespace RPGQuest.View
{
    internal class ErrorsView
    {
        private ColorChange _colorChange = new ColorChange();

        private string _invalidInput = "Введите корректное значение.";

        public void ShowInputError()
        {
            _colorChange.Text(_colorChange.Error, _invalidInput);
        }

        public void TextError(string message)
        {
            _colorChange.Text(_colorChange.Error, message);
        }
    }
}
