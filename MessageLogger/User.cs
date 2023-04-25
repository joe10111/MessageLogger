using System;
namespace MessageLogger
{
	public class User
	{
        public string UserName { get; set; }
        public string Name { get; set; }
        public bool IsLoggedIn { get; set; }

        public List<Message> ListOfMessages;

        public User(string name, string userName)
		{
            Name = name;
            UserName = userName;
            IsLoggedIn = false;
            ListOfMessages = new List<Message> { };
        }

        public void LogIn(string userName)
        {
            if(userName == UserName)
            {
                Console.WriteLine($"{userName} was found. Hi {Name}!");
                IsLoggedIn = true;
            } else {
                while(userName != UserName)
                {
                    Console.WriteLine("That user name is not found, please log in with existing User Name");

                    userName = Console.ReadLine();
                }
            }
            
        }

        public void LogOut()
        {
            Console.WriteLine("Logged Out\nWould you like to log in again? Type anything to continue...\nType `quit` to exit...");
            IsLoggedIn = false;
        }

        public void AddMessage(Message message)
        {
            ListOfMessages.Add(message);
        }

        public string LogMessages()
        {
            string temp = "";

            foreach (var message in ListOfMessages)
            {
                Console.WriteLine($"{Name} {message.CreatedAt.ToString("h: mm tt")} : {message.Content}");

                temp += $"{Name} {message.CreatedAt.ToString("h: mm tt")} : {message.Content}\n";
            }

            return temp;
        }
    }
}

// Assert.IsType<DateTime>(DateTime);