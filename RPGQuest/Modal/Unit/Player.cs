
using RPGQuest.Modal.Unit;

namespace RPGQuest.Modal
{
    internal class Player : Character
    {
        public string Input { get; private set; }

        public void GetInput(string input)
        {
            Input = input;
        }
    }
}
