using System;

public class Light
{
    public void On() => Console.WriteLine("Light ON");
    public void Off() => Console.WriteLine("Light OFF");
}

public class Door
{
    public void Open() => Console.WriteLine("Door OPENED");
    public void Close() => Console.WriteLine("Door CLOSED");
}

public class Thermostat
{
    private int temperature = 20;

    public void Increase()
    {
        temperature++;
        Console.WriteLine($"Temperature: {temperature}");
    }

    public void Decrease()
    {
        temperature--;
        Console.WriteLine($"Temperature: {temperature}");
    }
}