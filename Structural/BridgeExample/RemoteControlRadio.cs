using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    // The "abstraction" defines the interface for the "control"
    // part of the two class hierarchies. It maintains a reference
    // to an object of the "implementation" hierarchy and delegates
    // all of the real work to this object.

    class RemoteControlRadio : RemoteControlAdvanced
    {
        public RemoteControlRadio(IDevice device) : base(device)
        {
        }

        public override void VolumeDown()
        {
            _device.setVolume(_device.getVolume() - 2);
        }

        public override void VolumeUp()
        {
            _device.setVolume(_device.getVolume() + 2);
        }

        public override void ChannelDown()
        {
            _device.setChannel(_device.getChannel() - 0.2);
        }

        public override void ChannelUp()
        {
            _device.setChannel(_device.getChannel() + 0.2);
        }
    }
}
