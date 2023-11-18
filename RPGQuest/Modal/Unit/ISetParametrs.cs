

namespace RPGQuest.Modal.Unit
{
    internal interface ISetParametrs
    {
        void SetParameters(Player player);
        void SetParameters(Enemy enemy);
        void SetParameters(NPC npc);
    }
}
