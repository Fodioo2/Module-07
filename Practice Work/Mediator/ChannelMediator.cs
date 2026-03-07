using System;
using System.Collections.Generic;
using System.Linq;

public class ChannelMediator : IMediator
{
    private readonly Dictionary<string, List<User>> _channels = new();

    public void AddUserToChannel(string channelName, User user)
    {
        if (!_channels.ContainsKey(channelName))
        {
            _channels[channelName] = new List<User>();
            Console.WriteLine($"Channel '{channelName}' created.");
        }

        if (_channels[channelName].Contains(user))
        {
            Console.WriteLine($"{user.Name} is already in channel '{channelName}'.");
            return;
        }

        _channels[channelName].Add(user);
        NotifyChannel(channelName, $"{user.Name} joined the channel.", user);
    }

    public void RemoveUserFromChannel(string channelName, User user)
    {
        if (!_channels.ContainsKey(channelName))
        {
            Console.WriteLine($"Channel '{channelName}' does not exist.");
            return;
        }

        if (!_channels[channelName].Contains(user))
        {
            Console.WriteLine($"{user.Name} is not in channel '{channelName}'.");
            return;
        }

        _channels[channelName].Remove(user);
        NotifyChannel(channelName, $"{user.Name} left the channel.", user);
    }

    public void SendMessage(string channelName, string message, User sender)
    {
        if (!_channels.ContainsKey(channelName))
        {
            Console.WriteLine($"Channel '{channelName}' does not exist.");
            return;
        }

        if (!_channels[channelName].Contains(sender))
        {
            Console.WriteLine($"{sender.Name} is not a member of channel '{channelName}'.");
            return;
        }

        foreach (User user in _channels[channelName])
        {
            if (user != sender)
            {
                user.Receive($"[{channelName}] {sender.Name}: {message}");
            }
        }
    }

    public void SendPrivateMessage(User sender, User receiver, string message)
    {
        receiver.Receive($"[PRIVATE] {sender.Name}: {message}");
    }

    private void NotifyChannel(string channelName, string message, User excludedUser)
    {
        foreach (User user in _channels[channelName])
        {
            if (user != excludedUser)
            {
                user.Receive($"[{channelName}] SYSTEM: {message}");
            }
        }
    }

    public void ShowChannels()
    {
        Console.WriteLine("\n=== CHANNELS ===");
        foreach (var pair in _channels)
        {
            Console.WriteLine($"{pair.Key}: {string.Join(", ", pair.Value.Select(u => u.Name))}");
        }
        Console.WriteLine();
    }
}