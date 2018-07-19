using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            string inputInLower = input.ToLower();

            foreach (char a in alphabets)
            {
                if (!inputInLower.Contains(a)) return false;
            }

            
            return true;
        }
    }
}
