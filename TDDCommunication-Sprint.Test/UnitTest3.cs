using Microsoft.VisualStudio.TestPlatform.Utilities;
using Shouldly;

namespace TDDCommunication_Sprint.Test
{
    public class UnitTest3
    {
        [Test]
        public void SumUpASCII_ShouldReturnSumOf1Character()
        {
            int output = ASCIICodes.SumUpAscii("a");
            output.ShouldBe(97);
        }

        [Test]
        public void SumUpASCII_ShouldReturnSumOf2Characters()
        {
            int output = ASCIICodes.SumUpAscii("aA");
            output.ShouldBe(162);
        }

        [Test]
        public void SumUpASCII_ShouldReturnSumOf11Characters()
        {
            int output = ASCIICodes.SumUpAscii("Northcoders");
            output.ShouldBe(1163);
        }
        [Test]
        public void SumUpASCII_ShouldReturnSumOf5Numbers()
        {
            int output = ASCIICodes.SumUpAscii("98765");
            output.ShouldBe(275);
        }
    }
}
