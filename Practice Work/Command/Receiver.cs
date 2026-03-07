using System;

public class Light
{
    public void On() => Console.WriteLine("Light ON");
    public void Off() => Console.WriteLine("Light OFF");
}

public class TV
{
    public void On() => Console.WriteLine("TV ON");
    public void Off() => Console.WriteLine("TV OFF");
}

public class AirConditioner
{
    public void On() => Console.WriteLine("Air Conditioner ON");
    public void Off() => Console.WriteLine("Air Conditioner OFF");
}

public class Curtains
{
    public void Open() => Console.WriteLine("Curtains OPENED");
    public void Close() => Console.WriteLine("Curtains CLOSED");
}

public class MusicPlayer
{
    public void Play() => Console.WriteLine("Music Player PLAYING");
    public void Stop() => Console.WriteLine("Music Player STOPPED");
}