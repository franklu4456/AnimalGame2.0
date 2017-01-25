using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Player
    {
        // Create a private integer variable for the player's row
        private int _row;

        // Create a private integer variable for the player's column
        private int _column;

        // Create a private boolean variable for if the player 
        // is in battle or not, default false
        private bool _inBattle = false;

        // Create a private integer variable for the player's money
        private int _money;

        // Create a private direction variable for the direction the player is facing 
        private Direction _facingDirection;

        // Create a private Animal list for the player's roster
        private List<Animal> _roster;

        // Create a private Item list for the player's inventory
        private List<Item> _items;

        // Create a private 
        private int _level;
        
        public Player()
        {
            _facingDirection = Direction.Up;
            Money = 1000;
            _column = 1;
            _row = 11;
            _level = 1;
        }

        public Player(List<Animal>enemyAnimalList)
        {
            _roster = enemyAnimalList;
        }

        public Player(int money, List<Animal> animalList, List<Item> item, int level)
        {
            _money = money;
            _roster = animalList;
            _items = item;
            _level = level;
        }

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
 
        }

        public List<Animal> Roster
        {
            get
            {
                
                return _roster;
            }
            set
            {
                _roster = value;
            }
        }

        public int Row
        {
            get
            {
                return _row;
            }
        }

        public int Column
        {
            get
            {
                return _column;
            }
        }

        public int Money
        {
            get
            
            {
                if (_money < 0)
                {
                    _money = 0;
                }
                return _money;
            }
            set
            {
                _money = value;
            }
        }

        public bool Interact(MapTile tile)
        {
            if (tile == MapTile.Enemy)
            {

                return true;
            }
            else if (tile == MapTile.Shop)
            {

                return true;
            }
            else if (tile == MapTile.HealStn)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Direction FacingDirection
        {
            get
            {
                return _facingDirection;
            }
        }

        public bool Move(MapTile tile)
        {
            if (tile != MapTile.Wall && tile != MapTile.Enemy &&  tile != MapTile.Shop && tile != MapTile.HealStn)
            {
                if (_facingDirection == Direction.Up)
                {
                    _column--;
                }
                else if (_facingDirection == Direction.Down)
                {
                    _column++;
                }
                else if (_facingDirection == Direction.Right)
                {
                    _row++;
                }
                else if (_facingDirection == Direction.Left)
                {
                    _row--;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // Missed rotate left and right?
        public void RotateLeft()
        {
            if (_facingDirection == Direction.Up)
            {
                _facingDirection = Direction.Left;
            }
            else if (_facingDirection == Direction.Down)
            {
                _facingDirection = Direction.Right;
            }
            else if (_facingDirection == Direction.Right)
            {
                _facingDirection = Direction.Up;
            }
            else if (_facingDirection == Direction.Left)
            {
                _facingDirection = Direction.Down;
            }
        }

        public void RotateRight()
        {
            if (_facingDirection == Direction.Up)
            {
                _facingDirection = Direction.Right;
            }
            else if (_facingDirection == Direction.Down)
            {
                _facingDirection = Direction.Left;
            }
            else if (_facingDirection == Direction.Right)
            {
                _facingDirection = Direction.Down;
            }
            else if (_facingDirection == Direction.Left)
            {
                _facingDirection = Direction.Up;
            }
        }
    }
}
