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
            this.pnlBattleOptions = new System.Windows.Forms.Panel();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlStore = new System.Windows.Forms.Panel();
            this.lblStoreList = new System.Windows.Forms.Label();
            this.lblShopTitle = new System.Windows.Forms.Label();
            this.lblMenuOptions = new System.Windows.Forms.Label();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInventoryListOutGame = new System.Windows.Forms.TextBox();
            this.pnlInventory.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBattle
            // 
            this.pnlBattle.BackColor = System.Drawing.Color.Gray;
            this.pnlBattle.Location = new System.Drawing.Point(551, 21);
            this.pnlBattle.Name = "pnlBattle";
            this.pnlBattle.Size = new System.Drawing.Size(299, 245);
            this.pnlBattle.TabIndex = 0;
            // 
            // pnlBattleOptions
            // 
            this.pnlBattleOptions.Location = new System.Drawing.Point(386, 243);
            this.pnlBattleOptions.Name = "pnlBattleOptions";
            this.pnlBattleOptions.Size = new System.Drawing.Size(505, 166);
            this.pnlBattleOptions.TabIndex = 0;
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlInventory.Controls.Add(this.pnlMenu);
            this.pnlInventory.Controls.Add(this.txtInventoryListOutGame);
            this.pnlInventory.Controls.Add(this.pnlBattleOptions);
            this.pnlInventory.Location = new System.Drawing.Point(-1, 0);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(380, 412);
            this.pnlInventory.TabIndex = 1;
            this.pnlInventory.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.pnlStore);
            this.pnlMenu.Controls.Add(this.lblMenuOptions);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Location = new System.Drawing.Point(3, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(377, 415);
            this.pnlMenu.TabIndex = 2;
            this.pnlMenu.Visible = false;
            // 
            // pnlStore
            // 
            this.pnlStore.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlStore.Controls.Add(this.lblStoreList);
            this.pnlStore.Controls.Add(this.lblShopTitle);
            this.pnlStore.Location = new System.Drawing.Point(-3, 0);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Size = new System.Drawing.Size(380, 412);
            this.pnlStore.TabIndex = 3;
            // 
            // lblStoreList
            // 
            this.lblStoreList.AutoSize = true;
            this.lblStoreList.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreList.Location = new System.Drawing.Point(26, 55);
            this.lblStoreList.Name = "lblStoreList";
            this.lblStoreList.Size = new System.Drawing.Size(54, 20);
            this.lblStoreList.TabIndex = 4;
            this.lblStoreList.Text = "label1";
            // 
            // lblShopTitle
            // 
            this.lblShopTitle.AutoSize = true;
            this.lblShopTitle.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopTitle.Location = new System.Drawing.Point(135, 6);
            this.lblShopTitle.Name = "lblShopTitle";
            this.lblShopTitle.Size = new System.Drawing.Size(110, 40);
            this.lblShopTitle.TabIndex = 3;
            this.lblShopTitle.Text = "STORE";
            // 
            // lblMenuOptions
            // 
            this.lblMenuOptions.AutoSize = true;
            this.lblMenuOptions.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuOptions.Location = new System.Drawing.Point(21, 61);
            this.lblMenuOptions.Name = "lblMenuOptions";
            this.lblMenuOptions.Size = new System.Drawing.Size(54, 20);
            this.lblMenuOptions.TabIndex = 2;
            this.lblMenuOptions.Text = "label1";
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.Location = new System.Drawing.Point(123, 6);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(107, 40);
            this.lblMenuTitle.TabIndex = 1;
            this.lblMenuTitle.Text = "MENU";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(386, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 166);
            this.panel2.TabIndex = 0;
            // 
            // txtInventoryListOutGame
            // 
            this.txtInventoryListOutGame.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryListOutGame.Location = new System.Drawing.Point(29, 87);
            this.txtInventoryListOutGame.Multiline = true;
            this.txtInventoryListOutGame.Name = "txtInventoryListOutGame";
            this.txtInventoryListOutGame.ReadOnly = true;
            this.txtInventoryListOutGame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInventoryListOutGame.Size = new System.Drawing.Size(314, 312);
            this.txtInventoryListOutGame.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 411);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlBattle);
            this.Name = "Form1";
            this.Text = "a";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlStore.ResumeLayout(false);
            this.pnlStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBattle;
        private System.Windows.Forms.Panel pnlBattleOptions;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.TextBox txtInventoryListOutGame;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMenuOptions;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Panel pnlStore;
        private System.Windows.Forms.Label lblStoreList;
        private System.Windows.Forms.Label lblShopTitle;
    }
}

