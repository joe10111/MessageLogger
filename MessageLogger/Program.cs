// Message Loggger Project
// Name : Joe Centeno
// Date : 4/24/23

// Clss structure: 
// Holding class of users like userbase
// User
// Message
// - content of message
// - time date of message
using MessageLogger;

UserDataBase userCollection = new UserDataBase("Test User Data Base");

Console.WriteLine("Welcome to Message Logger! \n Enter `quit` to end program. \n When logged in type `log out` to log out");

string response = "";

User newUser; 

while(response.ToLower() != "quit")
{
    // Left off getting Log In system Working, right now the system will make a new user when ever someone logs out insted of allowing them to decide what users to add. 
        newUser = userCollection.AddUser();

    while(response.ToLower() != "log out")
    {
        Console.Write("Add a message: ");
        response = Console.ReadLine();

        if (response.ToLower() == "quit")
        {
            break;
        }

        Message message = new Message(response);
  
        newUser.AddMessage(message);
        newUser.LogMessages();
    }


    if (response.ToLower() == "quit")
    {
        break;
    }

        newUser.LogOut();
        response = Console.ReadLine();
    
}

Console.WriteLine("Program is quit");

