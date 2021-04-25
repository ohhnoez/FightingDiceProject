using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingDice
{
    public class DiceTools
    {
        //Rolling dice
        // Takes in 2 params (both INT)
        // outputs an INT(array) based on a random value or string of values
        public int[] RollDice(int diceSides, int count)
        {
            int[] rand_num = new int[count];

            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                rand_num[i] = rnd.Next(1, diceSides + 1);
            }
            return rand_num;
            
        }

        //Dice Roll Average
        //Gets tha average value of rolls from an array of INTs

        public int RollAverage(int[] rolls)
        {
            return rolls.Sum() / rolls.Length;
        }

        //Future State: Roll with Advantage
        //Rolls 2 dice and chooses the higher of the rolls.
        public int roll_adv(int diceSides)
        {
            int rollA = RollDice(diceSides, 1)[0];
            int rollB = RollDice(diceSides, 1)[0];
            if (rollB >= rollA)
                return rollB;
            else
                return rollA;

        }

        //Future State: Roll with DisAdvantage
        //Rolls 2 dice and chooses the lowe of the rolls.
        public int RollDis(int diceSides)
        {
            int rollA = RollDice(diceSides, 1)[0];
            int rollB = RollDice(diceSides, 1)[0];
            if (rollB <= rollA)
                return rollB;
            else
                return rollA;
        }

    }
}
