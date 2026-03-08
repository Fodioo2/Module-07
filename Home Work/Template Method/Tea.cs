using System;

public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }
}