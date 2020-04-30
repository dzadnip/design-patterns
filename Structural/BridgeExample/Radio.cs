using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.

    class Radio : IDevice
    {
        private bool _powerState { get; set; }

        private int _volume { get; set; }
        private int _minVolume = 0;
        private int _maxVolume = 90;

        private double _channel { get; set; }
        private double _minChannel = 87.9;
        private double _maxChannel = 107.9;


        public Radio()
        {
            _powerState = false;
            _volume = _minVolume;
            _channel = 87.9;
        }

        public bool isEnabled()
        {
            return _powerState;
        }

        public void enable()
        {
            _powerState = true;
        }

        public void disable()
        {
            _powerState = false;
        }

        public int getVolume()
        {
            return _volume;
        }

        public void setVolume(int percent)
        {
            int volume = _maxVolume * percent / 100;

            if (volume > _maxVolume)
            {
                volume = _maxVolume;
            }

            if (volume < _minVolume)
            {
                volume = _minVolume;
            }

            _volume = volume;
        }

        public double getChannel()
        {
            return _channel;
        }

        public void setChannel(double channel)
        {

            if (channel > _maxChannel)
            {
                _channel = _minChannel + (channel - _maxChannel);
            } else if (channel < _minChannel)
            {
                _channel = _maxChannel - (_minChannel - channel);
            } else
            {
                _channel = channel;
            }           
        }
    }
}
