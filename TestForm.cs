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

    }

}
