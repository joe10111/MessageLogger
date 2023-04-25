using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Xml.Linq;

namespace MessageLogger.UnitTests
{
	public class UserUnitTests
	{
		[Fact]
		public void Test_User_Constructor_UserHasName()
		{
            User testUser = new User("Joe", "joe1011");

            Assert.Equal("Joe", testUser.Name);
		}

        [Fact]
        public void Test_User_Constructor_UserHasUserName()
        {
            User testUser = new User("Joe", "joe1011");

            Assert.Equal("joe1011", testUser.UserName);
        }

        [Fact]
        public void Test_User_Constructor_UserHasEmptyListOfUsers()
        {
            User testUser = new User("Joe", "joe1011");

            Assert.Equal(new List<Message> { }, testUser.ListOfMessages);  
        }

        [Fact]
        public void Test_User_AddMessage_UserCanAddMessage()
        {
            User testUser = new User("Joe", "joe1011");
            Message messageToAdd = new Message("test-Message-Content");
            testUser.AddMessage(messageToAdd);
            Assert.Equal(new List<Message> { messageToAdd }, testUser.ListOfMessages);
        }

        [Fact]
        public void Test_User_LogMessages_UserCanLogMessages()
        {
            User testUser = new User("Joe", "joe1011");

            Message firstMessageToAdd = new Message("test-Message-Content");
            Message secondMessageToAdd = new Message("test-Message-Content");

            testUser.AddMessage(firstMessageToAdd);

            string expected = $"{testUser.Name} {firstMessageToAdd.CreatedAt.ToString("h: mm tt")} : {firstMessageToAdd.Content}\n";

            Assert.Equal(expected, testUser.LogMessages());
        }
    }
}

