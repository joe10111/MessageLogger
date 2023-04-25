namespace MessageLogger.UnitTests
{
    public class MessageUnitTests
    {
        [Fact]
        public void Test_Message_Constructor_MessageHasContent()
        {
            Message testMessae = new Message("hi");

            Assert.Equal("hi", testMessae.Content);
        }

        [Fact]
        public void Test_Message_Constructor_MessageHasDateTime()
        {
            Message testMessae = new Message("hi");

            Assert.IsType<DateTime>(testMessae.CreatedAt);
        }
    }
}