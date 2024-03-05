using System;
using System.Collections.Generic;
using System.Text;

namespace LightApp
{
	class LightBulb
	{
		// LightBulb
		// ------------------
		// - brightness : int        // 0 - 100
		// - isOn : bool
		// - location: string
		// ------------------
		// + LightBulb()            // set brightness to 50
		// + LightBulb(brightness: int)
		// + LightBulb(brightness: int, location: string)
		// + On()
		// + Off()
		// + SetLocation(location: string)
		// + Dim(percentage : int)  // if the light is off then turn it on
		// + ToString() : string    // start with the location and then the state of the lamp and if needed the brightness
		// ------------------

		private int brightness;
		private bool isOn;
		private string location;

		public LightBulb() : this(50) { }

		public LightBulb(int brightness) : this(brightness, "") { }

		public LightBulb(int brightness, string location)
		{
			this.brightness = brightness;
			this.location = location;
		}

		public void On()
		{
			isOn = true;
		}

		public void Off()
		{
			isOn = false;
		}

		public void SetLocation(string location)
		{
			this.location = location;
		}

		public void Dim(int percentage)
		{
			percentage = Math.Min(Math.Max(0, percentage), 100);
			percentage /= 100;
			brightness *= percentage;
		}

		public override string ToString()
		{
			return $"{location}";
		}
	}
}
