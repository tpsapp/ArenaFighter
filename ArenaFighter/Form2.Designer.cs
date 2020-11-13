namespace ArenaFighter
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderAmount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.playerGold = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.oldArmorLabel = new System.Windows.Forms.Label();
            this.oldWeaponLabel = new System.Windows.Forms.Label();
            this.cartList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buyDagger = new System.Windows.Forms.Button();
            this.buyClub = new System.Windows.Forms.Button();
            this.buyStaff = new System.Windows.Forms.Button();
            this.buySword = new System.Windows.Forms.Button();
            this.buyMace = new System.Windows.Forms.Button();
            this.buySteelSword = new System.Windows.Forms.Button();
            this.buySteelmace = new System.Windows.Forms.Button();
            this.buySilverSword = new System.Windows.Forms.Button();
            this.buySilverMace = new System.Windows.Forms.Button();
            this.buyGoldSword = new System.Windows.Forms.Button();
            this.buyGoldMace = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.buyCloth = new System.Windows.Forms.Button();
            this.buyLeather = new System.Windows.Forms.Button();
            this.buyChain = new System.Windows.Forms.Button();
            this.buyPlate = new System.Windows.Forms.Button();
            this.buyScale = new System.Windows.Forms.Button();
            this.buySteelChain = new System.Windows.Forms.Button();
            this.buySteelPlate = new System.Windows.Forms.Button();
            this.buySteelScale = new System.Windows.Forms.Button();
            this.buyTChain = new System.Windows.Forms.Button();
            this.buyTPlate = new System.Windows.Forms.Button();
            this.buyTScale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buyPotion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cartList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.orderAmount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items for Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderAmount
            // 
            this.orderAmount.AutoSize = true;
            this.orderAmount.Location = new System.Drawing.Point(109, 6);
            this.orderAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.orderAmount.Name = "orderAmount";
            this.orderAmount.Size = new System.Drawing.Size(84, 13);
            this.orderAmount.TabIndex = 1;
            this.orderAmount.Text = "Order Amount: 0";
            this.orderAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.playerGold);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(298, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(289, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Items in Cart";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerGold
            // 
            this.playerGold.AutoSize = true;
            this.playerGold.Location = new System.Drawing.Point(109, 6);
            this.playerGold.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.playerGold.Name = "playerGold";
            this.playerGold.Size = new System.Drawing.Size(66, 13);
            this.playerGold.TabIndex = 1;
            this.playerGold.Text = "Your Gold: 0";
            this.playerGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.cancelButton);
            this.flowLayoutPanel3.Controls.Add(this.checkoutButton);
            this.flowLayoutPanel3.Controls.Add(this.oldArmorLabel);
            this.flowLayoutPanel3.Controls.Add(this.oldWeaponLabel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 536);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(584, 29);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(506, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Enabled = false;
            this.checkoutButton.Location = new System.Drawing.Point(425, 3);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(75, 23);
            this.checkoutButton.TabIndex = 24;
            this.checkoutButton.Text = "&Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // oldArmorLabel
            // 
            this.oldArmorLabel.AutoSize = true;
            this.oldArmorLabel.Location = new System.Drawing.Point(316, 8);
            this.oldArmorLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.oldArmorLabel.Name = "oldArmorLabel";
            this.oldArmorLabel.Size = new System.Drawing.Size(103, 13);
            this.oldArmorLabel.TabIndex = 2;
            this.oldArmorLabel.Text = "Current Armor: None";
            this.oldArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oldArmorLabel.Visible = false;
            // 
            // oldWeaponLabel
            // 
            this.oldWeaponLabel.AutoSize = true;
            this.oldWeaponLabel.Location = new System.Drawing.Point(193, 8);
            this.oldWeaponLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.oldWeaponLabel.Name = "oldWeaponLabel";
            this.oldWeaponLabel.Size = new System.Drawing.Size(117, 13);
            this.oldWeaponLabel.TabIndex = 3;
            this.oldWeaponLabel.Text = "Current Weapon: None";
            this.oldWeaponLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oldWeaponLabel.Visible = false;
            // 
            // cartList
            // 
            this.cartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartList.FormattingEnabled = true;
            this.cartList.Location = new System.Drawing.Point(298, 38);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(289, 492);
            this.cartList.TabIndex = 6;
            this.cartList.DoubleClick += new System.EventHandler(this.cartList_DoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.6263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.3737F));
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buyPotion, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 492);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 230);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Weapons\t\tModifier\tPrice\nDagger\t\t1\t2\nClub\t\t2\t6\nStaff\t\t3\t50\nSword\t\t4\t150\nMace\t\t5\t30" +
                "0\nSteel Sword\t6\t600\nSteel Mace\t7\t900\nSilver Sword\t8\t1500\nSilver Mace\t9\t2400\nGold" +
                " Sword\t10\t3900\nGold Mace\t11\t6300";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.buyDagger);
            this.flowLayoutPanel4.Controls.Add(this.buyClub);
            this.flowLayoutPanel4.Controls.Add(this.buyStaff);
            this.flowLayoutPanel4.Controls.Add(this.buySword);
            this.flowLayoutPanel4.Controls.Add(this.buyMace);
            this.flowLayoutPanel4.Controls.Add(this.buySteelSword);
            this.flowLayoutPanel4.Controls.Add(this.buySteelmace);
            this.flowLayoutPanel4.Controls.Add(this.buySilverSword);
            this.flowLayoutPanel4.Controls.Add(this.buySilverMace);
            this.flowLayoutPanel4.Controls.Add(this.buyGoldSword);
            this.flowLayoutPanel4.Controls.Add(this.buyGoldMace);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(77, 230);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // buyDagger
            // 
            this.buyDagger.Location = new System.Drawing.Point(0, 0);
            this.buyDagger.Margin = new System.Windows.Forms.Padding(0);
            this.buyDagger.Name = "buyDagger";
            this.buyDagger.Size = new System.Drawing.Size(75, 20);
            this.buyDagger.TabIndex = 2;
            this.buyDagger.Text = "Dagger";
            this.buyDagger.UseVisualStyleBackColor = true;
            this.buyDagger.Click += new System.EventHandler(this.buyDagger_Click);
            // 
            // buyClub
            // 
            this.buyClub.Location = new System.Drawing.Point(0, 20);
            this.buyClub.Margin = new System.Windows.Forms.Padding(0);
            this.buyClub.Name = "buyClub";
            this.buyClub.Size = new System.Drawing.Size(75, 20);
            this.buyClub.TabIndex = 3;
            this.buyClub.Text = "Club";
            this.buyClub.UseVisualStyleBackColor = true;
            this.buyClub.Click += new System.EventHandler(this.buyClub_Click);
            // 
            // buyStaff
            // 
            this.buyStaff.Location = new System.Drawing.Point(0, 40);
            this.buyStaff.Margin = new System.Windows.Forms.Padding(0);
            this.buyStaff.Name = "buyStaff";
            this.buyStaff.Size = new System.Drawing.Size(75, 20);
            this.buyStaff.TabIndex = 4;
            this.buyStaff.Text = "Staff";
            this.buyStaff.UseVisualStyleBackColor = true;
            this.buyStaff.Click += new System.EventHandler(this.buyStaff_Click);
            // 
            // buySword
            // 
            this.buySword.Location = new System.Drawing.Point(0, 60);
            this.buySword.Margin = new System.Windows.Forms.Padding(0);
            this.buySword.Name = "buySword";
            this.buySword.Size = new System.Drawing.Size(75, 20);
            this.buySword.TabIndex = 5;
            this.buySword.Text = "Sword";
            this.buySword.UseVisualStyleBackColor = true;
            this.buySword.Click += new System.EventHandler(this.buySword_Click);
            // 
            // buyMace
            // 
            this.buyMace.Location = new System.Drawing.Point(0, 80);
            this.buyMace.Margin = new System.Windows.Forms.Padding(0);
            this.buyMace.Name = "buyMace";
            this.buyMace.Size = new System.Drawing.Size(75, 20);
            this.buyMace.TabIndex = 6;
            this.buyMace.Text = "Mace";
            this.buyMace.UseVisualStyleBackColor = true;
            this.buyMace.Click += new System.EventHandler(this.buyMace_Click);
            // 
            // buySteelSword
            // 
            this.buySteelSword.Location = new System.Drawing.Point(0, 100);
            this.buySteelSword.Margin = new System.Windows.Forms.Padding(0);
            this.buySteelSword.Name = "buySteelSword";
            this.buySteelSword.Size = new System.Drawing.Size(75, 20);
            this.buySteelSword.TabIndex = 7;
            this.buySteelSword.Text = "Steel Sword";
            this.buySteelSword.UseVisualStyleBackColor = true;
            this.buySteelSword.Click += new System.EventHandler(this.buySteelSword_Click);
            // 
            // buySteelmace
            // 
            this.buySteelmace.Location = new System.Drawing.Point(0, 120);
            this.buySteelmace.Margin = new System.Windows.Forms.Padding(0);
            this.buySteelmace.Name = "buySteelmace";
            this.buySteelmace.Size = new System.Drawing.Size(75, 20);
            this.buySteelmace.TabIndex = 12;
            this.buySteelmace.Text = "Steel Mace";
            this.buySteelmace.UseVisualStyleBackColor = true;
            this.buySteelmace.Click += new System.EventHandler(this.buySteelmace_Click);
            // 
            // buySilverSword
            // 
            this.buySilverSword.Location = new System.Drawing.Point(0, 140);
            this.buySilverSword.Margin = new System.Windows.Forms.Padding(0);
            this.buySilverSword.Name = "buySilverSword";
            this.buySilverSword.Size = new System.Drawing.Size(75, 20);
            this.buySilverSword.TabIndex = 8;
            this.buySilverSword.Text = "Silver Sword";
            this.buySilverSword.UseVisualStyleBackColor = true;
            this.buySilverSword.Click += new System.EventHandler(this.buySilverSword_Click);
            // 
            // buySilverMace
            // 
            this.buySilverMace.Location = new System.Drawing.Point(0, 160);
            this.buySilverMace.Margin = new System.Windows.Forms.Padding(0);
            this.buySilverMace.Name = "buySilverMace";
            this.buySilverMace.Size = new System.Drawing.Size(75, 20);
            this.buySilverMace.TabIndex = 9;
            this.buySilverMace.Text = "Silver Mace";
            this.buySilverMace.UseVisualStyleBackColor = true;
            this.buySilverMace.Click += new System.EventHandler(this.buySilverMace_Click);
            // 
            // buyGoldSword
            // 
            this.buyGoldSword.Location = new System.Drawing.Point(0, 180);
            this.buyGoldSword.Margin = new System.Windows.Forms.Padding(0);
            this.buyGoldSword.Name = "buyGoldSword";
            this.buyGoldSword.Size = new System.Drawing.Size(75, 20);
            this.buyGoldSword.TabIndex = 10;
            this.buyGoldSword.Text = "Gold Sword";
            this.buyGoldSword.UseVisualStyleBackColor = true;
            this.buyGoldSword.Click += new System.EventHandler(this.buyGoldSword_Click);
            // 
            // buyGoldMace
            // 
            this.buyGoldMace.Location = new System.Drawing.Point(0, 200);
            this.buyGoldMace.Margin = new System.Windows.Forms.Padding(0);
            this.buyGoldMace.Name = "buyGoldMace";
            this.buyGoldMace.Size = new System.Drawing.Size(75, 20);
            this.buyGoldMace.TabIndex = 11;
            this.buyGoldMace.Text = "Gold Mace";
            this.buyGoldMace.UseVisualStyleBackColor = true;
            this.buyGoldMace.Click += new System.EventHandler(this.buyGoldMace_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 239);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(200, 230);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.buyCloth);
            this.flowLayoutPanel5.Controls.Add(this.buyLeather);
            this.flowLayoutPanel5.Controls.Add(this.buyChain);
            this.flowLayoutPanel5.Controls.Add(this.buyPlate);
            this.flowLayoutPanel5.Controls.Add(this.buyScale);
            this.flowLayoutPanel5.Controls.Add(this.buySteelChain);
            this.flowLayoutPanel5.Controls.Add(this.buySteelPlate);
            this.flowLayoutPanel5.Controls.Add(this.buySteelScale);
            this.flowLayoutPanel5.Controls.Add(this.buyTChain);
            this.flowLayoutPanel5.Controls.Add(this.buyTPlate);
            this.flowLayoutPanel5.Controls.Add(this.buyTScale);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(209, 239);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(77, 230);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // buyCloth
            // 
            this.buyCloth.Location = new System.Drawing.Point(0, 0);
            this.buyCloth.Margin = new System.Windows.Forms.Padding(0);
            this.buyCloth.Name = "buyCloth";
            this.buyCloth.Size = new System.Drawing.Size(75, 20);
            this.buyCloth.TabIndex = 12;
            this.buyCloth.Text = "Cloth";
            this.buyCloth.UseVisualStyleBackColor = true;
            this.buyCloth.Click += new System.EventHandler(this.buyCloth_Click);
            // 
            // buyLeather
            // 
            this.buyLeather.Location = new System.Drawing.Point(0, 20);
            this.buyLeather.Margin = new System.Windows.Forms.Padding(0);
            this.buyLeather.Name = "buyLeather";
            this.buyLeather.Size = new System.Drawing.Size(75, 20);
            this.buyLeather.TabIndex = 13;
            this.buyLeather.Text = "Leather";
            this.buyLeather.UseVisualStyleBackColor = true;
            this.buyLeather.Click += new System.EventHandler(this.buyLeather_Click);
            // 
            // buyChain
            // 
            this.buyChain.Location = new System.Drawing.Point(0, 40);
            this.buyChain.Margin = new System.Windows.Forms.Padding(0);
            this.buyChain.Name = "buyChain";
            this.buyChain.Size = new System.Drawing.Size(75, 20);
            this.buyChain.TabIndex = 14;
            this.buyChain.Text = "Chain";
            this.buyChain.UseVisualStyleBackColor = true;
            this.buyChain.Click += new System.EventHandler(this.buyChain_Click);
            // 
            // buyPlate
            // 
            this.buyPlate.Location = new System.Drawing.Point(0, 60);
            this.buyPlate.Margin = new System.Windows.Forms.Padding(0);
            this.buyPlate.Name = "buyPlate";
            this.buyPlate.Size = new System.Drawing.Size(75, 20);
            this.buyPlate.TabIndex = 15;
            this.buyPlate.Text = "Plate";
            this.buyPlate.UseVisualStyleBackColor = true;
            this.buyPlate.Click += new System.EventHandler(this.buyPlate_Click);
            // 
            // buyScale
            // 
            this.buyScale.Location = new System.Drawing.Point(0, 80);
            this.buyScale.Margin = new System.Windows.Forms.Padding(0);
            this.buyScale.Name = "buyScale";
            this.buyScale.Size = new System.Drawing.Size(75, 20);
            this.buyScale.TabIndex = 16;
            this.buyScale.Text = "Scale";
            this.buyScale.UseVisualStyleBackColor = true;
            this.buyScale.Click += new System.EventHandler(this.buyScale_Click);
            // 
            // buySteelChain
            // 
            this.buySteelChain.Location = new System.Drawing.Point(0, 100);
            this.buySteelChain.Margin = new System.Windows.Forms.Padding(0);
            this.buySteelChain.Name = "buySteelChain";
            this.buySteelChain.Size = new System.Drawing.Size(75, 20);
            this.buySteelChain.TabIndex = 17;
            this.buySteelChain.Text = "Steel Chain";
            this.buySteelChain.UseVisualStyleBackColor = true;
            this.buySteelChain.Click += new System.EventHandler(this.buySteelChain_Click);
            // 
            // buySteelPlate
            // 
            this.buySteelPlate.Location = new System.Drawing.Point(0, 120);
            this.buySteelPlate.Margin = new System.Windows.Forms.Padding(0);
            this.buySteelPlate.Name = "buySteelPlate";
            this.buySteelPlate.Size = new System.Drawing.Size(75, 20);
            this.buySteelPlate.TabIndex = 18;
            this.buySteelPlate.Text = "Steel Plate";
            this.buySteelPlate.UseVisualStyleBackColor = true;
            this.buySteelPlate.Click += new System.EventHandler(this.buySteelPlate_Click);
            // 
            // buySteelScale
            // 
            this.buySteelScale.Location = new System.Drawing.Point(0, 140);
            this.buySteelScale.Margin = new System.Windows.Forms.Padding(0);
            this.buySteelScale.Name = "buySteelScale";
            this.buySteelScale.Size = new System.Drawing.Size(75, 20);
            this.buySteelScale.TabIndex = 19;
            this.buySteelScale.Text = "Steel Scale";
            this.buySteelScale.UseVisualStyleBackColor = true;
            this.buySteelScale.Click += new System.EventHandler(this.buySteelScale_Click);
            // 
            // buyTChain
            // 
            this.buyTChain.Location = new System.Drawing.Point(0, 160);
            this.buyTChain.Margin = new System.Windows.Forms.Padding(0);
            this.buyTChain.Name = "buyTChain";
            this.buyTChain.Size = new System.Drawing.Size(75, 20);
            this.buyTChain.TabIndex = 20;
            this.buyTChain.Text = "T. Chain";
            this.buyTChain.UseVisualStyleBackColor = true;
            this.buyTChain.Click += new System.EventHandler(this.buyTChain_Click);
            // 
            // buyTPlate
            // 
            this.buyTPlate.Location = new System.Drawing.Point(0, 180);
            this.buyTPlate.Margin = new System.Windows.Forms.Padding(0);
            this.buyTPlate.Name = "buyTPlate";
            this.buyTPlate.Size = new System.Drawing.Size(75, 20);
            this.buyTPlate.TabIndex = 21;
            this.buyTPlate.Text = "T. Plate";
            this.buyTPlate.UseVisualStyleBackColor = true;
            this.buyTPlate.Click += new System.EventHandler(this.buyTPlate_Click);
            // 
            // buyTScale
            // 
            this.buyTScale.Location = new System.Drawing.Point(0, 200);
            this.buyTScale.Margin = new System.Windows.Forms.Padding(0);
            this.buyTScale.Name = "buyTScale";
            this.buyTScale.Size = new System.Drawing.Size(75, 20);
            this.buyTScale.TabIndex = 22;
            this.buyTScale.Text = "T. Scale";
            this.buyTScale.UseVisualStyleBackColor = true;
            this.buyTScale.Click += new System.EventHandler(this.buyTScale_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Health Potion cost 5g x Level each";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buyPotion
            // 
            this.buyPotion.Location = new System.Drawing.Point(206, 472);
            this.buyPotion.Margin = new System.Windows.Forms.Padding(0);
            this.buyPotion.Name = "buyPotion";
            this.buyPotion.Size = new System.Drawing.Size(75, 20);
            this.buyPotion.TabIndex = 23;
            this.buyPotion.Text = "Buy";
            this.buyPotion.UseVisualStyleBackColor = true;
            this.buyPotion.Click += new System.EventHandler(this.buyPotion_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.checkoutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(590, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arena Fighter - Shop";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Label orderAmount;
        private System.Windows.Forms.Label playerGold;
        public Form1 frm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button buyDagger;
        private System.Windows.Forms.Button buyClub;
        private System.Windows.Forms.Button buyStaff;
        private System.Windows.Forms.Button buySword;
        private System.Windows.Forms.Button buyMace;
        private System.Windows.Forms.Button buySteelSword;
        private System.Windows.Forms.Button buySteelmace;
        private System.Windows.Forms.Button buySilverSword;
        private System.Windows.Forms.Button buySilverMace;
        private System.Windows.Forms.Button buyGoldSword;
        private System.Windows.Forms.Button buyGoldMace;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button buyCloth;
        private System.Windows.Forms.Button buyLeather;
        private System.Windows.Forms.Button buyChain;
        private System.Windows.Forms.Button buyPlate;
        private System.Windows.Forms.Button buyScale;
        private System.Windows.Forms.Button buySteelChain;
        private System.Windows.Forms.Button buySteelPlate;
        private System.Windows.Forms.Button buySteelScale;
        private System.Windows.Forms.Button buyTChain;
        private System.Windows.Forms.Button buyTPlate;
        private System.Windows.Forms.Button buyTScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyPotion;
        private System.Windows.Forms.Label oldArmorLabel;
        private System.Windows.Forms.Label oldWeaponLabel;
    }
}