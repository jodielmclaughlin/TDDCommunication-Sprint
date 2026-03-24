using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication_Sprint
{
    public class ASCIICodes
    {
        public static int SumUpAscii(string ascii)
        {
            char[] splitString = ascii.ToCharArray();
            
            int convertedAscii = 0;

            foreach (char c in splitString)
            {
                convertedAscii += Convert.ToInt32(c);
            }

            return convertedAscii;
         }
    }
}
