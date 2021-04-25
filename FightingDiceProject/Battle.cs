using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingDice
{
    class Battle
    {
        public int[] Fight(string AtkName, string DefName, string UnitCount)
        {
            //name strength toughness wsbs armor attack
            //handles display of stats
            XMLTools toolA = new XMLTools();
            XMLTools toolD = new XMLTools();
            ArmyList ListA = new ArmyList();
            string[] armyA = toolA.readXML(AtkName);
            string[] armyD = toolD.readXML(DefName);

            int.TryParse(armyA[1], out int atkStr);
            int.TryParse(armyD[1], out int defStr);  

            int.TryParse(armyA[2], out int atkTough);
            int.TryParse(armyD[2], out int defTough);

            int.TryParse(armyA[3], out int atkBSWS);
            int.TryParse(armyD[3], out int defBSWS);
            
            int.TryParse(armyD[4], out int atkAS);
            int.TryParse(armyD[4], out int defAS);
            
            int.TryParse(armyD[5], out int atkAtks);
            int.TryParse(armyD[5], out int defAtks);

            int.TryParse(UnitCount, out int UnitCT);

            int[] results = new int [7];
            
            Combat Combat = new Combat();
            DiceTools Dice = new DiceTools();
            
            for (int i = -3; i <= 3; i++)
            {
                int hits = 0;
                int[] wounds = { 0, 0 };
                int saves = 0;
                int remainingD = 0;
                int remainingA = 0;

                hits = Combat.Attack(Dice.RollDice(6, (UnitCT + i) * atkAtks), Combat.WSBSTable(atkBSWS));
                wounds = Combat.Wound(Dice.RollDice(6, hits), Combat.WoundTable(atkStr, defTough));
                saves = Combat.Defend(Dice.RollDice(6, wounds[0] - wounds[1]), defAS, wounds[1]);
                remainingD = UnitCT - wounds[1] - wounds[0] + saves;

                hits = Combat.Attack(Dice.RollDice(6, (remainingD) * defAtks), Combat.WSBSTable(defBSWS));
                wounds = Combat.Wound(Dice.RollDice(6, hits), Combat.WoundTable(defStr, atkTough));
                saves = Combat.Defend(Dice.RollDice(6, wounds[0] - wounds[1]), atkAS, wounds[1]);
                remainingA = UnitCT - wounds[1] - wounds[0] + saves;

                results[i + 3] = remainingA - remainingD;

            };

            return results;

            
            
            
            

           


            




            

            

            
            




        }
    }
}
