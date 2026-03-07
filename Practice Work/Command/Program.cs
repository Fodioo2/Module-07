using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Light light = new Light();
        TV tv = new TV();
        AirConditioner ac = new AirConditioner();
        Curtains curtains = new Curtains();
        MusicPlayer player = new MusicPlayer();

        ICommand lightOn = new LightOnCommand(light);
        ICommand lightOff = new LightOffCommand(light);

        ICommand tvOn = new TVOnCommand(tv);
        ICommand tvOff = new TVOffCommand(tv);

        ICommand acOn = new AirConditionerOnCommand(ac);
        ICommand acOff = new AirConditionerOffCommand(ac);

        ICommand curtainsOpen = new CurtainsOpenCommand(curtains);
        ICommand curtainsClose = new CurtainsCloseCommand(curtains);

        ICommand musicPlay = new MusicPlayCommand(player);
        ICommand musicStop = new MusicStopCommand(player);

        ICommand eveningMacro = new MacroCommand(new List<ICommand>
        {
            lightOn,
            tvOn,
            acOn,
            curtainsClose,
            musicPlay
        });

        RemoteControl remote = new RemoteControl();

        remote.SetCommand(1, lightOn);
        remote.SetCommand(2, lightOff);
        remote.SetCommand(3, tvOn);
        remote.SetCommand(4, tvOff);
        remote.SetCommand(5, acOn);
        remote.SetCommand(6, acOff);
        remote.SetCommand(7, curtainsOpen);
        remote.SetCommand(8, curtainsClose);
        remote.SetCommand(9, musicPlay);
        remote.SetCommand(10, musicStop);
        remote.SetCommand(11, eveningMacro);

        while (true)
        {
            remote.ShowMenu();
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (choice == 0)
                break;

            switch (choice)
            {
                case 12:
                    remote.Undo();
                    break;
                case 13:
                    remote.Redo();
                    break;
                default:
                    remote.PressButton(choice);
                    break;
            }
        }

        Console.WriteLine("Program finished.");
    }
}