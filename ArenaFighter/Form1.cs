using System;
using System.IO;
using System.Windows.Forms;

namespace ArenaFighter
{
    public partial class Form1 : Form
    {
        //Player variables
        public int currPLevel, currPExp, currPGold, currPHealth, currPMaxHealth, currPStrength, currPAgility, currPWeapon, currPArmor, currPPotions;
        public string currPName, currPSex;

        //Opponent Variables
        private int currOLevel, currOGold, currOHealth, currOMaxHealth, currOStrength, currOAgility, currOWeapon, currOArmor, currOPotions;
        private string currOName, currOSex;

        Random randomizer = new Random();

        public void FillPlayerInfo()
        {
            playerName.Text = currPName;
            playerSex.Text = currPSex;
            playerLevel.Text = currPLevel.ToString();
            playerExp.Text = currPExp.ToString();
            playerGold.Text = currPGold.ToString();
            playerHealth.Text = currPHealth.ToString();
            playerMaxHealth.Text = currPMaxHealth.ToString();
            playerStrength.Text = currPStrength.ToString();
            playerAgility.Text = currPAgility.ToString();
            playerWeapon.Text = GetWeapon(currPWeapon);
            playerArmor.Text = GetArmor(currPArmor);
            playerPotions.Text = currPPotions.ToString();
        }

        public void FillOpponentInfo()
        {
            opponentName.Text = currOName;
            opponentSex.Text = currOSex;
            opponentLevel.Text = currOLevel.ToString();
            opponentGold.Text = currOGold.ToString();
            opponentHealth.Text = currOHealth.ToString();
            opponentMaxHealth.Text = currOMaxHealth.ToString();
            opponentStrength.Text = currOStrength.ToString();
            opponentAgility.Text = currOAgility.ToString();
            opponentWeapon.Text = GetWeapon(currOWeapon);
            opponentArmor.Text = GetArmor(currOArmor);
            opponentPotions.Text = currOPotions.ToString();
        }

        public void ClearPlayer()
        {
            playerName.Text = "";
            playerSex.Text = "";
            playerLevel.Text = "";
            playerExp.Text = "";
            playerGold.Text = "";
            playerHealth.Text = "";
            playerMaxHealth.Text = "";
            playerStrength.Text = "";
            playerAgility.Text = "";
            playerWeapon.Text = "";
            playerArmor.Text = "";
            playerPotions.Text = "";
            currPLevel = currPExp = currPGold = currPHealth = currPMaxHealth = currPStrength = currPAgility = currPWeapon = currPArmor = currPPotions = 0;
            currPName = currPSex = String.Empty;
            playerResults.Items.Clear();
            ClearOpponent();
            attackButton.Enabled = false;
            drinkPotion.Enabled = false;
        }

        public void ClearOpponent()
        {
            opponentName.Text = "";
            opponentSex.Text = "";
            opponentLevel.Text = "";
            opponentExp.Text = "";
            opponentGold.Text = "";
            opponentHealth.Text = "";
            opponentMaxHealth.Text = "";
            opponentStrength.Text = "";
            opponentAgility.Text = "";
            opponentWeapon.Text = "";
            opponentArmor.Text = "";
            opponentPotions.Text = "";
            opponentResults.Items.Clear();
            currOLevel = currOGold = currOHealth = currOMaxHealth = currOStrength = currOAgility = currOWeapon = currOArmor = currOPotions = 0;
            currOName = currOSex = String.Empty;
        }

        private void SaveCharacter()
        {
            saveFileDialog1.FileName = currPName + ".dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter characterFile = new StreamWriter(saveFileDialog1.FileName);
                characterFile.WriteLine(currPName);
                characterFile.WriteLine(currPSex);
                characterFile.WriteLine(currPLevel);
                characterFile.WriteLine(currPExp);
                characterFile.WriteLine(currPGold);
                characterFile.WriteLine(currPHealth);
                characterFile.WriteLine(currPMaxHealth);
                characterFile.WriteLine(currPStrength);
                characterFile.WriteLine(currPAgility);
                characterFile.WriteLine(currPWeapon);
                characterFile.WriteLine(currPArmor);
                characterFile.WriteLine(currPPotions);
                characterFile.Close();
            }
        }

        private void LoadCharacter()
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextReader characterFile = new StreamReader(openFileDialog1.FileName);
                ClearPlayer();
                currPName = characterFile.ReadLine();
                currPSex = characterFile.ReadLine();
                currPLevel = Convert.ToInt16(characterFile.ReadLine());
                currPExp = Convert.ToInt16(characterFile.ReadLine());
                currPGold = Convert.ToInt16(characterFile.ReadLine());
                currPHealth = Convert.ToInt16(characterFile.ReadLine());
                currPMaxHealth = Convert.ToInt16(characterFile.ReadLine());
                currPStrength = Convert.ToInt16(characterFile.ReadLine());
                currPAgility = Convert.ToInt16(characterFile.ReadLine());
                currPWeapon = Convert.ToInt16(characterFile.ReadLine());
                currPArmor = Convert.ToInt16(characterFile.ReadLine());
                currPPotions = Convert.ToInt16(characterFile.ReadLine());
                characterFile.Close();
                FillPlayerInfo();
                savePlayer.Enabled = true;
                shopButton.Enabled = true;
                newFight.Enabled = true;
            }
        }

        private void CreateOpponent()
        {
            ClearOpponent();
            currOName = "Enemy Gladiator";
            switch (randomizer.Next(1, 3))
            {
                case 1:
                    {
                        currOSex = "Male";
                    }
                    break;
                case 2:
                    {
                        currOSex = "Female";
                    }
                    break;
                default:
                    {
                        currOSex = "Male";
                    }
                    break;
            }
            currOLevel = currPLevel + randomizer.Next(2);
            currOGold = Rolld6(1) * currOLevel;
            currOHealth = Rolld6(2);
            if (currOLevel > 1)
            {
                for (int i = 0; i < currOLevel - 1; i++)
                {
                    currOHealth += Rolld6(1);
                }
            }
            currOMaxHealth = currOHealth;
            currOStrength = Rolld6(2);
            if (currOLevel > 1)
            {
                for (int i = 0; i < currOLevel - 1; i++)
                {
                    currOStrength += Rolld6(1);
                }
            }
            currOAgility = Rolld6(2);
            if (currOLevel > 1)
            {
                for (int i = 0; i < currOLevel - 1; i++)
                {
                    currOAgility += Rolld6(1);
                }
            }
            currOWeapon = randomizer.Next(1, currOLevel + 2);
            currOArmor = randomizer.Next(1, currOLevel + 2);
            currOPotions = 0;
            FillOpponentInfo();
        }

        public int Rolld6(int numtimes)
        {
            int result = 0;
            for (int i = 0; i < numtimes; i++)
            {
                result += randomizer.Next(1, 7);
            }

            return result;
        }

        private void CheckLevelUp()
        {
            int newLevel = (currPExp / 100) + 1;
            if (newLevel > currPLevel)
            {
                currPHealth += Rolld6(1);
                currPStrength += Rolld6(1);
                currPAgility += Rolld6(1);
                currPLevel = newLevel;
                currPMaxHealth = currPHealth;
                FillPlayerInfo();
                MessageBox.Show("Congradulations, you are now level " + newLevel.ToString() + "!\nYou new attributes are " + currPHealth.ToString() + " health, " + currPStrength.ToString() + " strength, and " + currPAgility.ToString() + " agility.");
            }
        }

        private string GetWeapon(int weaponid)
        {
            switch (weaponid)
            {
                case 1:
                    {
                        return "Dagger";
                    }
                    break;
                case 2:
                    {
                        return "Club";
                    }
                    break;
                case 3:
                    {
                        return "Staff";
                    }
                    break;
                case 4:
                    {
                        return "Sword";
                    }
                    break;
                case 5:
                    {
                        return "Mace";
                    }
                    break;
                case 6:
                    {
                        return "Steel Sword";
                    }
                    break;
                case 7:
                    {
                        return "Steel Mace";
                    }
                    break;
                case 8:
                    {
                        return "Silver Sword";
                    }
                    break;
                case 9:
                    {
                        return "Silver Mace";
                    }
                    break;
                case 10:
                    {
                        return "Gold Sword";
                    }
                    break;
                case 11:
                    {
                        return "Gold Mace";
                    }
                    break;
                default:
                    {
                        return "None";
                    }
                    break;
            }
        }

        private string GetArmor(int armorid)
        {
            switch (armorid)
            {
                case 1:
                    {
                        return "Cloth";
                    }
                    break;
                case 2:
                    {
                        return "Leather";
                    }
                    break;
                case 3:
                    {
                        return "Chain";
                    }
                    break;
                case 4:
                    {
                        return "Splate";
                    }
                    break;
                case 5:
                    {
                        return "Scale";
                    }
                    break;
                case 6:
                    {
                        return "Steel Chain";
                    }
                    break;
                case 7:
                    {
                        return "Steel Plate";
                    }
                    break;
                case 8:
                    {
                        return "Steel Scale";
                    }
                    break;
                case 9:
                    {
                        return "Titanium Chain";
                    }
                    break;
                case 10:
                    {
                        return "Titanium Plate";
                    }
                    break;
                case 11:
                    {
                        return "Titanium Scale";
                    }
                    break;
                default:
                    {
                        return "None";
                    }
                    break;
            }
        }

        private int ToHit(int aAgility, int oAgility)
        {
            return (Rolld6(2) + aAgility) - oAgility;
        }

        private int AttackDmg(int aWeapon, int oArmor)
        {
            return (Rolld6(1) + aWeapon) - oArmor;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            Form frmShop = new Form2(this);
            frmShop.ShowDialog();
        }

        private void newPlayer_Click(object sender, EventArgs e)
        {
            Form frmNewPlayer = new Form3(this);
            frmNewPlayer.ShowDialog();
            FillPlayerInfo();
        }

        private void savePlayer_Click(object sender, EventArgs e)
        {
            SaveCharacter();
        }

        private void loadPlayer_Click(object sender, EventArgs e)
        {
            LoadCharacter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Form frmHelp = new Form4();
            frmHelp.ShowDialog();
        }

        private void newFight_Click(object sender, EventArgs e)
        {
            CreateOpponent();
            playerResults.Items.Clear();
            currPHealth = currPMaxHealth;
            FillPlayerInfo();
            attackButton.Enabled = true;
            if (currPPotions > 0)
            {
                drinkPotion.Enabled = true;
            }
            else
            {
                drinkPotion.Enabled = false;
            }
            shopButton.Enabled = false;
            this.AcceptButton = attackButton;
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            int playerAttack = ToHit(currPAgility, currOAgility);
            playerResults.Items.Add("Your ToHit: " + playerAttack.ToString());
            playerResults.SelectedIndex = playerResults.Items.Count - 1;
            if (currPPotions > 0)
            {
                drinkPotion.Enabled = true;
            }
            else
            {
                drinkPotion.Enabled = false;
            }
            if (playerAttack > 0)
            {
                int playerDamage = AttackDmg(currPWeapon, currOArmor);
                if (playerDamage <= 0)
                {
                    playerDamage = 1;
                }
                currOHealth -= playerDamage;
                playerResults.Items.Add("You do " + playerDamage.ToString() + " damage.");
                playerResults.SelectedIndex = playerResults.Items.Count - 1;
                opponentResults.Items.Add("Opponents health is now: " + currOHealth.ToString());
                opponentResults.SelectedIndex = opponentResults.Items.Count - 1;
                FillOpponentInfo();
            }
            if (currOHealth <= 0)
            {
                MessageBox.Show("You have defeated your opponent!");
                currPExp += currOLevel * 2;
                currPGold += currOGold;
                attackButton.Enabled = false;
                if (currPGold > 0)
                {
                    shopButton.Enabled = true;
                }
                else
                {
                    shopButton.Enabled = false;
                }
                drinkPotion.Enabled = false;
                this.AcceptButton = newFight;
                FillPlayerInfo();
                ClearOpponent();
            }
            else
            {
                int opponentAttack = ToHit(currOAgility, currPAgility);
                opponentResults.Items.Add("Opponents ToHit: " + opponentAttack.ToString());
                opponentResults.SelectedIndex = opponentResults.Items.Count - 1;
                if (opponentAttack > 0)
                {
                    int opponentDamage = AttackDmg(currOWeapon, currPArmor);
                    if (opponentDamage <= 0)
                    {
                        opponentDamage = 1;
                    }
                    currPHealth -= opponentDamage;
                    opponentResults.Items.Add("Opponent does " + opponentDamage.ToString() + " damage.");
                    opponentResults.SelectedIndex = opponentResults.Items.Count - 1;
                    playerResults.Items.Add("Your health is now: " + currPHealth.ToString());
                    playerResults.SelectedIndex = playerResults.Items.Count - 1;
                    FillPlayerInfo();
                }
            }
            if (currPHealth <= 0)
            {
                MessageBox.Show("You have been defeated.  You will need to either load an existing character, or create new one.");
                shopButton.Enabled = false;
                attackButton.Enabled = false;
                newFight.Enabled = false;
                savePlayer.Enabled = false;
                drinkPotion.Enabled = false;
                this.AcceptButton = newPlayer;
                ClearOpponent();
            }
            else
            {
                if (currPLevel < 10)
                {
                    CheckLevelUp();
                }
            }
        }

        private void drinkPotion_Click(object sender, EventArgs e)
        {
            if (currPHealth < currPMaxHealth)
            {
                currPHealth += 6 * currPLevel;
                if (currPHealth > currPMaxHealth)
                {
                    currPHealth = currPMaxHealth;
                }
                currPPotions -= 1;
                if (currPPotions <= 0)
                {
                    drinkPotion.Enabled = false;
                }
                FillPlayerInfo();
            }
        }
    }
}
