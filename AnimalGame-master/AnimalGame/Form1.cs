/*
 * Megan Hong and Frank Lu
 * 1/24/2017
 * Form: Controls all the external commands to the game and displays everything
 */
using System;
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
        //variables store the
        //creation of classes
        //creates the world
        World theWorld;
        //variabels stores the created player
        Player player;
        //variable stores the created battle
        Battle battle;
        //stores the created store class
        Store worldStore = new Store();

        //variable declares if the player can move
        bool canPlayerMove = true;
        //stores if any window is open
        bool windowOpen = false;
        //stores is a menu panel is open
        bool menuOpen = false;

        public Form1()
        {
            InitializeComponent();
            //creates a player
            player = new Player();
            //creates the world, through passing in the player
            theWorld = new World(ref player);
            //hides all the panels in the start of the game
            HideAllPanels();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check if the player can move or if the option menu is open
            if (canPlayerMove == true || menuOpen == true)
            {
                //if the player is allowed to move
                //allow the character to move when pressing arrow keys,
                //or interact with tiles
                if (canPlayerMove == true)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        //move forward
                        theWorld.Move(player);
                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        //rotate left
                        player.RotateLeft();
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        //rotate right
                        player.RotateRight();
                    }
                    else if (e.KeyCode == Keys.F)
                    {
                        //interact with a tile
                        Interact();
                    }
                }
                // if the menu is open or the player can move
                //allow the player to pick options from the menu
                if (e.KeyCode == Keys.O)
                {
                    //makes the open inventory panel visible
                    pnlInventory.Visible = true;

                    //state that the player can't walk
                    canPlayerMove = false;
                    //states that a window is open
                    windowOpen = true;

                    //make the menu panel open
                    pnlMenu.Visible = false;
                    //call the subprogram that displays the inventory
                    OpenInventory();
                }
                else if (e.KeyCode == Keys.S)
                {
                    //save the game
                    theWorld.SaveGame(player);
                }
                else if (e.KeyCode == Keys.L)
                {
                    Player tempPlayer = theWorld.LoadGame();
                    //call the subprogram to load a new game
                    theWorld = new World(ref tempPlayer);

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
            }
            //check if the store panels is visible
            if (pnlStore.Visible == true)
            {
                //create a temporary item to store the item to be bought
                Item temp = null;
                //if the player presses "1"
                //allow the character to purchase attack boost
                if (e.KeyCode == Keys.D1)
                {
                    foreach (Item x in worldStore.SetupShop())
                    {
                        if (x.StatEffect == Stat.Attack)
                        {
                            temp = x;
                        }
                    }
                }
                //store the items information intot he temporary item
                //for purchase
                else if (e.KeyCode == Keys.D2)
                {
                    foreach (Item x in worldStore.SetupShop())
                    {
                        if (x.StatEffect == Stat.Defense)
                        {
                            temp = x;
                        }
                    }
                }

                else if (e.KeyCode == Keys.D3)
                {
                    foreach (Item x in worldStore.SetupShop())
                    {
                        if (x.StatEffect == Stat.Speed)
                        {
                            temp = x;
                        }
                    }
                }
                else if (e.KeyCode == Keys.D4)
                {
                    foreach (Item x in worldStore.SetupShop())
                    {
                        if (x.StatEffect == Stat.Heal)
                        {
                            temp = x;
                        }
                    }
                }
                else if (e.KeyCode == Keys.D5)
                {
                    foreach (Item x in worldStore.SetupShop())
                    {
                        if (x.StatEffect == Stat.MaxHeal)
                        {
                            temp = x;
                        }
                    }
                }
                else if (e.KeyCode == Keys.D6)
                {
                    foreach (Item x in worldStore.SetupShop())
                    {
                        if (x.StatEffect == Stat.Catch)
                        {
                            temp = x;
                        }
                    }
                }
                worldStore.PurchaseItem(player.Items, temp, player);
            }
            if (player.InBattle == true && canPlayerMove == false)
            {
                //FINISH
                if (battle.IsDead == false)
                {
                    if (e.KeyCode == Keys.Q)
                    {
                        //allows the player to pick attack 1 when in battle
                        battle.Fight(1);

                        pnlResults.Visible = true;
                        player.InBattle = false;
                        DisplayResults();

                    }
                    else if (e.KeyCode == Keys.W)
                    {
                        //allows the player to pick attack 2 in battle
                        battle.Fight(2);
                        DisplayResults();

                    }

                    else if (e.KeyCode == Keys.E)
                    {
                        //allows the player to pick attack 3 in battle
                        battle.Fight(3);
                        DisplayResults();
                    }
                }
            }
            //FINISH ALL THE PANELS
            if (e.KeyCode == Keys.Escape)
            {
                //close the current window 
                //check if there is a window currenty open
                if (windowOpen == true && player.InBattle == false)
                {
                    //hide all the panels
                    HideAllPanels();
                    canPlayerMove = true;
                }

                else if (windowOpen == true && battle.Status!=2)
                {
                    HideAllPanels();
                }
            }
        }

        public void DisplayResults()
        {
            //SHIT THING
            //problem
            if (battle.Status != 3)
            {
                pnlResults.Visible = true;
                player.InBattle = false;
                if (battle.Status == 1)
                {
                    lblBattleResults.Text = "WIN! \r\n Press ESC to exit the screen.";
                }
                else
                {
                    lblBattleResults.Text = "LOSE \r\n Press ESC to exit the screen.";
                }
            }
        }
        public void PanelSizing()
        {

            pnlMenu.Width = (ClientSize.Width / 4);
            pnlMenu.Height = ClientSize.Height;

            pnlInventory.Width = (ClientSize.Width / 4);
            pnlInventory.Height = ClientSize.Height;
            txtInventoryListOutGame.Width = pnlInventory.Width;
            txtInventoryListOutGame.Height = (pnlInventory.Height / 6) - pnlInventory.Height;

            pnlStore.Width = (ClientSize.Height / 4);
            pnlStore.Height = ClientSize.Height;
            lblStoreList.Width = (ClientSize.Width / 6) - ClientSize.Width;

            pnlResults.Width = ClientSize.Width;
            pnlResults.Height = ClientSize.Height;
            lblBattleResults.Width = ClientSize.Width / 2;


        }
        /// <summary>
        /// subprogram to hide all the panels in the game
        /// </summary>
        public void HideAllPanels()
        {
            pnlBattleOptions.Visible = false;

            pnlInventory.Visible = false;
            pnlMenu.Visible = false;
            pnlStore.Visible = false;
            pnlResults.Visible = false;

            pnlBattle.Visible = false;
            pnlBattleInv.Visible = false;
            pnlAttacks.Visible = false;
            pnlAnimals.Visible = false;
            pnlInterface.Visible=false;
        }

        /// <summary>
        /// Shows the player's animals
        /// </summary>
        public void ShowAnimals()
        {
            //loop through the player's animal list
            foreach (Animal x in player.Roster)
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
            lblMenuOptions.Visible = true;
            lblMenuTitle.Visible = true;
            lblMenuOptions.Text = "Open Inventory:  Press O" + "\r\n" + "View Animals: Press A" + "\r\n" + "Save Game: Press S" + "\r\n" + "Load Game: Press L" + "\r\n" + "Exit Menu: Press esc";
        }

        public void OpenInventory()
        {
            txtInventoryListOutGame.Visible = true;
            pnlInventory.Visible = true;
            if (player.Items.Count()>0)
            {
                foreach (Item x in player.Items)
                {
                    string temp = null;
                    temp = txtInventoryListOutGame.ToString();
                    string tempDescription;

                    if (x.StatEffect == Stat.Attack)
                    {
                        tempDescription = "Increases Attack: " + x.StatNumber.ToString();
                    }
                    else if (x.StatEffect == Stat.Defense)
                    {
                        tempDescription = "Increases Defense: " + x.StatNumber.ToString();
                    }
                    else if (x.StatEffect == Stat.Speed)
                    {
                        tempDescription = "Increases Speed: " + x.StatNumber.ToString();
                    }
                    else if (x.StatEffect == Stat.Heal)
                    {
                        tempDescription = "Increases Health: " + x.StatNumber.ToString();
                    }
                    else if (x.StatEffect == Stat.Catch)
                    {
                        tempDescription = "Catches wild animals";
                    }
                    else
                    {
                        tempDescription = "Brings the animal to max health";
                    }
                    txtInventoryListOutGame.Text = temp + x.Name + ":" + "\r\n" + tempDescription + "\r\n" + x.Quantity.ToString() + "\r\n";
                }
            }
            else
            {
                txtInventoryListOutGame.Text = "Inventory is empty";
            }
        }

        /// <summary>
        /// open the list and display the information for each item
        /// to be purchased on the list
        /// </summary>
        public void OpenStore()
        {
            lblStoreList.Visible = true;
            lblShopTitle.Visible = true;
            //create the world's store
            worldStore = new Store();
            //temporary string to store the information that was displayed by the label
            string temp = null;
            //loop through all the items in the world
            foreach (Item x in worldStore.SetupShop())
            {
                //stores the description for the item
                string tempDescription;
                //stores the keys that correspond with the item
                string tempKeys;

                //check the types of items on the item list
                //set the proper information for the description and the keys to press to purchase
                if (x.StatEffect == Stat.Attack)
                {
                    tempDescription = "Increases Attack: " + x.StatNumber.ToString();
                    tempKeys = "Press '1' to purchase";
                }
                else if (x.StatEffect == Stat.Defense)
                {
                    tempDescription = "Increases Defense: " + x.StatNumber.ToString();
                    tempKeys = "Press '2' to purchase";
                }
                else if (x.StatEffect == Stat.Speed)
                {
                    tempDescription = "Increases Speed: " + x.StatNumber.ToString();
                    tempKeys = "Press '3' to purchase";
                }
                else if (x.StatEffect == Stat.Heal)
                {
                    tempDescription = "Increases Health: " + x.StatNumber.ToString();
                    tempKeys = "Press '4' to purchase";
                }
                else if (x.StatEffect == Stat.MaxHeal)
                {
                    tempDescription = "Brings the animal to max health";
                    tempKeys = "Press '5' to purchase";
                }
                else
                {
                    tempDescription = "Catches wild animals";
                    tempKeys = "Press '6' to purchase";
                }

                //display the information for the item on the store list label
                lblStoreList.Text = temp + x.Name + ":" + "\r\n" + tempDescription + "\r\n" + x.Quantity.ToString() + "\r\n" + tempKeys + "\r\n";
            }
        }

        public void Interact()
        {
            if (theWorld.TileInFront(player) == MapTile.Enemy)
            {
                //state that the player is in battle
                player.InBattle = true;
                //battle panel needs to be made
                Random numberGenerator = new Random();
                int number = numberGenerator.Next(0, theWorld.EnemyPlayerList().Length - 1);
                battle = new Battle(player.Roster, theWorld.EnemyPlayerList()[number].Roster, player.Items, false);
            }
            else if (theWorld.TileInFront(player) == MapTile.Shop)
            {
                windowOpen = true;
                pnlStore.Visible = true;
                OpenStore();

            }
            else if (theWorld.TileInFront(player) == MapTile.HealStn)
            {
                //loop through all the animal's in the player list
                foreach (Animal x in player.Roster)
                {
                    //bring their current health to their max health
                    x.Health = x.MaxHealth;
                }
            }
            else if (theWorld.TileInFront(player) == MapTile.Animal)
            {
                //state that the player is in battle
                player.InBattle = true;
                //generate a random number to decide which animal the player will battle
                Random numberGenerator = new Random();
                int number = numberGenerator.Next(0, theWorld.SetAnimalStuff().Length - 1);
                //temporary array to store the wild animal that they'll be batteling
                List<Animal> tempWildAnimal = new List<Animal>();
                //add the randomly selected wild number to the list of wild animals
                tempWildAnimal.Add(theWorld.SetAnimalStuff()[number]);

                //set a battle for the wild animal
                battle = new Battle(player.Roster, tempWildAnimal, player.Items, true);
            }
        }




        //FRANK
        private void btnFight_Click(object sender, EventArgs e)
        {
            Animal current = player.Roster.First();
            lblAttack1.Text = current.AttackArray[0].ToString();
            lblAttack2.Text = current.AttackArray[1].ToString();
            lblAttack3.Text = current.AttackArray[2].ToString();
            pnlAttacks.Visible = true;
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.Attack)
                {
                    lblItem1.Text = x.Name + " Increases attack by: " + x.StatNumber;
                    Item atk = x;
                }
                else if (x.StatEffect == Stat.Defense)
                {
                    lblItem2.Text = x.Name + " Increases defense by: " + x.StatNumber;
                    Item def = x;
                }
                else if (x.StatEffect == Stat.Speed)
                {
                    lblItem3.Text = x.Name + " Increases speed by: " + x.StatNumber;
                }
                else if (x.StatEffect == Stat.Heal)
                {
                    lblItem4.Text = x.Name + " Heals animal by: " + x.StatNumber;
                }
                else if (x.StatEffect == Stat.MaxHeal)
                {
                    lblItem5.Text = x.Name + " Heals animal to full.";
                }
                else if (x.StatEffect == Stat.Catch)
                {
                    lblItem6.Text = x.Name + " Catches animals.";
                }
            }
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            Animal[] tempRoster = new Animal[3];
            int count = 0;
            foreach (Animal x in player.Roster)
            {
                tempRoster[count] = x;
            }
            lblAnimal1.Text = tempRoster[0].Species.ToString() + tempRoster[0].Health.ToString() + "/" + tempRoster[0].MaxHealth.ToString() + tempRoster[0].Attack.ToString() + tempRoster[0].Defense.ToString() + tempRoster[0].Speed.ToString();

            lblAnimal1.Text = tempRoster[1].Species.ToString() + tempRoster[1].Health.ToString() + "/" + tempRoster[1].MaxHealth.ToString() + tempRoster[1].Attack.ToString() + tempRoster[1].Defense.ToString() + tempRoster[1].Speed.ToString();

            lblAnimal1.Text = tempRoster[2].Species.ToString() + tempRoster[2].Health.ToString() + "/" + tempRoster[2].MaxHealth.ToString() + tempRoster[2].Attack.ToString() + tempRoster[2].Defense.ToString() + tempRoster[2].Speed.ToString();

            pnlAnimals.Visible = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            battle.Run(battle);
        }

        private void btnExitAnimals_Click(object sender, EventArgs e)
        {
            pnlAnimals.Visible = false;
        }

        private void btnSwitch1_Click(object sender, EventArgs e)
        {
            battle.SwitchPlayerAnimal(player.Roster, 0);
        }

        private void btnSwitch2_Click(object sender, EventArgs e)
        {
            battle.SwitchPlayerAnimal(player.Roster, 1);
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            battle.Fight(1);
        }

        private void btnAttack2_Click(object sender, EventArgs e)
        {
            battle.Fight(2);
        }

        private void btnAttack3_Click(object sender, EventArgs e)
        {
            battle.Fight(3);
        }

        private void btnExitBInv_Click(object sender, EventArgs e)
        {
            pnlBattleInv.Visible = false;
        }

        private void btnUseItem1_Click(object sender, EventArgs e)
        {
            Item used = null;
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.Attack)
                {
                    used = x;
                }
            }
            battle.UsedAtkBoost(player.Roster.First(), used);
        }

        private void btnUseItem2_Click(object sender, EventArgs e)
        {
            Item used = null;
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.Defense)
                {
                    used = x;
                }
            }
            battle.UsedDefBoost(player.Roster.First(), used);
        }

        private void btnUseItem3_Click(object sender, EventArgs e)
        {
            Item used = null;
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.Speed)
                {
                    used = x;
                }
            }
            battle.UsedSpeedBoost(player.Roster.First(), used);
        }

        private void btnUsedItem4_Click(object sender, EventArgs e)
        {
            Item used = null;
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.Heal)
                {
                    used = x;
                }
            }
            battle.UsedHeal(player.Roster.First(), used);
        }

        private void btnUsedItem5_Click(object sender, EventArgs e)
        {
            Item used = null;
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.MaxHeal)
                {
                    used = x;
                }
            }
            battle.UsedMaxHeal(player.Roster.First(), used);
        }

        private void btnUsedItem6_Click(object sender, EventArgs e)
        {
            Item used = null;
            foreach (Item x in player.Items)
            {
                if (x.StatEffect == Stat.Catch)
                {
                    used = x;
                }
            }
            battle.UsedNet(used, battle.EnemyAnimals.First(), battle.IsWild, player.Roster);
        }

        //MERSHAB
        protected override void OnPaint(PaintEventArgs e)
        {
            const int SPRITE_SIZE = 100;

            int startingX = 0;
            int startingY = 0;

            const int TILE_HEIGHT = 40;
            const int TILE_WIDTH = 40;

            for (int j = 0; j < theWorld.Map.GetLength(1); j++)
            {
                for (int i = 0; i < theWorld.Map.GetLength(0); i++)
                {
                    RectangleF tempRectangle = new RectangleF((float)startingX, (float)startingY, TILE_HEIGHT, TILE_WIDTH);

                    if (theWorld.Map[i, j] == MapTile.Animal)
                    {
                        e.Graphics.FillRectangle(Brushes.Orange, tempRectangle);
                    }
                    else if (theWorld.Map[i, j] == MapTile.Enemy)
                    {
                        e.Graphics.FillRectangle(Brushes.Red, tempRectangle);
                    }
                    else if (theWorld.Map[i, j] == MapTile.HealStn)
                    {
                        e.Graphics.FillRectangle(Brushes.Blue, tempRectangle);
                    }
                    else if (theWorld.Map[i, j] == MapTile.Shop)
                    {
                        e.Graphics.FillRectangle(Brushes.DarkGoldenrod, tempRectangle);
                    }
                    else if (theWorld.Map[i, j] == MapTile.TallGrass)
                    {
                        e.Graphics.FillRectangle(Brushes.DarkOliveGreen, tempRectangle);
                    }
                    else if (theWorld.Map[i, j] == MapTile.Filler1 || theWorld.Map[i, j] == MapTile.StartLocation || theWorld.Map[i, j] == MapTile.EndLocation)
                    {
                        e.Graphics.FillRectangle(Brushes.LightGreen, tempRectangle);
                    }
                    else if (theWorld.Map[i, j] == MapTile.Filler2)
                    {
                        e.Graphics.FillRectangle(Brushes.SandyBrown, tempRectangle);
                    }


                    if (player.Column == i && player.Row == j)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, tempRectangle);
                    }

                    startingX += TILE_WIDTH;
                }

                startingX = 0;

                startingY += TILE_HEIGHT;
            }
            if (player.InBattle)
            {
                RectangleF enemySprite = new RectangleF((float)ClientSize.Width - SPRITE_SIZE, (float)0, (float)SPRITE_SIZE, (float)SPRITE_SIZE);
                RectangleF playerSprite = new RectangleF((float)0, (float)((ClientSize.Height / 2) - SPRITE_SIZE), (float)SPRITE_SIZE, (float)SPRITE_SIZE);
                e.Graphics.FillRectangle(Brushes.Aqua, enemySprite);
                e.Graphics.FillRectangle(Brushes.Gold, playerSprite);
            }
            base.OnPaint(e);
        }
    }
}
