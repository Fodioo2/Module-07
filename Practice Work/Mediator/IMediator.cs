using System;

public interface IMediator
{
    void AddUserToChannel(string channelName, User user);
    void RemoveUserFromChannel(string channelName, User user);
    void SendMessage(string channelName, string message, User sender);
    void SendPrivateMessage(User sender, User receiver, string message);
}
