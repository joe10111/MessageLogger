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

        public User newUser()
        {
            User tempUser;

            if(ListOfUsers.Count() == 0)
            {
                tempUser = AddUser();
                return tempUser;
            }

            Console.WriteLine("Users Found. Type in User Name to log-in or type anything but username to make new account: ");

            var response = Console.ReadLine();

            return LogInUser(response.ToLower());
        }

        public User LogInUser(string userName)
        {
            foreach (var user in ListOfUsers)
            {
                if (userName == user.UserName.ToLower())
                {
                    return user;
                }
            }

            Console.WriteLine("Could not find user");
            return AddUser(); 
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

        public string GetAllUsers()
        {
            string temp = "";

            foreach(var user in ListOfUsers)
            {
                temp += user.Name + "Logged " + user.CountOfLogs + " messages. ";
            }

            return temp.TrimEnd();
        }
    }
}

