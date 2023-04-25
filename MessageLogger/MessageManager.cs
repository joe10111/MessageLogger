using System;
namespace MessageLogger
{
	public class MessageManager
	{
        public string NameOfManager;
        public List<User> ListOfUsers;

        public MessageManager(string nameOfDataBase)
		{
            NameOfManager = nameOfDataBase;
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

            Console.WriteLine("Users Found. All User Names in system: ");

            foreach (var user in ListOfUsers)
            {
                Console.WriteLine($"{user.UserName}");
            }

            Console.WriteLine("Enter user name to log into or hit enter to make new account.");


            var response = Console.ReadLine();

            return LogInUser(response.ToLower());
        }

        public User LogInUser(string userName)
        {
            foreach (var user in ListOfUsers)
            {
                if (userName == user.UserName.ToLower())
                {
                    Console.WriteLine($"Logged in as {user.UserName}");
                    return user;
                }
            }

            Console.WriteLine("Could not find user");
            return AddUser(); 
        }

        public void LogOutOfUser(string userName)
        {
            Console.WriteLine($"Logged Out of {userName}");
        }

        public void QuitProgram()
        {
            Console.WriteLine(this.GetAllUsersLogs());
            Console.WriteLine("Program Terminated");
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

        public string GetAllUsersLogs()
        {
            string temp = "";

            foreach(var user in ListOfUsers)
            {
                temp += user.Name + " logged " + user.CountOfLogs + " messages. ";
            }

            return temp.TrimEnd();
        }

        public List<Message> AllMessages()
        {
            List<Message> tempListOfMessages = new List<Message> { };

            foreach (var user in ListOfUsers)
            {
                foreach (var message in user.ListOfMessages)
                {
                    tempListOfMessages.Add(message);
                }
            }

            return tempListOfMessages;
        }

        public List<Message> RecentMessages(int messageCount)
        {
            int tempCount = 0;
            List<Message> tempListOfMessages = new List<Message> { };

            foreach (var user in ListOfUsers)
            {
                if (messageCount >= user.ListOfMessages.Count)
                {
                    return AllMessages();
                }

                foreach (var message in user.ListOfMessages)
                {
                    

                    if(tempCount >= user.ListOfMessages.Count)
                    {
                        return tempListOfMessages;
                    }
                    else
                    {
                        tempListOfMessages.Add(message);
                    }
                    tempCount += 1;

                }
             }

            return tempListOfMessages;
        }
    }
}

