using Shouldly;

namespace TDDCommunication_Sprint.Test
{
    public class UnitTest4
    {
        [Test]
        public void ButtonSequenceResult_Like()
        {
            Enum output = LIkeDislikeButton.ButtonSequenceResults(1, 0);
            output.ShouldBe(Button.LIKE);
        }

        [Test]
        public void ButtonSequenceResult_Neutral()
        {
            Enum output = LIkeDislikeButton.ButtonSequenceResults(2, 2);
            output.ShouldBe(Button.NEUTRAL);
        }

        [Test]
        public void ButtonSequenceResult_Dislike()
        {
            Enum output = LIkeDislikeButton.ButtonSequenceResults(0, 1);
            output.ShouldBe(Button.DISLIKE);
        }

        [Test]
        public void ButtonSequenceResult_MultipleClicks()
        {
            Enum output = LIkeDislikeButton.ButtonSequenceResults(4, 7);
            output.ShouldBe(Button.DISLIKE);
        }
    }

}
