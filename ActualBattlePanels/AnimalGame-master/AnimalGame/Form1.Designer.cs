namespace AnimalGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBattle = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.pnlAttacks = new System.Windows.Forms.Panel();
            this.btnExitAttacks = new System.Windows.Forms.Button();
            this.pnlBattleInv = new System.Windows.Forms.Panel();
            this.btnUsedItem6 = new System.Windows.Forms.Button();
            this.btnUsedItem5 = new System.Windows.Forms.Button();
            this.btnUsedItem4 = new System.Windows.Forms.Button();
            this.btnUseItem3 = new System.Windows.Forms.Button();
            this.btnUseItem2 = new System.Windows.Forms.Button();
            this.btnUseItem1 = new System.Windows.Forms.Button();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.btnExitBInv = new System.Windows.Forms.Button();
            this.lblItem6 = new System.Windows.Forms.Label();
            this.lblItem5 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.pnlAnimals = new System.Windows.Forms.Panel();
            this.btnSwitch2 = new System.Windows.Forms.Button();
            this.btnSwitch1 = new System.Windows.Forms.Button();
            this.btnExitAnimals = new System.Windows.Forms.Button();
            this.lblAnimal3 = new System.Windows.Forms.Label();
            this.lblAnimal2 = new System.Windows.Forms.Label();
            this.lblAnimal1 = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.lblAttack1 = new System.Windows.Forms.Label();
            this.lblAttack2 = new System.Windows.Forms.Label();
            this.lblAttack3 = new System.Windows.Forms.Label();
            this.pnlBattle.SuspendLayout();
            this.pnlAttacks.SuspendLayout();
            this.pnlBattleInv.SuspendLayout();
            this.pnlAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBattle
            // 
            this.pnlBattle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlBattle.Controls.Add(this.enemyHealthBar);
            this.pnlBattle.Controls.Add(this.playerHealthBar);
            this.pnlBattle.Controls.Add(this.btnRun);
            this.pnlBattle.Controls.Add(this.btnInv);
            this.pnlBattle.Controls.Add(this.btnAnimal);
            this.pnlBattle.Controls.Add(this.btnFight);
            this.pnlBattle.Location = new System.Drawing.Point(12, 480);
            this.pnlBattle.Name = "pnlBattle";
            this.pnlBattle.Size = new System.Drawing.Size(705, 247);
            this.pnlBattle.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Location = new System.Drawing.Point(359, 139);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(343, 105);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnInv
            // 
            this.btnInv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInv.Location = new System.Drawing.Point(359, 31);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(343, 105);
            this.btnInv.TabIndex = 3;
            this.btnInv.Text = "Inventory";
            this.btnInv.UseVisualStyleBackColor = false;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimal.Location = new System.Drawing.Point(3, 139);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(341, 105);
            this.btnAnimal.TabIndex = 2;
            this.btnAnimal.Text = "Animals";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnFight
            // 
            this.btnFight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFight.Location = new System.Drawing.Point(3, 31);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(341, 105);
            this.btnFight.TabIndex = 1;
            this.btnFight.Text = "Fight";
            this.btnFight.UseVisualStyleBackColor = false;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // pnlAttacks
            // 
            this.pnlAttacks.Controls.Add(this.lblAttack3);
            this.pnlAttacks.Controls.Add(this.lblAttack2);
            this.pnlAttacks.Controls.Add(this.lblAttack1);
            this.pnlAttacks.Controls.Add(this.btnExitAttacks);
            this.pnlAttacks.Location = new System.Drawing.Point(12, 254);
            this.pnlAttacks.Name = "pnlAttacks";
            this.pnlAttacks.Size = new System.Drawing.Size(705, 220);
            this.pnlAttacks.TabIndex = 1;
            // 
            // btnExitAttacks
            // 
            this.btnExitAttacks.Location = new System.Drawing.Point(392, 175);
            this.btnExitAttacks.Name = "btnExitAttacks";
            this.btnExitAttacks.Size = new System.Drawing.Size(291, 23);
            this.btnExitAttacks.TabIndex = 3;
            this.btnExitAttacks.Text = "Back";
            this.btnExitAttacks.UseVisualStyleBackColor = true;
            // 
            // pnlBattleInv
            // 
            this.pnlBattleInv.Controls.Add(this.btnUsedItem6);
            this.pnlBattleInv.Controls.Add(this.btnUsedItem5);
            this.pnlBattleInv.Controls.Add(this.btnUsedItem4);
            this.pnlBattleInv.Controls.Add(this.btnUseItem3);
            this.pnlBattleInv.Controls.Add(this.btnUseItem2);
            this.pnlBattleInv.Controls.Add(this.btnUseItem1);
            this.pnlBattleInv.Controls.Add(this.lblItem4);
            this.pnlBattleInv.Controls.Add(this.btnExitBInv);
            this.pnlBattleInv.Controls.Add(this.lblItem6);
            this.pnlBattleInv.Controls.Add(this.lblItem5);
            this.pnlBattleInv.Controls.Add(this.lblItem2);
            this.pnlBattleInv.Controls.Add(this.lblItem3);
            this.pnlBattleInv.Controls.Add(this.lblItem1);
            this.pnlBattleInv.Location = new System.Drawing.Point(747, 199);
            this.pnlBattleInv.Name = "pnlBattleInv";
            this.pnlBattleInv.Size = new System.Drawing.Size(705, 220);
            this.pnlBattleInv.TabIndex = 2;
            // 
            // btnUsedItem6
            // 
            this.btnUsedItem6.Location = new System.Drawing.Point(608, 178);
            this.btnUsedItem6.Name = "btnUsedItem6";
            this.btnUsedItem6.Size = new System.Drawing.Size(75, 23);
            this.btnUsedItem6.TabIndex = 12;
            this.btnUsedItem6.Text = "Back";
            this.btnUsedItem6.UseVisualStyleBackColor = true;
            this.btnUsedItem6.Click += new System.EventHandler(this.btnUsedItem6_Click);
            // 
            // btnUsedItem5
            // 
            this.btnUsedItem5.Location = new System.Drawing.Point(608, 153);
            this.btnUsedItem5.Name = "btnUsedItem5";
            this.btnUsedItem5.Size = new System.Drawing.Size(75, 23);
            this.btnUsedItem5.TabIndex = 11;
            this.btnUsedItem5.Text = "Back";
            this.btnUsedItem5.UseVisualStyleBackColor = true;
            this.btnUsedItem5.Click += new System.EventHandler(this.btnUsedItem5_Click);
            // 
            // btnUsedItem4
            // 
            this.btnUsedItem4.Location = new System.Drawing.Point(608, 128);
            this.btnUsedItem4.Name = "btnUsedItem4";
            this.btnUsedItem4.Size = new System.Drawing.Size(75, 23);
            this.btnUsedItem4.TabIndex = 10;
            this.btnUsedItem4.Text = "Back";
            this.btnUsedItem4.UseVisualStyleBackColor = true;
            this.btnUsedItem4.Click += new System.EventHandler(this.btnUsedItem4_Click);
            // 
            // btnUseItem3
            // 
            this.btnUseItem3.Location = new System.Drawing.Point(608, 103);
            this.btnUseItem3.Name = "btnUseItem3";
            this.btnUseItem3.Size = new System.Drawing.Size(75, 23);
            this.btnUseItem3.TabIndex = 9;
            this.btnUseItem3.Text = "Back";
            this.btnUseItem3.UseVisualStyleBackColor = true;
            this.btnUseItem3.Click += new System.EventHandler(this.btnUseItem3_Click);
            // 
            // btnUseItem2
            // 
            this.btnUseItem2.Location = new System.Drawing.Point(608, 77);
            this.btnUseItem2.Name = "btnUseItem2";
            this.btnUseItem2.Size = new System.Drawing.Size(75, 23);
            this.btnUseItem2.TabIndex = 8;
            this.btnUseItem2.Text = "Use";
            this.btnUseItem2.UseVisualStyleBackColor = true;
            this.btnUseItem2.Click += new System.EventHandler(this.btnUseItem2_Click);
            // 
            // btnUseItem1
            // 
            this.btnUseItem1.Location = new System.Drawing.Point(608, 53);
            this.btnUseItem1.Name = "btnUseItem1";
            this.btnUseItem1.Size = new System.Drawing.Size(75, 23);
            this.btnUseItem1.TabIndex = 7;
            this.btnUseItem1.Text = "Use";
            this.btnUseItem1.UseVisualStyleBackColor = true;
            this.btnUseItem1.Click += new System.EventHandler(this.btnUseItem1_Click);
            // 
            // lblItem4
            // 
            this.lblItem4.AutoSize = true;
            this.lblItem4.Location = new System.Drawing.Point(25, 133);
            this.lblItem4.Name = "lblItem4";
            this.lblItem4.Size = new System.Drawing.Size(35, 13);
            this.lblItem4.TabIndex = 6;
            this.lblItem4.Text = "label1";
            // 
            // btnExitBInv
            // 
            this.btnExitBInv.Location = new System.Drawing.Point(608, 16);
            this.btnExitBInv.Name = "btnExitBInv";
            this.btnExitBInv.Size = new System.Drawing.Size(75, 23);
            this.btnExitBInv.TabIndex = 5;
            this.btnExitBInv.Text = "Back";
            this.btnExitBInv.UseVisualStyleBackColor = true;
            this.btnExitBInv.Click += new System.EventHandler(this.btnExitBInv_Click);
            // 
            // lblItem6
            // 
            this.lblItem6.AutoSize = true;
            this.lblItem6.Location = new System.Drawing.Point(25, 183);
            this.lblItem6.Name = "lblItem6";
            this.lblItem6.Size = new System.Drawing.Size(35, 13);
            this.lblItem6.TabIndex = 4;
            this.lblItem6.Text = "label5";
            // 
            // lblItem5
            // 
            this.lblItem5.AutoSize = true;
            this.lblItem5.Location = new System.Drawing.Point(25, 158);
            this.lblItem5.Name = "lblItem5";
            this.lblItem5.Size = new System.Drawing.Size(35, 13);
            this.lblItem5.TabIndex = 3;
            this.lblItem5.Text = "label4";
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Location = new System.Drawing.Point(25, 82);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(35, 13);
            this.lblItem2.TabIndex = 2;
            this.lblItem2.Text = "label3";
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.Location = new System.Drawing.Point(25, 108);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(35, 13);
            this.lblItem3.TabIndex = 1;
            this.lblItem3.Text = "label2";
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Location = new System.Drawing.Point(25, 58);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(35, 13);
            this.lblItem1.TabIndex = 0;
            this.lblItem1.Text = "label1";
            // 
            // pnlAnimals
            // 
            this.pnlAnimals.Controls.Add(this.btnSwitch2);
            this.pnlAnimals.Controls.Add(this.btnSwitch1);
            this.pnlAnimals.Controls.Add(this.btnExitAnimals);
            this.pnlAnimals.Controls.Add(this.lblAnimal3);
            this.pnlAnimals.Controls.Add(this.lblAnimal2);
            this.pnlAnimals.Controls.Add(this.lblAnimal1);
            this.pnlAnimals.Location = new System.Drawing.Point(12, 12);
            this.pnlAnimals.Name = "pnlAnimals";
            this.pnlAnimals.Size = new System.Drawing.Size(705, 220);
            this.pnlAnimals.TabIndex = 3;
            // 
            // btnSwitch2
            // 
            this.btnSwitch2.Location = new System.Drawing.Point(608, 187);
            this.btnSwitch2.Name = "btnSwitch2";
            this.btnSwitch2.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch2.TabIndex = 9;
            this.btnSwitch2.Text = "Switch To";
            this.btnSwitch2.UseVisualStyleBackColor = true;
            this.btnSwitch2.Click += new System.EventHandler(this.btnSwitch2_Click);
            // 
            // btnSwitch1
            // 
            this.btnSwitch1.Location = new System.Drawing.Point(608, 117);
            this.btnSwitch1.Name = "btnSwitch1";
            this.btnSwitch1.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch1.TabIndex = 8;
            this.btnSwitch1.Text = "Switch To";
            this.btnSwitch1.UseVisualStyleBackColor = true;
            this.btnSwitch1.Click += new System.EventHandler(this.btnSwitch1_Click);
            // 
            // btnExitAnimals
            // 
            this.btnExitAnimals.Location = new System.Drawing.Point(608, 14);
            this.btnExitAnimals.Name = "btnExitAnimals";
            this.btnExitAnimals.Size = new System.Drawing.Size(75, 23);
            this.btnExitAnimals.TabIndex = 6;
            this.btnExitAnimals.Text = "Back";
            this.btnExitAnimals.UseVisualStyleBackColor = true;
            this.btnExitAnimals.Click += new System.EventHandler(this.btnExitAnimals_Click);
            // 
            // lblAnimal3
            // 
            this.lblAnimal3.AutoSize = true;
            this.lblAnimal3.Location = new System.Drawing.Point(14, 192);
            this.lblAnimal3.Name = "lblAnimal3";
            this.lblAnimal3.Size = new System.Drawing.Size(35, 13);
            this.lblAnimal3.TabIndex = 2;
            this.lblAnimal3.Text = "label3";
            // 
            // lblAnimal2
            // 
            this.lblAnimal2.AutoSize = true;
            this.lblAnimal2.Location = new System.Drawing.Point(14, 122);
            this.lblAnimal2.Name = "lblAnimal2";
            this.lblAnimal2.Size = new System.Drawing.Size(35, 13);
            this.lblAnimal2.TabIndex = 1;
            this.lblAnimal2.Text = "label2";
            // 
            // lblAnimal1
            // 
            this.lblAnimal1.AutoSize = true;
            this.lblAnimal1.Location = new System.Drawing.Point(14, 49);
            this.lblAnimal1.Name = "lblAnimal1";
            this.lblAnimal1.Size = new System.Drawing.Size(35, 13);
            this.lblAnimal1.TabIndex = 0;
            this.lblAnimal1.Text = "label1";
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(113, 3);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(231, 23);
            this.playerHealthBar.TabIndex = 5;
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.Location = new System.Drawing.Point(359, 3);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(231, 23);
            this.enemyHealthBar.TabIndex = 6;
            // 
            // lblAttack1
            // 
            this.lblAttack1.AutoSize = true;
            this.lblAttack1.Location = new System.Drawing.Point(30, 32);
            this.lblAttack1.Name = "lblAttack1";
            this.lblAttack1.Size = new System.Drawing.Size(35, 13);
            this.lblAttack1.TabIndex = 4;
            this.lblAttack1.Text = "label1";
            // 
            // lblAttack2
            // 
            this.lblAttack2.AutoSize = true;
            this.lblAttack2.Location = new System.Drawing.Point(389, 32);
            this.lblAttack2.Name = "lblAttack2";
            this.lblAttack2.Size = new System.Drawing.Size(35, 13);
            this.lblAttack2.TabIndex = 5;
            this.lblAttack2.Text = "label2";
            // 
            // lblAttack3
            // 
            this.lblAttack3.AutoSize = true;
            this.lblAttack3.Location = new System.Drawing.Point(30, 180);
            this.lblAttack3.Name = "lblAttack3";
            this.lblAttack3.Size = new System.Drawing.Size(35, 13);
            this.lblAttack3.TabIndex = 6;
            this.lblAttack3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 739);
            this.Controls.Add(this.pnlAnimals);
            this.Controls.Add(this.pnlBattleInv);
            this.Controls.Add(this.pnlAttacks);
            this.Controls.Add(this.pnlBattle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlBattle.ResumeLayout(false);
            this.pnlAttacks.ResumeLayout(false);
            this.pnlAttacks.PerformLayout();
            this.pnlBattleInv.ResumeLayout(false);
            this.pnlBattleInv.PerformLayout();
            this.pnlAnimals.ResumeLayout(false);
            this.pnlAnimals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBattle;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Panel pnlAttacks;
        private System.Windows.Forms.Button btnExitAttacks;
        private System.Windows.Forms.Panel pnlBattleInv;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.Button btnExitBInv;
        private System.Windows.Forms.Label lblItem6;
        private System.Windows.Forms.Label lblItem5;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Panel pnlAnimals;
        private System.Windows.Forms.Label lblAnimal1;
        private System.Windows.Forms.Label lblAnimal3;
        private System.Windows.Forms.Label lblAnimal2;
        private System.Windows.Forms.Button btnExitAnimals;
        private System.Windows.Forms.Button btnSwitch2;
        private System.Windows.Forms.Button btnSwitch1;
        private System.Windows.Forms.Button btnUsedItem6;
        private System.Windows.Forms.Button btnUsedItem5;
        private System.Windows.Forms.Button btnUsedItem4;
        private System.Windows.Forms.Button btnUseItem3;
        private System.Windows.Forms.Button btnUseItem2;
        private System.Windows.Forms.Button btnUseItem1;
        private System.Windows.Forms.ProgressBar enemyHealthBar;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.Label lblAttack3;
        private System.Windows.Forms.Label lblAttack2;
        private System.Windows.Forms.Label lblAttack1;
    }
}

