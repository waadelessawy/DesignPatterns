using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns
{
   
    //The Command interface declares a method, often named execute(). This method is meant to encapsulate a specific operation. The interface sets a contract for concrete command classes, defining the execute() method that encapsulates the operation to be performed.
    public interface Command
    {
        void execute();
    }


    //Concrete command classes implement the Command interface. Each class encapsulates a specific operation related to devices. Each concrete command class provides a specific implementation of the execute() method, defining how a particular device operation (turning on, turning off, adjusting volume, changing channel) is executed.
    public class TurnOnCommand : Command
    {
        private Device device;

        public TurnOnCommand(Device device)
        {
            this.device = device;
        }

        public void execute()
        {
            device.turnOn();
        }
    }

    public class TurnOffCommand : Command
    {
        private Device device;

        public TurnOffCommand(Device device)
        {
            this.device = device;
        }

        public void execute()
        {
            device.turnOff();
        }
    }

    public class AdjustVolumeCommand : Command
    {
        private Stereo stereo;

        public AdjustVolumeCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.adjustVolume();
        }
    }

    public class ChangeChannelCommand : Command
    {
        private TV tv;

        public ChangeChannelCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.changeChannel();
        }
    }

    //The Device interface declares methods related to device functionality, such as turnOn() and turnOff(). This interface sets a contract for device classes, defining common operations that concrete devices should support.

    public interface Device
    {
        void turnOn();
        void turnOff();
    }


    // Concrete receiver for a TV
    public class TV : Device
    {
        public void turnOn()
        {
            Console.WriteLine("TV is now on");
        }

        public void turnOff()
        {
            Console.WriteLine("TV is now off");
        }

        public void changeChannel()
        {
            Console.WriteLine("Channel changed");
        }
}

// Concrete receiver for a stereo
    public class Stereo : Device
    {
        public void turnOn()
        {
            Console.WriteLine("Stereo is now on");
        }

    
        public void turnOff()
        {
            Console.WriteLine("Stereo is now off");
        }

        public void adjustVolume()
        {
            Console.WriteLine("Volume adjusted");
        }
    }

    //The invoker class holds a reference to a Command object and triggers its execution through the execute() method. The invoker doesn't know the specific details of the command or the devices. It simply calls the execute() method on the current command, allowing for flexible and dynamic control over different devices.

    public class RemoteControl
    {
        private Command command;

        public void setCommand(Command command)
        {
            this.command = command;
        }

        public void pressButton()
        {
            command.execute();
        }
    }
}
