using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Item
    {
        public void SetupShop()
        {
            Item atkBuff = new Item("Attack Buff", 5, 1, Stat.Attack);
            Item defBuff = new Item("Defense Buff", 5, 1, Stat.Defense);
            Item speedBuff = new Item("Speed Buff", 2, 1, Stat.Speed);
            Item heal = new Item("Heal", 30, 1, Stat.Heal);
            Item maxHeal = new Item("Max Heal", 1, 1, Stat.MaxHeal);
            Item net = new Item("Net", 1, 1, Stat.Catch);

            List<Item> availableItems = new List<Item>{ atkBuff, defBuff, speedBuff, heal, maxHeal, net };
        }

        private string _name;
        private int _statNumber;
        private int _quantity;
        private Stat _statEffect;

        public Item(string name, int statNumber, int quantity, Stat statEffect)
        {
            _name = name;
            _statNumber = statNumber;
            _quantity = quantity;
            _statEffect = statEffect;
        }
        public Stat StatEffect
        {
            get
            {
                return _statEffect;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int StatNumber
        {
            get
            {
                return _statNumber;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
    }
}



