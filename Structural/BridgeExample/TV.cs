using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExample
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.

    class TV : IDevice
    {
        private bool _powerState { get; set; }

        private int _volume { get; set; }
        private int _minVolume = 0;
        private int _maxVolume = 120;

        private int _channel { get; set; }
        private int _maxChannel = 500;
        

        public TV ()
        {
            _powerState = false;
            _volume = 0;
            _channel = 0;
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
            return Convert.ToDouble(_channel);
        }

        public void setChannel(double channel)
        {
            int tempChannel = Convert.ToInt32(channel);

            if (_channel > _maxChannel)
                _channel = tempChannel % _maxChannel;

            _channel = tempChannel;
        }
    }
}
