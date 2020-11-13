using System;
using System.Windows.Forms;

namespace ArenaFighter
{
    public partial class Form3 : Form
    {
        Random randomizer = new Random();

        public int Rolld6(int numtimes)
        {
            int result = 0;
            for (int i = 0; i < numtimes; i++)
            {
                result += randomizer.Next(1, 7);
            }

            return result;
        }

        public Form3(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rollGold_Click(object sender, EventArgs e)
        {
            startingGold.Text = Rolld6(2).ToString();
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
            rollGold.Enabled = false;
        }

        private void rollHealth_Click(object sender, EventArgs e)
        {
            startingHealth.Text = Rolld6(2).ToString();
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
            rollHealth.Enabled = false;
        }

        private void rollStrength_Click(object sender, EventArgs e)
        {
            startingStrength.Text = Rolld6(2).ToString();
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
            rollStrength.Enabled = false;
        }

        private void rollAgility_Click(object sender, EventArgs e)
        {
            startingAgility.Text = Rolld6(2).ToString();
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
            rollAgility.Enabled = false;
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
        }

        private void sexCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!keepPlayer.Enabled || !discardPlayer.Enabled)
            {
                keepPlayer.Enabled = true;
                discardPlayer.Enabled = true;
            }
        }

        private void discardPlayer_Click(object sender, EventArgs e)
        {
            startingAgility.Text = "";
            startingGold.Text = "";
            startingHealth.Text = "";
            startingStrength.Text = "";
            firstName.Text = "";
            lastName.Text = "";
            sexCombo.SelectedIndex = 0;
            keepPlayer.Enabled = false;
            discardPlayer.Enabled = false;
            rollGold.Enabled = true;
            rollAgility.Enabled = true;
            rollHealth.Enabled = true;
            rollStrength.Enabled = true;
        }

        private void keepPlayer_Click(object sender, EventArgs e)
        {
            if ((firstName.Text == "") || (sexCombo.Text == "") || (startingAgility.Text == "") || (startingGold.Text == "") || (startingHealth.Text == "") || (startingStrength.Text == ""))
            {
                MessageBox.Show("Please fill in all the fields.", "Error on form!", MessageBoxButtons.OK);
            }
            else
            {
                frm1.ClearPlayer();
                frm1.currPName = firstName.Text + " " + lastName.Text;
                frm1.currPSex = sexCombo.Text;
                frm1.currPLevel = 1;
                frm1.currPExp = 0;
                frm1.currPGold = Convert.ToInt16(startingGold.Text);
                frm1.currPHealth = Convert.ToInt16(startingHealth.Text);
                frm1.currPMaxHealth = Convert.ToInt16(startingHealth.Text);
                frm1.currPStrength = Convert.ToInt16(startingStrength.Text);
                frm1.currPAgility = Convert.ToInt16(startingAgility.Text);
                frm1.currPWeapon = 0;
                frm1.currPArmor = 0;
                frm1.currPPotions = 0;
                frm1.shopButton.Enabled = true;
                frm1.savePlayer.Enabled = true;
                frm1.newFight.Enabled = true;
                frm1.AcceptButton = frm1.newFight;
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sexCombo.SelectedIndex = 0;
            keepPlayer.Enabled = false;
            discardPlayer.Enabled = false;
        }
    }
}
