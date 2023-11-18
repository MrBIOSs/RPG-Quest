
using RPGQuest.View;
using System;

namespace RPGQuest.Modal.Unit
{
    internal class Races : CharacterTypeView, ISetParametrs
    {
        public readonly string[] Names =
        {
            "Эльф",
        };

        private void RaceSelection(string raceName, ref int strength, ref int intelligence, ref int agility)
        {
            switch (raceName)
            {
                case "Эльф":
                    intelligence += 2;
                    agility += 2;
                    break;
            }
        }

        public void SetParameters(Player player)
        {
            int strength = player.Strength;
            int intelligence = player.Intelligence;
            int agility = player.Agility;

            RaceSelection(player.Race, ref strength, ref intelligence, ref agility);

            player.GetStrength(strength);
            player.GetIntelligence(intelligence);
            player.GetAgility(agility);
        }

        public void SetParameters(Enemy enemy)
        {
            int strength = enemy.Strength;
            int intelligence = enemy.Intelligence;
            int agility = enemy.Agility;

            RaceSelection(enemy.Race, ref strength, ref intelligence, ref agility);

            enemy.GetStrength(strength);
            enemy.GetIntelligence(intelligence);
            enemy.GetAgility(agility);
        }

        public void SetParameters(NPC npc)
        {
            int strength = npc.Strength;
            int intelligence = npc.Intelligence;
            int agility = npc.Agility;

            RaceSelection(npc.Race, ref strength, ref intelligence, ref agility);

            npc.GetStrength(strength);
            npc.GetIntelligence(intelligence);
            npc.GetAgility(agility);
        }
    }
}
