using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingDice
{
    public class DiceTools
    {
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

        public int RollAverage(int[] rolls)
        {
            return rolls.Sum() / rolls.Length;
        }

        public int roll_adv(int diceSides)
        {
            int rollA = RollDice(diceSides, 1)[0];
            int rollB = RollDice(diceSides, 1)[0];
            if (rollB >= rollA)
                return rollB;
            else
                return rollA;

        }

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
