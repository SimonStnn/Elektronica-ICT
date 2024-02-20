using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
	internal class Circle
	{
		// Attributes
		private double radius = 1;
		private string color = "red";

		// Getters and Setters
		public string GetColor()
		{
			return color;
		}

		public void SetColor(string color)
		{
			this.color = color;
		}

		public double GetRadius()
		{
			return radius;
		}

		public void SetRadius(double radius)
		{
			this.radius = Math.Abs(radius);
		}

		// Methods
		public double GetArea()
		{
			return Math.PI * Math.Pow(radius, 2);
		}
	}
}
