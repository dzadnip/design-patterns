using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    class Client
    {
        // Except for the initialization phase, where an Abstraction object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Abstraction class. This way the client code can
        // support any abstraction-implementation combination.
        public void ClientCode(RemoteControl remoteControl)
        {
            Console.WriteLine("Power: {0}", remoteControl.ShowPower());
            Console.WriteLine("Channel: {0}", remoteControl.ShowChannel());
            Console.WriteLine("Volume: {0}", remoteControl.ShowVolume());
            Console.WriteLine("");
            Console.WriteLine("Let's click some buttons on the remote");
            remoteControl.TogglePower();
            Console.WriteLine("Power: {0}", remoteControl.ShowPower());
            Console.WriteLine("Channel: {0}", remoteControl.ShowChannel().ToString("N1"));
            Console.WriteLine("Volume: {0}", remoteControl.ShowVolume());

            Console.WriteLine("");
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(1, 150); i++)
            {
                Console.WriteLine("Channel up");
                remoteControl.ChannelUp();
            }
            Console.WriteLine("Channel: {0}", remoteControl.ShowChannel().ToString("N1"));

            Console.WriteLine("");
            for (int i = 0; i < rnd.Next(1, 150); i++)
            {
                Console.WriteLine("Volume Up");
                remoteControl.VolumeUp();
            }
            Console.WriteLine("Volume: {0}", remoteControl.ShowVolume());

            Console.WriteLine("");
            for (int i = 0; i < rnd.Next(1, 150); i++)
            {
                Console.WriteLine("Channel Down");
                remoteControl.ChannelDown();
            }
            Console.WriteLine("Channel: {0}", remoteControl.ShowChannel().ToString("N1"));

            Console.WriteLine("");
            for (int i = 0; i < rnd.Next(1, 150); i++)
            {
                Console.WriteLine("Volume Down");
                remoteControl.VolumeDown();
            }
            Console.WriteLine("Volume: {0}", remoteControl.ShowVolume());

        }
    }
}
