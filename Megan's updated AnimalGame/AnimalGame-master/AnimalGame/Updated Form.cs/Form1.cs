﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnimalGame
{
    public partial class Form1 : Form
    {
        World theWorld;
        Size tileSize;
        Player p1;
        Battle battle;

        bool canPlayerMove = false;
        bool inBattle = false;

        bool windowOpen = false;
        bool menuOpen = false;
        bool storeOpen = false;

        bool interact = false;
        bool attack1 = false;
        bool attack2 = false;
        bool attack3 = false;

        public Form1()
        {
            InitializeComponent();
            World theWorld = new World();
            HideAllPanels();
            p1 = new Player();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (canPlayerMove == true||menuOpen==true)
            {
                if (canPlayerMove == true)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        //move forward
                        theWorld.Move(p1);
                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        //rotate left
                        p1.RotateLeft();
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        //rotate right
                        p1.RotateRight();
                    }
                    else if (e.KeyCode == Keys.F)
                    {
                        //interact with a tile
                        Interact();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.O)
                    {
                        //state that the player can't walk
                        canPlayerMove = false;
                        //states that a window is open
                        windowOpen = true;
                        //makes the open inventory panel visible
                        pnlInventory.Visible = true;
                        //make the menu panel open
                        pnlMenu.Visible = false;
                        //call the subprogram that displays the inventory
                        OpenInventory();
                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        //save the game
                        SaveGame(p1);
                    }

                    else if (e.KeyCode == Keys.I)
                    {
                        //state that the menu is now open
                        menuOpen = true;
                        //state that the player can't move
                        canPlayerMove = false;
                        //state that a window is open
                        windowOpen = true;
                        //call the subprogram to open the window
                        OpenMenu();
                    }
                    else if (e.KeyCode == Keys.L)
                    {
                        //call the subprogram to load a new game
                        LoadGame();
                    }
                    else if (e.KeyCode == Keys.A)
                    {
                        //state that the player can no longer move
                        canPlayerMove = false;
                        //state that a window is open
                        windowOpen = true;
                        //open the list of animals
                        //display the animal list panel
                        pnlInventory.Visible = true;
                        //make the menu panel invisible if it already isn't 
                        pnlMenu.Visible = false;
                        //show the player's animal
                        ShowAnimals();
                    }
                }
            }

            if (inBattle == true)
            {
                if (inBattle == true)
                {
                    if (battle.IsDead == false)
                    {
                        if (e.KeyCode == Keys.Q)
                        {
                            //allows the player to pick attack 1 when in battle
                            battle.Fight(1);
                        }
                        else if (e.KeyCode == Keys.W)
                        {
                            //allows the player to pick attack 2 in battle
                            battle.Fight(2);
                        }

                        else if (e.KeyCode == Keys.E)
                        {
                            //allows the player to pick attack 3 in battle
                            battle.Fight(3);
                        }
                    }
                }
            }
            //FINISH ALL THE PANELS
            if (e.KeyCode == Keys.Escape)
            {
                //close the current window 
                //check if there is a window currenty open
                if (windowOpen == true&&inBattle==false)
                {
                    //hide all the panels
                    HideAllPanels();
                }
            }
        }

        /// <summary>
        /// subprogram to hide all the panels in the game
        /// </summary>
        public void HideAllPanels()
        {
            pnlBattle.Visible = false;
            pnlBattleOptions.Visible = false;
            pnlInventory.Visible = false;
            pnlMenu.Visible = false;
            pnlStore.Visible = false;
        }
        /// <summary>
        /// Shows the player's animals
        /// </summary>
        public void ShowAnimals()
        {
            //loop through the player's animal list
            foreach (Animal x in p1.Roster)
            {
                //temporary string to hold the information that was in the label
                string temp = null;
                //store the information that's currently displayed on the textbox into a strong
                temp = txtInventoryListOutGame.Text;
                //add the additional animal information to the text box and display it
                txtInventoryListOutGame.Text = temp + "\r\n" + "Species: " + x.Species.ToString() + "\r\n" + "Level: " + x.Level.ToString() + "\r\n" + "Speed: " + x.Speed.ToString() + "\r\n" + "Attack: " + x.Attack.ToString() + "\r\n" + "Defense: " + x.Defense.ToString() + "\r\n" + "Health: " + x.Health.ToString() + "/" + x.MaxHealth.ToString() + "\r\n";
            }
        }

        public void OpenMenu()
        {
            pnlMenu.Visible = true;
            lblMenuOptions.Text = "Open Inventory:  Press O" + "\r\n" + "View Animals: Press A" + "\r\n" + "Save Game: Press S" + "\r\n" + "Load Game: Press L" + "\r\n" + "Exit Menu: Press esc";
        }

        public void OpenInventory()
        {
            foreach (Item x in p1.Items)
            {
                string temp = null;
                temp = txtInventoryListOutGame.ToString();
                string tempDescription;

                if (x.statEffect == Stat.Attack)
                {
                    tempDescription = "Increases Attack: " + x.StatNumber.ToString();
                }
                else if (x.statEffect == Stat.Defense)
                {
                    tempDescription = "Increases Defense: " + x.StatNumber.ToString();
                }
                else if (x.statEffect == Stat.Speed)
                {
                    tempDescription = "Increases Speed: " + x.StatNumber.ToString();
                }
                else if (x.statEffect == Stat.Heal)
                {
                    tempDescription = "Increases Health: " + x.StatNumber.ToString();
                }
                else
                {
                    tempDescription = "Brings the animal to max health";
                }
                txtInventoryListOutGame.Text = temp + x.Name + ":" + "\r\n" + tempDescription + "\r\n" + x.Quanity.ToString() + "\r\n";
            }
        }

        public void OpenStore()
        {
            //NEED TO FINISH!!!
            lblStoreList.Text = "To purchase the item, press the corresponding key \r\n \r\n";
        }

        public void Interact()
        {
            if (theWorld.TileInFront(p1) == MapTile.Enemy) 
            {
                //state that the player is in battle
                inBattle = true;
                //battle panel needs to be made
                Random numberGenerator = new Random();
                int number = numberGenerator.Next(0, theWorld.EnemyPlayerList().Length-1);
                battle = new Battle(p1.Roster, theWorld.EnemyPlayerList()[number].Roster, p1.Items, false);
            }
            else if (theWorld.TileInFront(p1) == MapTile.Shop)
            {
                windowOpen = true;
                pnlStore.Visible = true; 
                storeOpen = true;
                OpenStore();

            }
            else if (theWorld.TileInFront(p1) == MapTile.HealStn)
            {
                //loop through all the animal's in the player list
                foreach (Animal x in p1.Roster)
                {
                    //bring their current health to their max health
                    x.Health = x.MaxHealth;
                }
            }
            else if (theWorld.TileInFront(p1) == MapTile.Animal)
            {
                //state that the player is in battle
                inBattle = true;
                //generate a random number to decide which animal the player will battle
                Random numberGenerator = new Random();
                int number = numberGenerator.Next(0, theWorld.SetAnimalStuff().Length - 1);
                //temporary array to store the wild animal that they'll be batteling
                List<Animal> tempWildAnimal = new List<Animal>();
                //add the randomly selected wild number to the list of wild animals
                tempWildAnimal.Add(theWorld.SetAnimalStuff()[number]);

                //set a battle for the wild animal
                battle = new Battle(p1.Roster, tempWildAnimal, p1.Items, true);
            }
        }

        public void SaveGame(Player p1)
        {
            using (StreamWriter file = new StreamWriter("saveGame.txt"))
            {
                //save the player's level and money
                file.WriteLine("1"+"\r\n"+(p1.Level).ToString() + " " + (p1.Money).ToString());

                //save and store all variables and information for each item
                foreach (Item x in p1.Items)
                {
                    file.WriteLine("2" + "\r\n" + x.Name + " " + x.Quanity.ToString() + " " + x.StatNumber.ToString() + " " + x.statEffect.ToString());
                }
                //save and store all variables and informationf or each animal
                foreach (Animal x in p1.Roster)
                {
                    file.WriteLine("3" + "\r\n" + x.Species + " " + x.Level.ToString() + " " + x.Speed.ToString() + " " + x.MaxHealth.ToString() + " " + x.Health.ToString() + " " + x.Attack.ToString()+" "+x.Defense.ToString());
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
            Player savedPlayer;

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

                //initialize file with the file "saveGame.txt"
                using (StreamReader file = new StreamReader("saveGame.txt"))
                {
                    //loop through this until the it has read to the end of the file
                    while (file.EndOfStream)
                    {
                        //variable stores all the animal information
                        //initialize it to the bases that aren't applicable
                        Type animalSpecies = 0;
                        int animalLevel = 0;
                        int animalSpeed = 0;
                        int animalMaxHealth = 0;
                        int animalCurrentHealth = 0;
                        int animalAttackAmount = 0;
                        int animalDefenseAmount = 0;

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
                savedPlayer = new Player(money, tempAnimals, tempItems, level);
            }
            savedPlayer = new Player();
            return savedPlayer;
        }
    }

}
