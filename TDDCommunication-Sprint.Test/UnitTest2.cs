using Microsoft.VisualStudio.TestPlatform.Utilities;
using Shouldly;

namespace TDDCommunication_Sprint.Test
{
    public class UnitTest2
    {
        [Test]
        public void CaculateMeanValue_OfAnEmptyArray()
        {
            double output = MeanNumbers.CalculateMeanValue([]);
            output.ShouldBe(0);
        }
            [Test]
        public void CaculateMeanValue_OfaOneNumberArray()
        {
            double output = MeanNumbers.CalculateMeanValue([3]);
            output.ShouldBe(3);
        }

        [Test]
        public void CalculateMeanValue_OfAMultipleNumberArray()
        {
            double output = MeanNumbers.CalculateMeanValue([4, 2, 6, 3, 6]);
            output.ShouldBe(4.2);
        }
    }
}
