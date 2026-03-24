using Shouldly;

namespace TDDCommunication_Sprint.Test
{
    public class UnitTest5
    {
        [Test]
        public void SwappedCipher_ShouldReturnNForA()
        {
            string output = CaeserCipher.SwappedCipher("AAA", 13);
            output.ShouldBe("NNN");
        }
    }
}
