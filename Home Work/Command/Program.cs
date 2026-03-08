class Program
{
    static void Main()
    {
        Light light = new Light();
        Door door = new Door();
        Thermostat thermostat = new Thermostat();

        ICommand lightOn = new LightOnCommand(light);
        ICommand doorOpen = new DoorOpenCommand(door);
        ICommand tempUp = new TempUpCommand(thermostat);

        Invoker invoker = new Invoker();

        invoker.RunCommand(lightOn);
        invoker.RunCommand(doorOpen);
        invoker.RunCommand(tempUp);

        Console.WriteLine("Undo last command:");
        invoker.Undo();
    }
}