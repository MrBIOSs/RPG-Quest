
using RPGQuest.View;
using System.Threading;

namespace RPGQuest.Modal.Unit
{
    internal class Character : DisplayTextView
    {
        public string Name { get; protected set; }
        public string Race { get; protected set; }
        public string Class { get; protected set; }

        public int Health { get; protected set; }
        public int Mana { get; protected set; }
        public int Strength { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Agility { get; protected set; }

        public int Armor { get; protected set; }
        public int PhysicalDamage { get; protected set; }
        public int MagicDamage { get; protected set; }

        public int Money { get; protected set; }


        private int _precentConverter = 100;

        public void ShowInfo()
        {
            Print($"Имя: {Name}");
            Print($"Раса: {Race}");
            Print($"Класс: {Class}");
            Print($"Здоровье: {Health}");
            Print($"Мана: {Mana}");
            Print($"Сила: {Strength}");
            Print($"Интеллект: {Intelligence}");
            Print($"Ловкость: {Agility}");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage * Armor / _precentConverter;
        }

        public void GetName(string name)
        {
            Name = name;
        }

        public void GetRace(string race)
        {
            Race = race;
        }

        public void GetClass(string _class)
        {
            Class = _class;
        }

        public void GetHealth(int health)
        {
            Health = health;
        }

        public void GetMana(int mana)
        {
            Mana = mana;
        }

        public void GetStrength(int strength)
        {
            Strength = strength;
        }

        public void GetIntelligence(int intelligence)
        {
            Intelligence = intelligence;
        }

        public void GetAgility(int agility)
        {
            Agility = agility;
        }

        public void GetMoney(int money)
        {
            Money = money;
        }
    }
}
