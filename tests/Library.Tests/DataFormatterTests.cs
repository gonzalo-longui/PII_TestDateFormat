using NUnit.Framework;
namespace Library.Tests
{
    public class Tests
    {
        [Test]
        public void CorrectFormat()
        {
            const string expected = "2004-02-10";
            string testDate = DateFormatter.ChangeFormat("10/02/2004");
            Assert.AreEqual(expected, testDate);
        }

        [Test]
        public void IncorrectFormat()
        {
            const string expected = "";
            string testDate = DateFormatter.ChangeFormat("10/2/2004");
            Assert.AreEqual(expected, testDate);
        }

        [Test]
        public void EmptyFormat()
        {
            const string expected = "";
            string testDate = DateFormatter.ChangeFormat("");
            Assert.AreEqual(expected, testDate);
        }
    }
}