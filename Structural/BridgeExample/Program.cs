using System;

namespace BridgeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Testing the TV remote");
            RemoteControl remoteControlTV = new RemoteControlAdvanced(new TV());
            client.ClientCode(remoteControlTV);

            //Console.WriteLine("");
            //Console.WriteLine("Testing the Radio remote");
            //RemoteControl remoteControlRadio = new RemoteControlRadio(new Radio());
            //client.ClientCode(remoteControlRadio);

        }
    }
}
