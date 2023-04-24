using System;
namespace MessageLogger
{
	public class Message
	{
		public string Content;
		public DateTime CreatedAt;
		

		public Message(string content, DateTime createdAt) 
		{
			Content = content;
			CreatedAt = createdAt;
			
        }
	}
}

