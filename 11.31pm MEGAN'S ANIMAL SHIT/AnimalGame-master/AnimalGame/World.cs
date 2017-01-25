/*
 * Megan Hong and Frank Lu
 * World Class: controls and creates the world for the game
 * states the tiles infront of the player
 * sets the default animal and enemy list
 * 1/24/2017
 */
using System;
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

        private Player _P1;

        public Animal[] SetAnimalStuff()
        {
            //Default Water Attacks
            Attack dirtyWater = null;
            dirtyWater.Effect = AttackEffect.EnemyStatDebuff;
            dirtyWater.AttackType = Type.Water;

            Attack absorb = null;
            absorb.Effect = AttackEffect.PlayerStatBuff;
            absorb.AttackType = Type.Water;

            Attack splash = null;
            splash.Effect = AttackEffect.EnemyHealthDown;
            splash.AttackType = Type.Water;

            Attack sprinkler = null;
            sprinkler.Effect = AttackEffect.EnemyHealthDown;
            sprinkler.AttackType = Type.Water;

            //Default Earth Attacks
            Attack sandyWind = null;
            sandyWind.Effect = AttackEffect.EnemyStatDebuff;
            sandyWind.AttackType = Type.Rock;

            Attack mudBath = null;
            mudBath.Effect = AttackEffect.PlayerStatBuff;
            mudBath.AttackType = Type.Rock;

            Attack pelt = null;
            pelt.Effect = AttackEffect.EnemyHealthDown;
            pelt.AttackType = Type.Rock;

            Attack bury = null;
            bury.Effect = AttackEffect.EnemyHealthDown;
            bury.AttackType = Type.Rock;

            //Default Flying Attacks
            Attack showOff = null;
            showOff.Effect = AttackEffect.EnemyStatDebuff;
            showOff.AttackType = Type.Air;

            Attack groom = null;
            groom.Effect = AttackEffect.PlayerStatBuff;
            groom.AttackType = Type.Air;

            Attack swoop = null;
            swoop.Effect = AttackEffect.EnemyHealthDown;
            swoop.AttackType = Type.Air;

            Attack peck = null;
            peck.Effect = AttackEffect.EnemyHealthDown;
            peck.AttackType = Type.Air;

            //Default Fire Attacks
            Attack smog = null;
            smog.Effect = AttackEffect.EnemyStatDebuff;
            smog.AttackType = Type.Fire;

            Attack sauna = null;
            sauna.Effect = AttackEffect.PlayerStatBuff;
            sauna.AttackType = Type.Fire;

            Attack singe = null;
            singe.Effect = AttackEffect.EnemyHealthDown;
            singe.AttackType = Type.Fire;

            Attack sparkler = null;
            sparkler.Effect = AttackEffect.EnemyHealthDown;
            sparkler.AttackType = Type.Fire;

            //Default Grass Attacks
            Attack poisonIvy = null;
            poisonIvy.Effect = AttackEffect.EnemyStatDebuff;
            poisonIvy.AttackType = Type.Grass;

            Attack chrysanthemum = null;
            chrysanthemum.Effect = AttackEffect.PlayerStatBuff;
            chrysanthemum.AttackType = Type.Grass;

            Attack pricklyThorns = null;
            pricklyThorns.Effect = AttackEffect.EnemyHealthDown;
            pricklyThorns.AttackType = Type.Grass;

            Attack fallingBranch = null;
            fallingBranch.Effect = AttackEffect.EnemyHealthDown;
            fallingBranch.AttackType = Type.Grass;

            //Default animals

            //Default Grass Animals
            Animal grass1 = new Animal(50, 20, 12, 5, Type.Grass, 1, pricklyThorns, fallingBranch, poisonIvy);

            Animal grass2 = new Animal(75, 15, 20, 2, Type.Grass, 1, poisonIvy, chrysanthemum, fallingBranch);

            //Default Water Animals
            Animal water1 = new Animal(40, 20, 8, 6, Type.Water, 1, splash, sprinkler, dirtyWater);

            Animal water2 = new Animal(60, 17, 22, 3, Type.Water, 1, absorb, splash, sprinkler);

            //Default Earth Animals
            Animal rock1 = new Animal(100, 5, 25, 1, Type.Rock, 1, mudBath, sandyWind, pelt);

            Animal rock2 = new Animal(90, 7, 27, 1, Type.Rock, 1, sandyWind, pelt, bury);

            //Default Fire Animals
            Animal fire1 = new Animal(20, 30, 5, 8, Type.Fire, 1, singe, sauna, sparkler);

            Animal fire2 = new Animal(25, 32, 4, 10, Type.Fire, 1, singe, smog, sparkler);

            //Default Flying Animals
            Animal air1 = new Animal(40, 18, 15, 10, Type.Air, 1, groom, swoop, peck);

            Animal air2 = new Animal(45, 22, 18, 11, Type.Air, 1, showOff, swoop, peck);

            Animal[] defaultAnimals = { grass1, grass2, rock1, rock2, fire1, fire2, water1, water2, air1, air2 };

            return defaultAnimals;
        }

        public Player[] EnemyPlayerList()
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
                    int random = numberGenerator.Next(0, SetAnimalStuff().Length - 1);

                    tempEnemyAnimalList.Add(SetAnimalStuff()[random]);
                    counterAnimal++;
                }
                else if (counterAnimal == 3)
                {
                    counterAnimal = 0;
                    Player tempEnemyPlayer = new Player(tempEnemyAnimalList);
                    enemyPlayerList[1] = tempEnemyPlayer;
                }
                playerCount++;
            }
            return enemyPlayerList;
        }

        public World( Player P1)
        {
            _map = SetupGame();
            _P1 = P1;
            
        }

        public MapTile[,] Map
        {
            get
            {
                return _map;
            }
            set
            {
                _map = value;
            }
        }

        public Player P1
        {
            get
            {
                return _P1;
            }
        }

        private int GetRowInFront(Player P1)
        {
            int row = P1.Row;
            if (P1.FacingDirection == Direction.Up)
            {
                row = P1.Row - 1;
            }
            else if (P1.FacingDirection == Direction.Down)
            {
                row = P1.Row + 1;
            }

            return row;
        }

        private int GetColumnInFront(Player P1)
        {
            int column = P1.Column;
            if (P1.FacingDirection == Direction.Left)
            {
                column = P1.Column - 1;
            }
            else if (P1.FacingDirection == Direction.Right)
            {
                column = P1.Column + 1;
            }
            return column;
        }

        public void Move(Player P1)
        {
            P1.Move(TileInFront(P1));
        }

        public MapTile TileInFront(Player P1)
        {
            return (_map[GetColumnInFront(P1), GetRowInFront(P1)]);
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
            string[] num = stageGrid.Split(new char[] {  '\r','\n' });
            string numbers = null;
            for (int i = 0; i < num.Length; i++)
            {
                numbers = numbers + num[i];
            }

            char[] val = numbers.ToCharArray();
            int[] numberValues = new int[val.Length];

            for (int i = 0; i < val.Length; i++)
            {
                string temp;
                int number;
                temp = val[i].ToString();
                int.TryParse(temp, out number);
                numberValues[i] = number;
            }
            MapTile[,] map = new MapTile[18, 12];

            int counter = 0;
            for (int y = 0; y < map.GetLongLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (counter < 216)
                    {
                        map[x, y] = (MapTile)numberValues[counter];
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return map;
        }

        //FIX
        public void SaveGame(Player P1)
        {
            using (StreamWriter file = new StreamWriter("saveGame.txt"))
            {
                //save the player's level and money
                file.WriteLine("1" + "\r\n" + P1.Level.ToString() + " " + P1.Money.ToString());

                //save and store all variables and information for each item
                foreach (Item x in P1.Items)
                {
                    file.WriteLine("2" + "\r\n" + x.Name + " " + x.Quantity.ToString() + " " + x.StatNumber.ToString() + " " + x.StatEffect.ToString());
                }
                //save and store all variables and informationf or each animal
                foreach (Animal x in P1.Roster)
                {
                    file.WriteLine("3" + "\r\n" + x.Species + " " + x.Level.ToString() + " " + x.Speed.ToString() + " " + x.MaxHealth.ToString() + " " + x.Health.ToString() + " " + x.Attack.ToString() + " " + x.Defense.ToString());
                    foreach (Attack j in x.AttackArray)
                    {
                        int damageAttackTemp = 0;
                        if (j.IsDamageAttack == true)
                        {
                            damageAttackTemp = 1;
                            DamageAttack temp = (DamageAttack)j;
                            file.WriteLine("4" + "\r\n" + j.AttackType.ToString() + " " + j.Effect.ToString() + " " + j.Name + " " + damageAttackTemp.ToString() + temp.Damage.ToString());
                        }
                        else
                        {
                            damageAttackTemp = 0;
                            StatChangeAttack temp = (StatChangeAttack)j;
                            file.WriteLine("4" + "\r\n" + j.AttackType.ToString() + " " + j.Effect.ToString() + " " + j.Name + " " + damageAttackTemp.ToString() + " " + temp.StatChangeValue.ToString()); ;
                        }
                    }
                }
                file.Close();
            }
        }

        public Player LoadGame()
        {
            //check if the file exists
            if (File.Exists("saveGame.txt"))
            {
                //variables will store the saved level and amount of money the player had
                int money = 0;
                int level = 0;

                //temporary list of the player's items, animals and a queue for their animal attacks
                List<Item> tempItems = new List<Item>();
                List<Animal> tempAnimals = new List<Animal>();
                Queue<Attack> tempAnimalAttacks = new Queue<Attack>();
                //variable to store the line that was just read
                string info;

                //variable stores all the animal information
                //initialize it to the bases that aren't applicable
                Type animalSpecies = 0;
                int animalLevel = 0;
                int animalSpeed = 0;
                int animalMaxHealth = 0;
                int animalCurrentHealth = 0;
                int animalAttackAmount = 0;
                int animalDefenseAmount = 0;

                //initialize file with the file "saveGame.txt"
                using (StreamReader file = new StreamReader("saveGame.txt"))
                {
                    //loop through this until the it has read to the end of the file
                    while (file.EndOfStream)
                    {
                        //read a line in the 
                        info = file.ReadLine();

                        if (info == "1")
                        {
                            info = file.ReadLine();
                            //retrieves the section of the array with all the player's information
                            //splits the index by the spaces, and splits it into a player info array
                            string[] playerInfo = info.Split(new char[] { ' ' });
                            //temp string will hold the variables to be changed to an integer
                            string temp = playerInfo[1];
                            //converting the strings to a integer
                            int.TryParse(temp, out money);
                            temp = playerInfo[2];
                            int.TryParse(temp, out level);
                        }
                        else if (info == "2")
                        {
                            //read the next line
                            info = file.ReadLine();
                            //splits the saved string into an array by the spaces
                            string[] playerItems = info.Split(new char[] { ' ' });
                            //variables will store the player's items requirements
                            string itemName;
                            int itemQuantity;
                            Stat itemType;
                            int itemStats;
                            int tempItemType;
                            string tempStringToInteger;

                            //stores the name of the item
                            itemName = playerItems[1];
                            //stores the string in the temp variable to change into a integer
                            //converts the temp string into an integer
                            tempStringToInteger = playerItems[2];
                            int.TryParse(tempStringToInteger, out itemQuantity);

                            tempStringToInteger = playerItems[3];
                            int.TryParse(tempStringToInteger, out itemStats);

                            tempStringToInteger = playerItems[4];
                            int.TryParse(tempStringToInteger, out tempItemType);
                            //converts the integer into a stat enumeration
                            itemType = (Stat)tempItemType;
                            //creates a new item with the saved item information
                            Item tempItemToAddToList = new Item(itemName, itemStats, itemQuantity, itemType);
                            //add it to the temp item list
                            tempItems.Add(tempItemToAddToList);
                        }
                        else if (info == "3")
                        {
                            info = file.ReadLine();
                            string[] playerAnimalInfo = info.Split(new char[] { ' ' });
                            string tempStringToInteger;
                            int tempNumber;


                            tempStringToInteger = playerAnimalInfo[1];
                            int.TryParse(tempStringToInteger, out tempNumber);
                            animalSpecies = (Type)tempNumber;

                            tempStringToInteger = playerAnimalInfo[2];
                            int.TryParse(tempStringToInteger, out animalLevel);
                            tempStringToInteger = playerAnimalInfo[3];
                            int.TryParse(tempStringToInteger, out animalSpeed);
                            tempStringToInteger = playerAnimalInfo[4];
                            int.TryParse(tempStringToInteger, out animalMaxHealth);
                            tempStringToInteger = playerAnimalInfo[5];
                            int.TryParse(tempStringToInteger, out animalCurrentHealth);

                            tempStringToInteger = playerAnimalInfo[6];
                            int.TryParse(tempStringToInteger, out tempNumber);
                            animalAttackAmount = tempNumber;

                            tempStringToInteger = playerAnimalInfo[7];
                            int.TryParse(tempStringToInteger, out tempNumber);
                            animalDefenseAmount = tempNumber;
                        }
                        else if (info == "4")
                        {
                            info = file.ReadLine();
                            string[] animalAttacks = info.Split(new char[] { ' ' });

                            Type attackTypeTemp;
                            AttackEffect attackEffectTemp;
                            string attackNameTemp;
                            int damageAttackAmountTemp;
                            Stat statAttackAmountTemp;
                            string tempStringToInteger;
                            int tempNumbers;

                            tempStringToInteger = animalAttacks[1];
                            int.TryParse(tempStringToInteger, out tempNumbers);
                            attackTypeTemp = (Type)tempNumbers;

                            tempStringToInteger = animalAttacks[2];
                            int.TryParse(tempStringToInteger, out tempNumbers);
                            attackEffectTemp = (AttackEffect)tempNumbers;

                            attackNameTemp = animalAttacks[3];

                            tempStringToInteger = animalAttacks[4];
                            int.TryParse(tempStringToInteger, out tempNumbers);
                            if (tempNumbers == 1)
                            {
                                tempStringToInteger = animalAttacks[5];
                                int.TryParse(tempStringToInteger, out tempNumbers);
                                damageAttackAmountTemp = tempNumbers;
                                Attack tempAttack = new DamageAttack(attackTypeTemp, attackEffectTemp, damageAttackAmountTemp, attackNameTemp);
                                tempAnimalAttacks.Enqueue(tempAttack);

                            }
                            else
                            {
                                tempStringToInteger = animalAttacks[5];
                                int.TryParse(tempStringToInteger, out tempNumbers);
                                statAttackAmountTemp = (Stat)tempNumbers;
                                //create a new attack and add it to the temp attack array
                                Attack tempAttack = new StatChangeAttack(attackTypeTemp, attackEffectTemp, statAttackAmountTemp, attackNameTemp);
                                tempAnimalAttacks.Enqueue(tempAttack);
                            }
                        }
                        if (tempAnimalAttacks.Count == 3)
                        {
                            Attack attack1 = tempAnimalAttacks.Dequeue();
                            Attack attack2 = tempAnimalAttacks.Dequeue();
                            Attack attack3 = tempAnimalAttacks.Dequeue();

                            Animal tempAnimalToAddToList = new Animal(animalMaxHealth, animalAttackAmount, animalDefenseAmount, animalSpeed, animalSpecies, animalLevel, attack1, attack2, attack3);
                            tempAnimals.Add(tempAnimalToAddToList);
                        }
                    }
                    file.Close();
                }
                //variable will hold the saved player
                Player savedPlayer = new Player(money, tempAnimals, tempItems, level);

                return savedPlayer;
            }
            else
            {
                return null;

            }
        }

       

       

    }
}
