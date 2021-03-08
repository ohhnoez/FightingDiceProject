using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FightingDice
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

            
        private void d6_Click_1(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d6.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(txt_DiceCount.Text,out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(6, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach(int item in roll) 
            {
                textBox_d6.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d6Avg.Text = rollDice.RollAverage(roll).ToString();

        }
        private void d8_Click(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d8.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(txt_DiceCount.Text, out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(8, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach (int item in roll)
            {
                textBox_d8.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d8Avg.Text = rollDice.RollAverage(roll).ToString();

        }
        private void d10_Click_1(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d10.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(txt_DiceCount.Text, out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(10, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach (int item in roll)
            {
                textBox_d10.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d10Avg.Text = rollDice.RollAverage(roll).ToString();

        }
        private void d12_Click(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d12.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(txt_DiceCount.Text, out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(12, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach (int item in roll)
            {
                textBox_d12.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d12Avg.Text = rollDice.RollAverage(roll).ToString();

        }
        private void d20_Click(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d20.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(txt_DiceCount.Text, out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(20, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach (int item in roll)
            {
                textBox_d20.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d20Avg.Text = rollDice.RollAverage(roll).ToString();

        }
        private void d100_Click(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d100.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(txt_DiceCount.Text, out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(100, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach (int item in roll)
            {
                textBox_d100.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d100Avg.Text = rollDice.RollAverage(roll).ToString();

        }

        private void ButtonAttackSH_Click(object sender, System.EventArgs e)
        {
            if (GBAttack.Visible == true)
            {
                GBAttack.Visible = false;
            }
            else
            {
                GBAttack.Visible = true;
            }
        }

        private void ButtonDefendSH_Click(object sender, System.EventArgs e)
        {
            if (GBDefend.Visible == true)
            {
                GBDefend.Visible = false;
            }
            else
            {
                GBDefend.Visible = true;
            }
        }

        private void ButtonResultsSH_Click(object sender, System.EventArgs e)
        {
            if (GBResults.Visible == true)
            {
                GBResults.Visible = false;
            }
            else
            {
                GBResults.Visible = true;
            }
        }

        private void testCombat_Click(object sender, EventArgs e)
        {
            
            int.TryParse(TextBoxAttackerWSBS.Text, out int atkBSWS);
            int.TryParse(TextBoxAttackerStr.Text, out int atkStr);
            int.TryParse(TextBoxAttackerAPM.Text, out int atkAtks);
            int.TryParse(TextBoxAttackerAS.Text, out int atkAS);
            int.TryParse(TextBoxAttackerToughness.Text, out int atkToug);
            int.TryParse(TextBoxDefenderWSBS.Text, out int defBSWS);
            int.TryParse(TextBoxDefenderStr.Text, out int defStr);
            int.TryParse(TextBoxDefenderAPM.Text, out int defAtks);
            int.TryParse(TextBoxDefenderAS.Text, out int defAS);
            int.TryParse(TextBoxDefenderToughness.Text, out int defTough);
            int.TryParse(TextBoxAttackerCount.Text, out int atkCount);
            int.TryParse(TextBoxDefenderCount.Text, out int defCount);

            int hits = 0;
            int[] wounds = { 0 , 0 };
            int saves = 0;
            int kills = 0;

            Combat Combat = new Combat();
            DiceTools Dice = new DiceTools();

            hits = Combat.Attack(Dice.RollDice(6,atkCount*atkAtks), Combat.WSBSTable(atkBSWS));
            TextBoxHits.Text = hits.ToString();

            
            wounds = Combat.Wound(Dice.RollDice(6, hits), Combat.WoundTable(atkStr, defTough));
            TextBoxWounds.Text = wounds[0].ToString();

            saves = Combat.Defend(Dice.RollDice(6, wounds[0] - wounds[1]), defAS, wounds[1]);
            TextBoxCritWound.Text = wounds[1].ToString();

            kills = defCount - saves;
            TextBoxDefLeft.Text = kills.ToString();











        }

    }

}
