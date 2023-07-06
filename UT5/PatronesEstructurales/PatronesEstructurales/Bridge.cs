using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatronesEstructurales
{
	public interface Device {

		public bool isEnabled();
        public void enable();
		public void disable();
		public int getVolume();
		public void setVolume(int percent);
		public int getChannel();
		public void setChannel(int channel);

		public void printStatus();
	}


	public class Radio : Device
	{
        private bool on = false;
        private int volume =  30;
        private int channel = 1;


		public Radio()
		{
		}

        public void disable()
        {
            on = false;
        }

        public void enable()
        {
            on = true;
        }

        public int getChannel()
        {
            return channel;
        }

        public int getVolume()
        {
            return volume;
        }

        public bool isEnabled()
        {
            return on;
        }

        public void printStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm radio.");
            Console.WriteLine("| I'm " + (on ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + volume + "%");
            Console.WriteLine("| Current channel is " + channel);
            Console.WriteLine("------------------------------------\n");
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int percent)
        {
            if(volume > 100) {
                volume = 100;
            } else if (volume < 0) {
                volume = 0;
            }
            else {
                this.volume = percent;
            }
        }
    }

    public class Tv : Device
    {
        private bool on = false;
        private int volume = 30;
        private int channel = 1;
        public void disable()
        {
            on = false;
        }

        public void enable()
        {
            on = true;
        }

        public int getChannel()
        {
            return channel;
        }

        public int getVolume()
        {
            return volume;
        }

        public bool isEnabled()
        {
            return on;
        }

        public void printStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm TV.");
            Console.WriteLine("| I'm " + (on ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + volume + "%");
            Console.WriteLine("| Current channel is " + channel);
            Console.WriteLine("------------------------------------\n");
        }


        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int percent)
        {
            if (volume > 100)
            {
                volume = 100;
            }
            else if (volume < 0)
            {
                volume = 0;
            }
            else
            {
                this.volume = percent;
            }
        }
    }

    public interface Remote
    {
        public void power();

        public void volumeDown();

        public void volumeUp();

        public void channelDown();

        public void channelUp();
    }

    public class BasicRemote : Remote
    {

        protected Device device;

        public BasicRemote(Device device) {
            this.device = device;
        }

        public BasicRemote() { }


        public void channelDown()
        {
            device.setChannel(device.getChannel() - 1);
        }

        public void channelUp()
        {
            device.setChannel(device.getChannel() + 1);
        }

        public void power()
        {
            if (device.isEnabled()) {
                device.disable();
            }
            else {
                device.enable();
            };
        }

        public void volumeDown()
        {
            device.setVolume(device.getVolume() - 10);
        }

        public void volumeUp()
        {
            device.setVolume(device.getVolume() + 10);
        }
    }
}

