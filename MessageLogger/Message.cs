using System;
namespace MessageLogger
{
	public class Message
	{
		public string Content { get; set; }
		public DateTime CreatedAt { get; }
		

		public Message(string content) 
		{
			Content = content;
			CreatedAt = DateTime.Now;
        }
	}
}

