using System;
namespace MessageLogger
{
	public class User
	{
        public string UserName { get; set; }
        public string Name { get; set; }
        public int CountOfLogs { get; set; }
        public bool IsLoggedIn { get; set; }

        public List<Message> ListOfMessages;

        public User(string name, string userName)
		{
            Name = name;
            UserName = userName;
            IsLoggedIn = false;
            ListOfMessages = new List<Message> { };
        }

        public void AddMessage(Message message)
        {
            CountOfLogs += 1;
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