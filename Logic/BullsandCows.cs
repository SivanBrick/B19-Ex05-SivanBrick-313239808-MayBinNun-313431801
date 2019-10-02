using System;
using System.Collections.Generic;
using System.Text;


namespace Logic
{
    public class BullsandCows
    {

        private const int k_LenOfResult = 4;

        public static List<eGuessFrom> Randsequence()
        {

            Random rand = new Random();
            List<eGuessFrom> randomsAnswer = new List<eGuessFrom>();
            int numOfOptions = Enum.GetNames(typeof(eGuessFrom)).Length;

            while (randomsAnswer.Count != k_LenOfResult)
            {
                int numToRand = rand.Next(0, numOfOptions);
                eGuessFrom randomColor = (eGuessFrom)numToRand;
                if (!randomsAnswer.Contains(randomColor))
                {
                    randomsAnswer.Add(randomColor);
                }
            }

            return randomsAnswer;
        }

        public static String UserFeedback(List<eGuessFrom> i_RandomSequence, List<eGuessFrom> i_UserChoise)
        {
            int exactHits = 0;
            int nearHit = 0;
            StringBuilder guessesFeedback = new StringBuilder();

            for (int i = 0; i < i_RandomSequence.Count; i++)
            {
                if (i_RandomSequence[i] == i_UserChoise[i])
                {
                    exactHits++;
                }
                else if (i_RandomSequence.Contains(i_UserChoise[i]))
                {
                    nearHit++;
                }
            }

            guessesFeedback.Insert(0, "V", exactHits);
            int lenOfsuccess = guessesFeedback.Length;
            guessesFeedback.Insert(lenOfsuccess, "X", nearHit);

            return guessesFeedback.ToString();

        }
    }
}
