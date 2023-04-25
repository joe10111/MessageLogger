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

User currentUser; // make current user equak to who ever you log into. 

while(response.ToLower() != "quit")
{
     
    currentUser = userCollection.newUser();

    while(response.ToLower() != "log out")
    {
        Console.Write("Add a message: ");
        response = Console.ReadLine();

        if (response.ToLower() == "quit")
        {
            break;
        }

        Message message = new Message(response);
  
        currentUser.AddMessage(message);
        currentUser.LogMessages();
    }


    if (response.ToLower() == "quit")
    {
        break;
    }

    Console.WriteLine("Logged Out\n Type anything to continue...\n Type `quit` to exit...");
    response = Console.ReadLine();
    
}

Console.WriteLine(userCollection.GetAllUsers());
Console.WriteLine("Program is quit");

