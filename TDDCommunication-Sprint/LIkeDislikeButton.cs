using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication_Sprint
{
    public class LIkeDislikeButton
    {
        public static Button ButtonSequenceResults(int clickLike, int clickDislike)
        {

            int remainderLike = clickLike%2;
            int remainderDislike = clickDislike%2;
            
            if (remainderLike == remainderDislike)
            {
                return Button.NEUTRAL;
            }
            if (remainderLike > remainderDislike)
            {
                return Button.LIKE;

            }
                       
            return Button.DISLIKE;
                    
        }
    }
}
