using System;
namespace MessageLogger
{
	public class UserDataBase
	{
        public string NameOfDataBase;
        public List<User> ListOfUsers;

        public UserDataBase(string nameOfDataBase)
		{
            NameOfDataBase = nameOfDataBase;
            ListOfUsers = new List<User> { };
        }

        public User AddUser()
        {
            Console.WriteLine("Lets create a profile for you!");
            Console.Write("Whats your name? : ");
            string responseName = Console.ReadLine();
            Console.Write("What should your User Name be? (One word! No spaces!) : ");
            string responseUserName = Console.ReadLine();

            User newUser = new User(responseName, responseUserName);

            ListOfUsers.Add(newUser);

            return newUser;
        }
    }
}

