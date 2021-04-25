using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using System.Linq;
//using System.Collections.Generic;
  


namespace FightingDice
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        //adds currently selected army to DB
        private void t3SaveBtn_Click(object sender, EventArgs e)
        {

            XMLTools tool = new XMLTools();
            Validation check = new Validation();

            //user input validation
            if (check.isInt(t3Str.Text) &
                check.isInt(t3Tough.Text) &
                check.isInt(t3WSBS.Text) &
                check.isInt(t3AS.Text) &
                check.isInt(t3Atk.Text))
            {
                tool.AppendXML(t3AmryName.Text, t3Str.Text, t3Tough.Text, t3WSBS.Text, t3AS.Text, t3Atk.Text);
                MessageBox.Show(t3AmryName.Text + " saved to the database." );
            }
            else { MessageBox.Show("Please make sure that all Stats are Integers"); }


        }

        //removed currently selected army from DB
        private void t3RemoveBtn_Click(object sender, EventArgs e)
        {
            XMLTools tool = new XMLTools();
            tool.DeleteXML((string)t3ArmyRemove.SelectedItem);

            t3ArmyRemove.Text = null;
        }

        //Refreshes combo box
        private void t3Army_Click(object sender, EventArgs e)
        {
            t3ArmyRemove.Items.Clear();

            XDocument xmlDocument = XDocument.Load("Data.xml");
            IEnumerable<string> ArmyNames = from army in XDocument.Load("Data.xml").Descendants("Army")
                                            select army.Element("Name").Value;

            foreach (string ArmyName in ArmyNames)
            {
                t3ArmyRemove.Items.Add(ArmyName);
            }
                
        }

        //Refreshes combo box
        private void t2Army_Click(object sender, EventArgs e)
        {
            t2Army.Items.Clear();

            XDocument xmlDocument = XDocument.Load("Data.xml");
            IEnumerable<string> ArmyNames = from army in XDocument.Load("Data.xml").Descendants("Army")
                                            select army.Element("Name").Value;

            foreach (string ArmyName in ArmyNames)
            {
                t2Army.Items.Add(ArmyName);
            }
                        
        }

        //Loads currently selected army into view
        private void t2Load_Click(object sender, EventArgs e)
        {

            XMLTools tool = new XMLTools();
            ArmyList List = new ArmyList();
            string[] army = tool.readXML((string)t2Army.SelectedItem);
            
            //Outputs army stats & name from method
            t2ArmyName.Text = army[0];
            t2Str.Text = army[1];
            t2Tough.Text = army[2];
            t2WSBS.Text = army[3];
            t2AS.Text = army[4];
            t2Atk.Text = army[5];
            
            //Convert strings to ints for calculations.
            List.Name = army[0];
            int n;
            if (int.TryParse(army[1],out n))
                { List.Strength = n; }
            if (int.TryParse(army[2], out n))
                { List.Toughness = n; }
            if (int.TryParse(army[3], out n))
                { List.WSBS = n; }
            if (int.TryParse(army[4], out n))
                { List.Armor = n; }
            if (int.TryParse(army[5], out n))
                { List.Attacks = n; }

        }



        private void d6_Click(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d6.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(t4DiceCount.Text, out int intDiceCount);

            //Calls roll method (dice count, number of rolls)
            //Returns int array of roll values
            DiceTools rollDice = new DiceTools();
            int[] roll = rollDice.RollDice(6, intDiceCount);

            //outputs each roll to a new line in multiline text box
            foreach (int item in roll)
            {
                textBox_d6.Text += item.ToString() + Environment.NewLine;
            }

            textBox_d6Avg.Text = rollDice.RollAverage(roll).ToString();

        }

        private void d8_Click_1(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d8.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(t4DiceCount.Text, out int intDiceCount);

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

        private void d10_Click(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d10.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(t4DiceCount.Text, out int intDiceCount);

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

        private void d12_Click_1(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d12.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(t4DiceCount.Text, out int intDiceCount);

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

        private void d20_Click_1(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d20.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(t4DiceCount.Text, out int intDiceCount);

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

        private void d100_Click_1(object sender, EventArgs e)
        {
            //Clears Output window
            textBox_d100.Text = "";

            //Parses input box and coverts it to int
            int.TryParse(t4DiceCount.Text, out int intDiceCount);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void t1AtkCombo_Click(object sender, EventArgs e)
        {
            //handles display of combo contents
            t1AtkCombo.Items.Clear();

            XDocument xmlDocument = XDocument.Load("Data.xml");
            IEnumerable<string> ArmyNames = from army2 in XDocument.Load("Data.xml").Descendants("Army")
                                            select army2.Element("Name").Value;

            foreach (string ArmyName in ArmyNames)
            {
                t1AtkCombo.Items.Add(ArmyName);
            }

           
        }

        private void t1dCombo_Click(object sender, EventArgs e)
        {
            //handles display of combo contents
            t1DCombo.Items.Clear();

            XDocument xmlDocument = XDocument.Load("Data.xml");
            IEnumerable<string> ArmyNames = from army2 in XDocument.Load("Data.xml").Descendants("Army")
                                            select army2.Element("Name").Value;

            foreach (string ArmyName in ArmyNames)
            {
                t1DCombo.Items.Add(ArmyName);
            }

            //handles display of stats


        }

        private void t1Fight_Click(object sender, EventArgs e)
        {

            int[] results = new int[7];
            //int basect = new int();
            Battle B1 = new Battle();
            results = B1.Fight((string)t1AtkCombo.SelectedItem, (string)t1DCombo.SelectedItem, (string)t1UnitCombo.SelectedItem);
            int.TryParse((string)t1UnitCombo.SelectedItem, out int basect);

            pBm3.Value = 50 + (50 * results[0]/basect);
            pBm2.Value = 50 + (50 * results[1] / basect);
            pBm1.Value = 50 + (50 * results[2] / basect);
            pBe.Value = 50 + (50 * results[3] / basect);
            pBp1.Value = 50 + (50 * results[4] / basect);
            pBp2.Value = 50 + (50 * results[5] / basect);
            pBp3.Value = 50 + (50 * results[6] / basect);

            t1Fight.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //handles display of stats
            XMLTools toolA = new XMLTools();
            ArmyList ListA = new ArmyList();
            string[] armyA = toolA.readXML((string)t1AtkCombo.SelectedItem);

            //Outputs army stats & name from method
            t1aName.Text = armyA[0];
            t1aStr.Text = armyA[1];
            t1aTough.Text = armyA[2];
            t1aWSBS.Text = armyA[3];
            t1aArmor.Text = armyA[4];
            t1aAtk.Text = armyA[5];

            //handles display of stats
            XMLTools toolD = new XMLTools();
            ArmyList ListD = new ArmyList();
            string[] armyD = toolD.readXML((string)t1DCombo.SelectedItem);

            //Outputs army stats & name from method
            t1bName.Text = armyD[0];
            t1bStr.Text = armyD[1];
            t1bTough.Text = armyD[2];
            t1bWSBS.Text = armyD[3];
            t1bArmor.Text = armyD[4];
            t1bAtk.Text = armyD[5];

            //ensures attacker and defender and unit count are chosen
            if (t1AtkCombo.SelectedItem == null) { }
            else if (t1DCombo.SelectedItem == null) { }
            else if (t1UnitCombo.SelectedItem == null) { }
            else { t1Fight.Enabled = true; };

        }

        private void t1Reset_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);

        }
    }
}
