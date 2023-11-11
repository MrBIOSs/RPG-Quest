

namespace RPGQuest.Modal
{
    internal class Player
    {
        public string Input { get; private set; }

        public void GetInput(string input)
        {
            Input = input;
        }
    }
}
