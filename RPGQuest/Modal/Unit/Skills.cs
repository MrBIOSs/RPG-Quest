

using RPGQuest.View;
using System;

namespace RPGQuest.Modal.Unit
{
    internal class Skills : DisplayTextView
    {
        public readonly string[] Names =
        {
            "Гармония природы",
            "Превращение в зверя,"
        };

        public void SkillActivation(string skillName)
        {
            switch (skillName)
            {
                case "Гармония природы":
                    Print("Описание:\n" +
                        "Пассивный талант\n" +
                        "Вы родились и жили с природой, все звери ваши друзья.");
                    break;

                case "Превращение в зверя":
                    Print("Описание:\n" +
                        "Активное умение\n" +
                        "Вы долго изучали и общались с зверьми, вы можете превращаться в одного из них.");
                    //тут выбор Волк, Пантера, Медведь

                    break;
            }
        }
    }
}
