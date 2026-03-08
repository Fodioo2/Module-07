using System;

class Program
{
    static void Main()
    {
        Beverage tea = new Tea();
        tea.PrepareRecipe();

        Console.WriteLine();

        Beverage coffee = new Coffee();
        coffee.PrepareRecipe();
    }
}
