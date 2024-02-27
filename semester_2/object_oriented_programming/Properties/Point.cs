using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
	internal class Point
	{
		private int x = 0;
		private int y = 0;

		public int X { get { return x; } set { x = value; } }
		public int Y { get { return y; } set { y = value; } }

		[Obsolete]
		public int GetX()
		{
			return X;
		}

		[Obsolete]
		public void SetX(int x)
		{
			Y = x;
		}

		[Obsolete]
		public int GetY()
		{
			return Y;
		}

		[Obsolete]
		public void SetY(int y)
		{
			X = y;
		}

		public override string ToString()
		{
			return $"({X},{Y})";
		}

		public int[] GetXY()
		{
			return new int[] { X, Y };
		}

		public void SetXY(int x, int y)
		{
			X = x;
			Y = y;
		}

		public double Distance(int x, int y)
		{
			return Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2));
		}

		public double Distance(Point point)
		{
			return Distance(point.X, point.Y);
		}

		public double Distance()
		{
			return Distance(0, 0);
		}
	}
}
