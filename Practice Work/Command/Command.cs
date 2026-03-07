using System;

public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.On();
    public void Undo() => _light.Off();
}

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.Off();
    public void Undo() => _light.On();
}

public class TVOnCommand : ICommand
{
    private readonly TV _tv;

    public TVOnCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute() => _tv.On();
    public void Undo() => _tv.Off();
}

public class TVOffCommand : ICommand
{
    private readonly TV _tv;

    public TVOffCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute() => _tv.Off();
    public void Undo() => _tv.On();
}

public class AirConditionerOnCommand : ICommand
{
    private readonly AirConditioner _ac;

    public AirConditionerOnCommand(AirConditioner ac)
    {
        _ac = ac;
    }

    public void Execute() => _ac.On();
    public void Undo() => _ac.Off();
}

public class AirConditionerOffCommand : ICommand
{
    private readonly AirConditioner _ac;

    public AirConditionerOffCommand(AirConditioner ac)
    {
        _ac = ac;
    }

    public void Execute() => _ac.Off();
    public void Undo() => _ac.On();
}

public class CurtainsOpenCommand : ICommand
{
    private readonly Curtains _curtains;

    public CurtainsOpenCommand(Curtains curtains)
    {
        _curtains = curtains;
    }

    public void Execute() => _curtains.Open();
    public void Undo() => _curtains.Close();
}

public class CurtainsCloseCommand : ICommand
{
    private readonly Curtains _curtains;

    public CurtainsCloseCommand(Curtains curtains)
    {
        _curtains = curtains;
    }

    public void Execute() => _curtains.Close();
    public void Undo() => _curtains.Open();
}

public class MusicPlayCommand : ICommand
{
    private readonly MusicPlayer _player;

    public MusicPlayCommand(MusicPlayer player)
    {
        _player = player;
    }

    public void Execute() => _player.Play();
    public void Undo() => _player.Stop();
}

public class MusicStopCommand : ICommand
{
    private readonly MusicPlayer _player;

    public MusicStopCommand(MusicPlayer player)
    {
        _player = player;
    }

    public void Execute() => _player.Stop();
    public void Undo() => _player.Play();
}
