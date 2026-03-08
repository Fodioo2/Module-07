using System;


public class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute() => light.On();

    public void Undo() => light.Off();
}
public class DoorOpenCommand : ICommand
{
    private Door door;

    public DoorOpenCommand(Door door)
    {
        this.door = door;
    }

    public void Execute() => door.Open();

    public void Undo() => door.Close();
}
public class TempUpCommand : ICommand
{
    private Thermostat thermostat;

    public TempUpCommand(Thermostat thermostat)
    {
        this.thermostat = thermostat;
    }

    public void Execute() => thermostat.Increase();

    public void Undo() => thermostat.Decrease();
}