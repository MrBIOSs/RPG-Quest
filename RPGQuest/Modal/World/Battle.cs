

using RPGQuest.Modal.Unit;
using System;

namespace RPGQuest.Modal.World
{
    internal class Battle
    {
        public void StartOfBattle(Player player, Enemy enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                //система боя

                if (player.Health <= 0 && enemy.Health <= 0)
                {
                    Console.WriteLine("Поражение");
                }
                else if (enemy.Health <= 0)
                {
                    Console.WriteLine("Победа");
                }
                else if (player.Health <= 0)
                {
                    Console.WriteLine("Поражение");
                }
            }
        }
    }
}
