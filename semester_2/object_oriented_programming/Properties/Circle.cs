using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
	internal class Circle
	{
		private double radius;
		private Point origin;

		public double Radius { get { return radius; } set { radius = Math.Abs(value); } }
		public Point Origin { get { return origin; } set { origin = value; } }

		public double Area()
		{
			return 2 * Math.PI * Radius;
		}

		public override string ToString()
		{
			return $"[{Origin}, radius={Radius}]";
		}
	}
}
