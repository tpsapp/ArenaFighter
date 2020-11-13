using System;
using System.Windows.Forms;

namespace ArenaFighter
{
    public partial class Form2 : Form
    {
        private int orderGold, currentGold, oldWeapon, oldArmor, playerPotions, boughtWeapon, boughtArmor, boughtPotions;

        private void CheckGold()
        {
            if (orderGold > 0)
            {
                checkoutButton.Enabled = true;
            }
            else
            {
                checkoutButton.Enabled = false;
            }
            if (boughtArmor == 0)
            {
                ChangeArmor(true);
            }
            if (boughtWeapon == 0)
            {
                ChangeWeapons(true);
            }
            int tempGold = currentGold - orderGold;
            if (boughtArmor > 0)
            {
                tempGold += SellPrice(oldWeapon);
            }
            if (boughtWeapon > 0)
            {
                tempGold += SellPrice(oldArmor);
            }
            if (tempGold < BuyPrice(1))
            {
                buyDagger.Enabled = false;
                buyCloth.Enabled = false;
            }
            if (tempGold < BuyPrice(2))
            {
                buyClub.Enabled = false;
                buyLeather.Enabled = false;
            }
            if (tempGold < (5 * frm1.currPLevel))
            {
                buyPotion.Enabled = false;
            }
            else
            {
                buyPotion.Enabled = true;
            }
            if (tempGold < BuyPrice(3))
            {
                buyStaff.Enabled = false;
                buyChain.Enabled = false;
            }
            if (tempGold < BuyPrice(4))
            {
                buySword.Enabled = false;
                buyPlate.Enabled = false;
            }
            if (tempGold < BuyPrice(5))
            {
                buyMace.Enabled = false;
                buyScale.Enabled = false;
            }
            if (tempGold < BuyPrice(6))
            {
                buySteelSword.Enabled = false;
                buySteelChain.Enabled = false;
            }
            if (tempGold < BuyPrice(7))
            {
                buySteelmace.Enabled = false;
                buySteelPlate.Enabled = false;
            }
            if (tempGold < BuyPrice(8))
            {
                buySilverSword.Enabled = false;
                buySteelScale.Enabled = false;
            }
            if (tempGold < BuyPrice(9))
            {
                buySilverMace.Enabled = false;
                buyTChain.Enabled = false;
            }
            if (tempGold < BuyPrice(10))
            {
                buyGoldSword.Enabled = false;
                buyTPlate.Enabled = false;
            }
            if (tempGold < BuyPrice(11))
            {
                buyGoldMace.Enabled = false;
                buyTScale.Enabled = false;
            }
            playerGold.Text = "Your Gold: " + currentGold;
            orderAmount.Text = "Order Amount: " + orderGold;
        }

        private void ChangeArmor(bool action)
        {
            buyCloth.Enabled = action;
            buyLeather.Enabled = action;
            buyChain.Enabled = action;
            buyPlate.Enabled = action;
            buyScale.Enabled = action;
            buySteelChain.Enabled = action;
            buySteelPlate.Enabled = action;
            buySteelScale.Enabled = action;
            buyTChain.Enabled = action;
            buyTPlate.Enabled = action;
            buyTScale.Enabled = action;
        }

        private void ChangeWeapons(bool action)
        {
            buyDagger.Enabled = action;
            buyClub.Enabled = action;
            buyStaff.Enabled = action;
            buySword.Enabled = action;
            buyMace.Enabled = action;
            buySteelSword.Enabled = action;
            buySteelmace.Enabled = action;
            buySilverSword.Enabled = action;
            buySilverMace.Enabled = action;
            buyGoldSword.Enabled = action;
            buyGoldMace.Enabled = action;
        }

        private void ChangePotion(int gold)
        {
            if (gold < (5 * Convert.ToInt16(frm1.playerLevel.Text)))
            {
                buyPotion.Enabled = false;
            }
            if (gold >= (5 * Convert.ToInt16(frm1.playerLevel.Text)))
            {
                buyPotion.Enabled = true;
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

        private int BuyPrice(int item)
        {
            switch (item)
            {
                case 1:
                    {
                        return 2;
                    }
                    break;
                case 2:
                    {
                        return 6;
                    }
                    break;
                case 3:
                    {
                        return 50;
                    }
                    break;
                case 4:
                    {
                        return 150;
                    }
                    break;
                case 5:
                    {
                        return 300;
                    }
                    break;
                case 6:
                    {
                        return 600;
                    }
                    break;
                case 7:
                    {
                        return 900;
                    }
                    break;
                case 8:
                    {
                        return 1500;
                    }
                    break;
                case 9:
                    {
                        return 2400;
                    }
                    break;
                case 10:
                    {
                        return 3900;
                    }
                    break;
                case 11:
                    {
                        return 6300;
                    }
                    break;
                default:
                    {
                        return 0;
                    }
                    break;
            }
        }

        private int SellPrice(int item)
        {
            switch (item)
            {
                case 1:
                    {
                        return 2 / 2;
                    }
                    break;
                case 2:
                    {
                        return 6 / 2;
                    }
                    break;
                case 3:
                    {
                        return 50 / 2;
                    }
                    break;
                case 4:
                    {
                        return 150 / 2;
                    }
                    break;
                case 5:
                    {
                        return 300 / 2;
                    }
                    break;
                case 6:
                    {
                        return 600 / 2;
                    }
                    break;
                case 7:
                    {
                        return 900 / 2;
                    }
                    break;
                case 8:
                    {
                        return 1500 / 2;
                    }
                    break;
                case 9:
                    {
                        return 2400 / 2;
                    }
                    break;
                case 10:
                    {
                        return 3900 / 2;
                    }
                    break;
                case 11:
                    {
                        return 6300 / 2;
                    }
                    break;
                default:
                    {
                        return 0;
                    }
                    break;
            }
        }

        public Form2(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            currentGold = frm1.currPGold;
            playerGold.Text = "Your Gold: " + frm1.playerGold.Text;
            oldWeapon = frm1.currPWeapon;
            oldArmor = frm1.currPArmor;
            oldWeaponLabel.Text = "Current Weapon: " + GetWeapon(oldWeapon);
            oldArmorLabel.Text = "Current Armor: " + GetArmor(oldArmor);
            playerPotions = frm1.currPPotions;
            CheckGold();
        }

        private void buyDagger_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Dagger");
            boughtWeapon = 1;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buyClub_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Club");
            boughtWeapon = 2;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buyStaff_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Staff");
            boughtWeapon = 3;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buySword_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Sword");
            boughtWeapon = 4;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buyMace_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Mace");
            boughtWeapon = 5;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buySteelSword_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Steel Sword");
            boughtWeapon = 6;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buySteelmace_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Steel Mace");
            boughtWeapon = 7;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buySilverSword_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Silver Sword");
            boughtWeapon = 8;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buySilverMace_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Silver Mace");
            boughtWeapon = 9;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buyGoldSword_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Gold Sword");
            boughtWeapon = 10;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buyGoldMace_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Gold Mace");
            boughtWeapon = 11;
            orderGold += BuyPrice(boughtWeapon);
            CheckGold();
            ChangeWeapons(false);
        }

        private void buyCloth_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Cloth");
            boughtArmor = 1;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyLeather_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Leather");
            boughtArmor = 2;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyChain_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Chain");
            boughtArmor = 3;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyPlate_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Plate");
            boughtArmor = 4;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyScale_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Scale");
            boughtArmor = 5;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buySteelChain_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Steel Chain");
            boughtArmor = 6;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buySteelPlate_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Steel Plate");
            boughtArmor = 7;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buySteelScale_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Steel Scale");
            boughtArmor = 8;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyTChain_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Titanium Chain");
            boughtArmor = 9;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyTPlate_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Titanium Plate");
            boughtArmor = 10;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyTScale_Click(object sender, EventArgs e)
        {
            cartList.Items.Add("Titanium Scale");
            boughtArmor = 11;
            orderGold += BuyPrice(boughtArmor);
            CheckGold();
            ChangeArmor(false);
        }

        private void buyPotion_Click(object sender, EventArgs e)
        {
            orderGold += 5 * Convert.ToInt16(frm1.playerLevel.Text);
            cartList.Items.Add("Health Potion");
            boughtPotions += 1;
            CheckGold();
        }

        private void cartList_DoubleClick(object sender, EventArgs e)
        {
            switch (cartList.Items[cartList.SelectedIndex].ToString())
            {
                case "Dagger":
                    {
                        orderGold -= BuyPrice(1);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Club":
                    {
                        orderGold -= BuyPrice(2);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Staff":
                    {
                        orderGold -= BuyPrice(3);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Sword":
                    {
                        orderGold -= BuyPrice(4);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Mace":
                    {
                        orderGold -= BuyPrice(5);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Steel Sword":
                    {
                        orderGold -= BuyPrice(6);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Steel Mace":
                    {
                        orderGold -= BuyPrice(7);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Silver Sword":
                    {
                        orderGold -= BuyPrice(8);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Silver Mace":
                    {
                        orderGold -= BuyPrice(9);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Gold Sword":
                    {
                        orderGold -= BuyPrice(10);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Gold Mace":
                    {
                        orderGold -= BuyPrice(11);
                        ChangeWeapons(true);
                        boughtWeapon = 0;
                        CheckGold();
                    }
                    break;
                case "Cloth":
                    {
                        orderGold -= BuyPrice(1);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Leather":
                    {
                        orderGold -= BuyPrice(2);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Chain":
                    {
                        orderGold -= BuyPrice(3);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Plate":
                    {
                        orderGold -= BuyPrice(4);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Scale":
                    {
                        orderGold -= BuyPrice(5);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Steel Chain":
                    {
                        orderGold -= BuyPrice(6);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Steel Plate":
                    {
                        orderGold -= BuyPrice(7);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Steel Scale":
                    {
                        orderGold -= BuyPrice(8);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Titanium Chain":
                    {
                        orderGold -= BuyPrice(9);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Titanium Plate":
                    {
                        orderGold -= BuyPrice(10);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Titanium Scale":
                    {
                        orderGold -= BuyPrice(11);
                        ChangeArmor(true);
                        boughtArmor = 0;
                        CheckGold();
                    }
                    break;
                case "Health Potion":
                    {
                        orderGold -= 5 * Convert.ToInt16(frm1.playerLevel.Text);
                        boughtPotions -= 1;
                        CheckGold();
                    }
                    break;
                default:
                    break;
            }
            cartList.Items.Remove(cartList.SelectedItem);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            int tempGold;
            if (currentGold > orderGold)
            {
                tempGold = currentGold - orderGold;
            }
            else
            {
                tempGold = orderGold - currentGold;
            }
            if (boughtArmor > 0)
            {
                frm1.currPArmor = boughtArmor;
                tempGold += SellPrice(oldArmor);
            }
            if (boughtWeapon > 0)
            {
                frm1.currPWeapon = boughtWeapon;
                tempGold += SellPrice(oldWeapon);
            }
            frm1.currPGold = tempGold;
            int totalPotions = boughtPotions + playerPotions;
            frm1.currPPotions = totalPotions;
            if (tempGold <= 0)
            {
                frm1.shopButton.Enabled = false;
            }
            frm1.FillPlayerInfo();
            this.Close();
        }
    }
}
