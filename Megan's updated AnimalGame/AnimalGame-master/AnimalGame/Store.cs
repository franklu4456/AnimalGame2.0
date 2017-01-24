using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Store
    {
        // Move to elsewhere
        public void SetUpShop()
        {
            List<Item> availableItems = new List<Item>();

            Item atkBuff = new Item("Attack Buff", 5, 1, 10, Stat.Attack);
            availableItems.Add(atkBuff);

            Item defBuff = new Item("Defense Buff", 5, 1, 10, Stat.Defense);
            availableItems.Add(atkBuff);

            Item speedBuff = new Item("Speed Buff", 5, 1, 10, Stat.Speed);
            availableItems.Add(speedBuff);

            Item net = new Item("Net", 0, 1, 30, Stat.Catch);
            availableItems.Add(net);
        }

        public void PurchaseItem(List<Item> playerList, Item shopItem, Player player1)
        {
            if (player1.Money >= shopItem.Price)
            {
                player1.Money =- shopItem.Price;

                playerList.Add(shopItem);
            }
            else
            {
                // Display some message?
            }
        }
    }
}
