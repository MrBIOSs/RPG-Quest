

using System;

namespace RPGQuest.Modal.Unit
{
    internal class NPC : Character
    {
        private int _food;
        private int _foodUnitPrice; // тут рандом значение
        private bool _isAbleToPay;

        public void TradeServices()
        {

        }

        private void BuyFood(Player player)
        {
            _isAbleToPay = player.Money >= _food * _foodUnitPrice;

            _food *= Convert.ToInt32(_isAbleToPay);

            //player.Money -= _food * _foodUnitPrice;
        }
    }
}
