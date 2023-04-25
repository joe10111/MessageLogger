using System;
namespace MessageLogger.UnitTests
{
	public class MessageManagerUnitTests
	{
        [Fact]
        public void Test_MessageManager_Constructor_MangerHasName()
        {
            MessageManager testManager = new MessageManager("Test-DataBase");

            Assert.Equal("Test-DataBase", testManager.NameOfManager);
        }

        [Fact]
        public void Test_MessageManager_Constructor_UserListIsEmpty()
        {
            MessageManager testManager = new MessageManager("Test-DataBase");

            Assert.Empty(testManager.ListOfUsers);
        }

        /* Cant test becuse of readline() calls
        [Fact]
        public void Test_MessageManager_NewUser_CanMakeNewUser()
        {
            MessageManager testManager = new MessageManager("Test-DataBase");

            Assert.Empty(testManager.ListOfUsers);
        }
        */

        [Fact]
        public void Test_MessageManager_LoginUser_UserCanLogIn()
        {
            MessageManager testManager = new MessageManager("Test-DataBase");
            User tempUserJoe = new User("Joe", "joe1011");

            testManager.ListOfUsers.Add(tempUserJoe);

            Assert.Equal(tempUserJoe, testManager.LogInUser("joe1011"));
        }

        /* I should wait to test these untill I handle states of log in and out
        [Fact]
        public void Test_MessageManager_LogOutUser_UserCanLogOut()
        {
            MessageManager testManager = new MessageManager("Test-DataBase");
            User tempUserJoe = new User("Joe", "joe1011");

            testManager.ListOfUsers.Add(tempUserJoe);

            testManager.LogOutOfUser("joe1011");

            Assert.Equal(tempUserJoe, testManager.LogInUser("joe1011"));
        }
        

        [Fact]
        public void Test_MessageManager_GetAllUserLogs_CanGetAllLogs()
        {
            MessageManager testManager = new MessageManager("Test-DataBase");
            User tempUserJoe = new User("Joe", "joe1011");

            tempUserJoe.AddMessage(new Message("Hi"));
            tempUserJoe.AddMessage(new Message("Bye"));

            string userLogs = testManager.GetAllUsersLogs();
            string expected = 
            Assert.Equal();
        }
        */
    }
}

