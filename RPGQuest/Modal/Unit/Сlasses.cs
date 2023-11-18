
using RPGQuest.View;

namespace RPGQuest.Modal.Unit
{
    internal class Classes : CharacterTypeView, ISetParametrs
    {
        public readonly string[] Names =
        {
            "Друид",
        };

        private void ClassSelection(string className, ref int health, ref int mana, ref int strength, 
            ref int intelligence, ref int agility)
        {
            switch (className)
            {
                case "Друид":
                    health += 100;
                    mana += 120;
                    strength += 6;
                    intelligence += 7;
                    agility += 5;
                    break;
            }
        }

        public void SetParameters(Player player)
        {
            int health = player.Health;
            int mana = player.Mana;
            int strength = player.Strength;
            int intelligence = player.Intelligence;
            int agility = player.Agility;

            ClassSelection(player.Class,ref health, ref mana, ref strength, ref intelligence, ref agility);

            player.GetHealth(health);
            player.GetMana(mana);
            player.GetStrength(strength);
            player.GetIntelligence(intelligence);
            player.GetAgility(agility);
        }

        public void SetParameters(Enemy enemy)
        {
            int health = enemy.Health;
            int mana = enemy.Mana;
            int strength = enemy.Strength;
            int intelligence = enemy.Intelligence;
            int agility = enemy.Agility;

            ClassSelection(enemy.Class, ref health, ref mana, ref strength, ref intelligence, ref agility);

            enemy.GetHealth(health);
            enemy.GetMana(mana);
            enemy.GetStrength(strength);
            enemy.GetIntelligence(intelligence);
            enemy.GetAgility(agility);
        }

        public void SetParameters(NPC npc)
        {
            int health = npc.Health;
            int mana = npc.Mana;
            int strength = npc.Strength;
            int intelligence = npc.Intelligence;
            int agility = npc.Agility;

            ClassSelection(npc.Class, ref health, ref mana, ref strength, ref intelligence, ref agility);

            npc.GetHealth(health);
            npc.GetMana(mana);
            npc.GetStrength(strength);
            npc.GetIntelligence(intelligence);
            npc.GetAgility(agility);
        }
    }
}
