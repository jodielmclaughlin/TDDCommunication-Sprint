using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication_Sprint
{
    public class SumNumbers
    {
       
        public static int SumMiddleNumbers(int[] input)
        {
            //int[] numbers = { 1, 2 };
            if(input.Length <= 2) 
            {  
                return 0; 
            }

            Array.Sort(input);
            var inputToList = new List<int>(input);
            inputToList.RemoveAt(0);
            inputToList.RemoveAt(inputToList.Count -1);
            int[] midNumsArray = inputToList.ToArray();

            int midNumsSum = 0;

            for(int i = 0; i < midNumsArray.Length; i++)
            {
                midNumsSum += midNumsArray[i];
            }

            return midNumsSum;
        }
    }
}
