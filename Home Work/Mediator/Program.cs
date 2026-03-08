using System;

class Program
{
    static void Main()
    {
        ChatRoom chat = new ChatRoom();

        User u1 = new User("Ali", chat);
        User u2 = new User("Bek", chat);
        User u3 = new User("Dana", chat);

        chat.AddUser(u1);
        chat.AddUser(u2);
        chat.AddUser(u3);

        u1.Send("Hello everyone");
    }
}