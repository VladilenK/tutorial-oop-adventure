namespace oopadventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello! What is your neme?";
        DefaultName = "<no name provided>";
        Welcome = "Welcome! Your name is:{0}";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomName = "You are in a room with doors to the {0}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go (that way).";
    }
}
