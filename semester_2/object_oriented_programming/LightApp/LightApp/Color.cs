using System;
using System.Collections.Generic;
using System.Text;

namespace LightApp
{
	class Color
	{
		// UML diagram
		//
		// Color
		// ---------------------------------
		// - red: int           // 0 - 255
		// - green: int         // 0 - 255
		// - blue: int          // 0 - 255
		// ---------------------------------
		// + Color()
		// + Color(red: int, green:int, blue: int)
		// 
		// + << get >> Red: int
		// + << set >> Red: int
		// + << get >> Green: int
		// + << set >> Green: int
		// + << get >> Blue: int
		// + << set >> Blue: int
		// + Dim(precentage:int)
		// + ToString(): string     // [R=10, G=24, B=55]
		// ---------------------------------
		//
		// TIPS
		//
		// red, green and blue must have a value [0,255]
		// Try to write this in one line of code in stead of using if()
		// 
		// use percentage [0,100] to change all value's 

		private int red;
		private int green;
		private int blue;

		public int Red
		{
			get { return red; }
			set { red = Math.Max(0, Math.Min(255, value)); }
		}

		public int Green
		{
			get { return green; }
			set { green = Math.Max(0, Math.Min(255, value)); }
		}

		public int Blue
		{
			get { return blue; }
			set { blue = Math.Max(0, Math.Min(255, value)); }
		}

		public Color() : this(0, 0, 0)
		{
		}

		public Color(int red, int green, int blue)
		{
			Red = red;
			Green = green;
			Blue = blue;
		}

		public void Dim(int percentage)
		{
			percentage = Math.Min(Math.Max(0, percentage), 100);
			percentage /= 100;

			Red *= percentage;
			Green *= percentage;
			Blue *= percentage;
		}

		public override string ToString()
		{
			return $"[R={Red}, G={Green}, B={Blue}]";
		}
	}
}
