using System;

class Program
{
    static void Main()
    {
        ChannelMediator mediator = new ChannelMediator();

        User alice = new User("Alice", mediator);
        User bob = new User("Bob", mediator);
        User charlie = new User("Charlie", mediator);
        User diana = new User("Diana", mediator);

        mediator.AddUserToChannel("general", alice);
        mediator.AddUserToChannel("general", bob);
        mediator.AddUserToChannel("games", charlie);
        mediator.AddUserToChannel("games", alice);
        mediator.AddUserToChannel("study", diana);
        mediator.AddUserToChannel("study", bob);

        mediator.ShowChannels();

        alice.SendToChannel("general", "Hello everyone!");
        bob.SendToChannel("general", "Hi Alice!");

        charlie.SendToChannel("games", "Who wants to play?");
        alice.SendToChannel("games", "I am ready!");

        diana.SendToChannel("study", "Let's prepare for exam.");
        bob.SendToChannel("study", "Good idea.");

        alice.SendPrivate(bob, "Private message for Bob.");

        mediator.RemoveUserFromChannel("general", bob);
        alice.SendToChannel("general", "Bob has left.");

        bob.SendToChannel("general", "Can you still see this?");
    }
}