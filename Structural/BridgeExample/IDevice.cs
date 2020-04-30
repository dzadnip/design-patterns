using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    // The "implementation" interface declares methods common to all
    // concrete implementation classes. It doesn't have to match the
    // abstraction's interface. In fact, the two interfaces can be
    // entirely different. Typically the implementation interface
    // provides only primitive operations, while the abstraction
    // defines higher-level operations based on those primitives.

    // The Implementation defines the interface for all implementation classes.
    // It doesn't have to match the Abstraction's interface. In fact, the two
    // interfaces can be entirely different. Typically the Implementation
    // interface provides only primitive operations, while the Abstraction
    // defines higher- level operations based on those primitives.

    interface IDevice
    {
        bool isEnabled();
        void enable();
        void disable();
        int getVolume();
        void setVolume(int percent);
        double getChannel();
        void setChannel(double channel);
    }
}
