using System;
namespace MessageLogger
{
	public class User
	{
        public string UserName;
        public string Name;

        public List<Message> ListOfMessages;

        public User(string name, string userName)
		{
            Name = name;
            UserName = userName;

            ListOfMessages = new List<Message> { };
        }

        public void AddMessage(Message message)
        {
            ListOfMessages.Add(message);
        }

        public void LogMessages()
        {
            foreach (var message in ListOfMessages)
            {
                Console.WriteLine($"{Name} {message.CreatedAt.ToString("h: mm tt")} : {message.Content}");
            }
        }
    }
}

