using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication_Sprint
{
    public class CaeserCipher
    {
        public static string SwappedCipher(string cipher, int num)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            string result = String.Empty;

            foreach (char letter in cipher)
            {
                char nextLetter = letter;
                
                if ((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z'))
                {
                    nextLetter = alphabet[(alphabet.IndexOf(nextLetter) + num)];
                }
                result += nextLetter;
            }

            return result;
        }
    }
}
