using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingDice
{
    public class Combat
    {
        // public int attack(int[] roll, int attackVal)
        // input: int[] roll ... int array from rolls in dice tools.
        // input: int attackVal ... int from ws/bs from statline table.
        // output: int counting number of rolls that pass ws/bs check. 
        public int Attack(int[] roll, int attackVal)
        {
            int attackReuslt = 0;

            // Validation of each roll against roll table
            // Hit calcuation is imported from attackVal
            // Result Values are held 2 value int array
            foreach (int item in roll)
            {
                //Hit Calc
                if (item >= attackVal)
                {
                    attackReuslt += 1;
                }

             }

            return attackReuslt;
        }

        // public int[] Wound(int[] roll, int toughnessVal)
        // input: int[] roll ... int array from rolls in dice tools.
        // input: int toughnessVal ... int from toughness from statline table.
        // output: int counting number of rolls that pass toughness check.
        public int[] Wound(int[] roll, int toughnessVal)
        {
            int[] woundResult = { 0, 0 };

            // Validation of each roll against roll table
            // Hit calcuation is imported from attackVal
            // Result Values are held 2 value int array
            foreach (int item in roll)
            {
                //Wound Calc
                if (item >= toughnessVal)
                {
                    woundResult[0] += 1;
                }

                // Critical Wound (Unsavable) Calc (max roll d6 = 6)
                if (item == 6)
                {
                    woundResult[1] += 1;
                }

            }

            return woundResult;
        }

        // public int[] Wound(int[] roll, int toughnessVal)
        // input: int[] roll ... int array from rolls in dice tools.
        // input: int saveVal ... int from save from statline table.
        // input: int unSavable ... CriticalWound = values out of Combat.Wound array [1]
        // output: int counting number of rolls that pass save check. 
        public int Defend(int [] roll, int saveVal, int unSavable)
        {
            int woundResult = 0;
            
            // Tallies up wounds that make it past saving (armor) value
            foreach (int item in roll)
            {
                //Wound Calc
                if (item < saveVal)
                {
                    woundResult += 1;
                }

            }
            
            // Adds unsavable wound to wound tally.
            woundResult += unSavable;

            return woundResult;
        }

        public int WoundTable(int atk, int def)
        {
            int tVal=0;

            if (atk == def)
            { tVal = 4; }
            else if (atk >= def*2)
            { tVal = 2; }
            else if (atk <= def/2)
            { tVal = 6; }
            else if (atk > def)
            { tVal = 3; }
            else if (atk < def)
            { tVal = 5; }

            return tVal;
        }

        public int WSBSTable(int wsbs)
        {
            int sVal = 0;

            if (wsbs == 6)
            { sVal = 2; }
            else if (wsbs == 5)
            { sVal = 3; }
            else if (wsbs == 4)
            { sVal = 4; }
            else if (wsbs == 3)
            { sVal = 5; }
            else if (wsbs == 2)
            { sVal = 6; }

            return sVal;
        }


    }
}
