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

		public int GetX()
		{
			return x;
		}

		public void SetX(int x)
		{
			this.x = x;
		}

		public int GetY()
		{
			return y;
		}

		public void SetY(int y)
		{
			this.y = y;
		}

		public override string ToString()
		{
			return $"({x},{y})";
		}

		public int[] GetXY()
		{
			return new int[] { x, y };
		}

		public void SetXY(int x, int y)
		{
			SetX(x);
			SetY(y);
		}

		public double Distance(int x, int y)
		{
			return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
		}

		public double Distance(Point point)
		{
			return Distance(point.GetX(), point.GetY());
		}

		public double Distance()
		{
			return Distance(0, 0);
		}
	}
}
