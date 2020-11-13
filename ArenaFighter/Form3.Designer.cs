namespace ArenaFighter
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.sexCombo = new System.Windows.Forms.ComboBox();
            this.startingGold = new System.Windows.Forms.TextBox();
            this.startingHealth = new System.Windows.Forms.TextBox();
            this.startingStrength = new System.Windows.Forms.TextBox();
            this.startingAgility = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rollGold = new System.Windows.Forms.Button();
            this.rollHealth = new System.Windows.Forms.Button();
            this.rollStrength = new System.Windows.Forms.Button();
            this.rollAgility = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.discardPlayer = new System.Windows.Forms.Button();
            this.keepPlayer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New player creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex?";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(90, 41);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 1;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(90, 67);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 2;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // sexCombo
            // 
            this.sexCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sexCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sexCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCombo.FormattingEnabled = true;
            this.sexCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexCombo.Location = new System.Drawing.Point(90, 93);
            this.sexCombo.Name = "sexCombo";
            this.sexCombo.Size = new System.Drawing.Size(100, 21);
            this.sexCombo.TabIndex = 3;
            this.sexCombo.SelectedIndexChanged += new System.EventHandler(this.sexCombo_SelectedIndexChanged);
            // 
            // startingGold
            // 
            this.startingGold.BackColor = System.Drawing.Color.White;
            this.startingGold.Enabled = false;
            this.startingGold.Location = new System.Drawing.Point(90, 120);
            this.startingGold.Name = "startingGold";
            this.startingGold.Size = new System.Drawing.Size(100, 20);
            this.startingGold.TabIndex = 11;
            // 
            // startingHealth
            // 
            this.startingHealth.BackColor = System.Drawing.Color.White;
            this.startingHealth.Enabled = false;
            this.startingHealth.Location = new System.Drawing.Point(90, 146);
            this.startingHealth.Name = "startingHealth";
            this.startingHealth.Size = new System.Drawing.Size(100, 20);
            this.startingHealth.TabIndex = 12;
            // 
            // startingStrength
            // 
            this.startingStrength.BackColor = System.Drawing.Color.White;
            this.startingStrength.Enabled = false;
            this.startingStrength.Location = new System.Drawing.Point(90, 172);
            this.startingStrength.Name = "startingStrength";
            this.startingStrength.Size = new System.Drawing.Size(100, 20);
            this.startingStrength.TabIndex = 13;
            // 
            // startingAgility
            // 
            this.startingAgility.BackColor = System.Drawing.Color.White;
            this.startingAgility.Enabled = false;
            this.startingAgility.Location = new System.Drawing.Point(90, 198);
            this.startingAgility.Name = "startingAgility";
            this.startingAgility.Size = new System.Drawing.Size(100, 20);
            this.startingAgility.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Starting Gold:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Health:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Strength:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Agility:";
            // 
            // rollGold
            // 
            this.rollGold.Location = new System.Drawing.Point(196, 120);
            this.rollGold.Name = "rollGold";
            this.rollGold.Size = new System.Drawing.Size(75, 23);
            this.rollGold.TabIndex = 4;
            this.rollGold.Text = "Roll";
            this.rollGold.UseVisualStyleBackColor = true;
            this.rollGold.Click += new System.EventHandler(this.rollGold_Click);
            // 
            // rollHealth
            // 
            this.rollHealth.Location = new System.Drawing.Point(196, 146);
            this.rollHealth.Name = "rollHealth";
            this.rollHealth.Size = new System.Drawing.Size(75, 23);
            this.rollHealth.TabIndex = 5;
            this.rollHealth.Text = "Roll";
            this.rollHealth.UseVisualStyleBackColor = true;
            this.rollHealth.Click += new System.EventHandler(this.rollHealth_Click);
            // 
            // rollStrength
            // 
            this.rollStrength.Location = new System.Drawing.Point(196, 172);
            this.rollStrength.Name = "rollStrength";
            this.rollStrength.Size = new System.Drawing.Size(75, 23);
            this.rollStrength.TabIndex = 6;
            this.rollStrength.Text = "Roll";
            this.rollStrength.UseVisualStyleBackColor = true;
            this.rollStrength.Click += new System.EventHandler(this.rollStrength_Click);
            // 
            // rollAgility
            // 
            this.rollAgility.Location = new System.Drawing.Point(196, 198);
            this.rollAgility.Name = "rollAgility";
            this.rollAgility.Size = new System.Drawing.Size(75, 23);
            this.rollAgility.TabIndex = 7;
            this.rollAgility.Text = "Roll";
            this.rollAgility.UseVisualStyleBackColor = true;
            this.rollAgility.Click += new System.EventHandler(this.rollAgility_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(216, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // discardPlayer
            // 
            this.discardPlayer.Enabled = false;
            this.discardPlayer.Location = new System.Drawing.Point(135, 3);
            this.discardPlayer.Name = "discardPlayer";
            this.discardPlayer.Size = new System.Drawing.Size(75, 23);
            this.discardPlayer.TabIndex = 9;
            this.discardPlayer.Text = "&Discard";
            this.discardPlayer.UseVisualStyleBackColor = true;
            this.discardPlayer.Click += new System.EventHandler(this.discardPlayer_Click);
            // 
            // keepPlayer
            // 
            this.keepPlayer.Enabled = false;
            this.keepPlayer.Location = new System.Drawing.Point(54, 3);
            this.keepPlayer.Name = "keepPlayer";
            this.keepPlayer.Size = new System.Drawing.Size(75, 23);
            this.keepPlayer.TabIndex = 8;
            this.keepPlayer.Text = "&Keep";
            this.keepPlayer.UseVisualStyleBackColor = true;
            this.keepPlayer.Click += new System.EventHandler(this.keepPlayer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.discardPlayer);
            this.flowLayoutPanel1.Controls.Add(this.keepPlayer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 237);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 35);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // Form3
            // 
            this.AcceptButton = this.keepPlayer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rollAgility);
            this.Controls.Add(this.rollStrength);
            this.Controls.Add(this.rollHealth);
            this.Controls.Add(this.rollGold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startingAgility);
            this.Controls.Add(this.startingStrength);
            this.Controls.Add(this.startingHealth);
            this.Controls.Add(this.startingGold);
            this.Controls.Add(this.sexCombo);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arena Fighter - New Player";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.ComboBox sexCombo;
        private System.Windows.Forms.TextBox startingGold;
        private System.Windows.Forms.TextBox startingHealth;
        private System.Windows.Forms.TextBox startingStrength;
        private System.Windows.Forms.TextBox startingAgility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rollGold;
        private System.Windows.Forms.Button rollHealth;
        private System.Windows.Forms.Button rollStrength;
        private System.Windows.Forms.Button rollAgility;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button discardPlayer;
        private System.Windows.Forms.Button keepPlayer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Form1 frm1;
    }
}