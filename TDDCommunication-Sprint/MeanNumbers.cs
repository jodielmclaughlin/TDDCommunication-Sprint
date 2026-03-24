using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication_Sprint
{
    public class MeanNumbers
    {
        public static double CalculateMeanValue(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {

                return nums[0];
            }
            double sumArrayNums = 0;
            if (nums.Length >= 2)
            {

            for (int i = 0; i <nums.Length; i++)
                {
                    sumArrayNums += nums[i];
                 }
             }
            return sumArrayNums / nums.Length;
        }
     }
}
