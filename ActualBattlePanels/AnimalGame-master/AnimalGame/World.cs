﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalGame
{
    class World
    {

        private int level = 1;
        private MapTile[,] _map;

        public Player[] EnemyPlayerList(Animal[] defaultAnimals)
        {
            List<Animal> tempEnemyAnimalList = new List<Animal>();
            Player[] enemyPlayerList = new Player[5];
            Random numberGenerator = new Random();
            int counterAnimal = 0;
            int playerCount = 0;
            while (playerCount <= 5)
            {
                if (counterAnimal <= 3)
                {
                    int random = numberGenerator.Next(0, defaultAnimals.Length - 1);

                    tempEnemyAnimalList.Add(defaultAnimals[random]);
                    counterAnimal++;
                }
                else if (counterAnimal == 3)
                {
                    counterAnimal = 0;
                    Player tempEnemyPlayer = new Player(tempEnemyAnimalList);
                    enemyPlayerList[1] = tempEnemyPlayer;
                }
            }
            return enemyPlayerList;
        }

        public World(MapTile[,] map)
        {
            _map = map;
        }
        public World()
        {
            _map = SetupGame();
        }
        private int GetRowInFront(Player p1)
        {
            int row = p1.Row;
            if (p1.FacingDirection == Direction.Up)
            {
                row = p1.Row - 1;
            }
            else if (p1.FacingDirection == Direction.Down)
            {
                row = p1.Row + 1;
            }

            return row;
        }

        private int GetColumnInFront(Player p1)
        {
            int column = p1.Column;
            if (p1.FacingDirection == Direction.Left)
            {
                column = p1.Column - 1;
            }
            else if (p1.FacingDirection == Direction.Right)
            {
                column = p1.Column + 1;
            }
            return column;
        }

        public void Move(Player p1)
        {
            p1.Move(TileInFront(p1));
        }

        public MapTile TileInFront(Player p1)
        {
            return (_map[GetColumnInFront(p1), GetRowInFront(p1)]);
        }

        public MapTile[,] SetupGame()
        {
            if (level == 1)
            {
                string stageOneGrid = Properties.Resources.Stage1;
                MapTile[,] gridLevelOne = SetMap(stageOneGrid);
                return gridLevelOne;
            }
            else if (level == 2)
            {
                string stageTwoGrid = Properties.Resources.Stage2;
                MapTile[,] gridLevelTwo = SetMap(stageTwoGrid);
                return gridLevelTwo;
            }
            else
            {
                string stageThreeGrid = Properties.Resources.Stage3;
                MapTile[,] gridLevelThree = SetMap(stageThreeGrid);
                return gridLevelThree;
            }
        }

        public MapTile[,] SetMap(string stageGrid)
        {
            string[] num = stageGrid.Split(new char[] { '\r', '\n' });
            string numbers = null;
            for (int i = 0; i < num.Length - 1; i++)
            {
                numbers = numbers + num[i];
            }
            char[] val = numbers.ToCharArray();
            int[] numberValues = new int[num.Length];

            for (int i = 0; i < val.Length - 1; i++)
            {
                string temp;
                int number;
                temp = val[i].ToString();
                int.TryParse(temp, out number);
                numberValues[i] = number;
            }
            MapTile[,] map = new MapTile[18, 12];

            for (int y = 0; y < 12; y++)
            {
                for (int x = 0; x < 18; x++)
                {
                    for (int i = 0; i < numberValues.Length - 1; i++)
                    {
                        map[x, y] = (MapTile)numberValues[i];
                    }
                }
            }
            return map;
        }

       

    }
}
