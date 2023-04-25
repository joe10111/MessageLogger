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

MessageManager userCollection = new MessageManager("Test User Data Base");

Console.WriteLine("Welcome to Message Logger! \n Enter `quit` to end program. \n When logged in type `log out` to log out");

string response = "";

User currentUser; // make current user equak to who ever you log into. 

while(response.ToLower() != "quit")
{
    response = "";
    currentUser = userCollection.NewUser();

    while(response.ToLower() != "log out")
    {
        Console.Write("Add a message: ");
        response = Console.ReadLine();

        if (response.ToLower() == "quit")
        {
            break;
        }

        if (response.ToLower() == "log out")
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

    userCollection.LogOutOfUser(currentUser.UserName);
}

userCollection.QuitProgram();

// add log out && quit producer

// Keep quit and log out seprate states
  // Adding logic for quitting and logging out
