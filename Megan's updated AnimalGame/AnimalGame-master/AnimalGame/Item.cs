﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Item
    {
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
        public Stat statEffect
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
        public int Quanity
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



