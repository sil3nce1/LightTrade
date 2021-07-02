using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightTrade.Cypher
{
    public static class Alphabet
    {
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public static Int64 GetAlphabetScore(string phrase)
        {
            try
            {
                string formatted = phrase.ToUpper();
                string score = string.Empty;
                for (int i = 0; i < formatted.Length; i++)
                {
                    score += GetAlphabetLetterPos(formatted[i]).ToString();
                }
                MessageBox.Show(score);
                return Int64.Parse(score);
            }
            catch
            {
                return 0;
            }
            
        }

        private static int GetAlphabetLetterPos(char letter)
        {
            letter = letter.ToString().ToUpper()[0];
            for (int i = 0; i < alphabet.Length; i++)
            {
                char curLetter = alphabet[i];
                if (curLetter == letter)
                    return i;
            }
            return -1;
        }
    }
}
