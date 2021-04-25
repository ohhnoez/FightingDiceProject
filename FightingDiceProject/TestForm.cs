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
