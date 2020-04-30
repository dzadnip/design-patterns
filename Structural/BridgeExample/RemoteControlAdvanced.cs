using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    // The "abstraction" defines the interface for the "control"
    // part of the two class hierarchies. It maintains a reference
    // to an object of the "implementation" hierarchy and delegates
    // all of the real work to this object.

    class RemoteControlAdvanced : RemoteControl
    {
        public RemoteControlAdvanced(IDevice device) : base(device)
        {
        }

        public virtual void Mute()
        {
            if (_device.isEnabled())
            {
                _device.setVolume(0);
            }
        }
    }
}
