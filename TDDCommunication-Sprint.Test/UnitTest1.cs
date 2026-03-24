using Shouldly;

namespace TDDCommunication_Sprint.Test
{
    public class Tests
    {

        [Test]
        public void SumMiddleNumbers_ShouldReturn0_WhenGiven1Int()
        {
            int output = SumNumbers.SumMiddleNumbers([1]);
            output.ShouldBe(0);
        }

        [Test]
        public void SumMiddleNumbers_ShouldReturn0_WhenGiven2Ints()
        {
            int output = SumNumbers.SumMiddleNumbers([1, 2]);
            output.ShouldBe(0);
        }
        [Test]
        public void SumMiddleNumbers_ShouldReturnMiddleNum_WhenGiven3Ints()
        {
            int output = SumNumbers.SumMiddleNumbers([3, 1, 2]);
            output.ShouldBe(2);
        }
        [Test]
        public void SumMiddleNumbers_ShouldReturnSumOfMiddleNums_WhenGiven4OrMoreInts()
        {
            int output1 = SumNumbers.SumMiddleNumbers([4, 7, 3, 8]);
            int output2 = SumNumbers.SumMiddleNumbers([6, 3, 7, 1, 9]);
            int output3 = SumNumbers.SumMiddleNumbers([2, 3, 4, 5, 6, 7]);
            int output4 = SumNumbers.SumMiddleNumbers([3, 2, 6, 7]);

            Assert.Multiple(() =>
            { 
            output1.ShouldBe(11);
            output2.ShouldBe(16);
            output3.ShouldBe(18);
            output4.ShouldBe(9) ;
        });
        }
    }
}