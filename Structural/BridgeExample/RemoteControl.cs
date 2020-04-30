using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    // The "abstraction" defines the interface for the "control"
    // part of the two class hierarchies. It maintains a reference
    // to an object of the "implementation" hierarchy and delegates
    // all of the real work to this object.

    class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            this._device = device;
        }

        public virtual void TogglePower()
        {
            if (_device.isEnabled())
            {
                _device.disable();
            }
            else
            {
                _device.enable();
            }
        }

        public virtual bool ShowPower()
        {
            return _device.isEnabled();
        }

        public virtual void VolumeDown()
        {
            if (_device.isEnabled())
            {
                _device.setVolume(_device.getVolume() - 10);
            }
        }

        public virtual void VolumeUp()
        {
            if (_device.isEnabled())
            {
                _device.setVolume(_device.getVolume() + 10);
            }
        }

        public virtual int ShowVolume()
        {
            if (_device.isEnabled())
            {
                return _device.getVolume();
            } else
            {
                return 0;
            }
        }

        public virtual void ChannelDown()
        {
            if (_device.isEnabled())
            {
                _device.setChannel(_device.getChannel() - 1);
            }
        }
        
        public virtual void ChannelUp()
        {
            if (_device.isEnabled())
            {
                _device.setChannel(_device.getChannel() + 1);
            }
        }

        public virtual double ShowChannel()
        {
            if (_device.isEnabled())
            {
                return _device.getChannel();
            } else
            {
                return 0.0;
            }
        }

    }
}
