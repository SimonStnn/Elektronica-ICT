using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
	internal class Line
	{
		private Point begin;
		private Point end;

		public Point Begin { get { return begin; } set { begin = value; } }
		public Point End { get { return end; } set { end = value; } }

		public int GetBeginX() { return Begin.X; }
		public int GetBeginY() { return Begin.Y; }
		public int GetEndX() { return End.X; }
		public int GetEndY() { return End.Y; }

		public void SetBeginX(int x) { Begin.X = x; }
		public void SetBeginY(int y) { Begin.Y = y; }
		public void SetEndX(int x) { End.X = x; }
		public void SetEndY(int y) { End.Y = y; }

		public int[] GetBeginXY() { return new int[2] {Begin.X, Begin.Y }; }
		public int[] GetEndXY() { return new int[2] {End.X, End.Y}; }

		public void SetBeginXY(int x, int y) { Begin.SetXY(x, y); }
		public void SetEndXy(int x, int y) { End.SetXY(x, y); }

		public override string ToString()
		{
			return $"[{Begin} {End}]";
		}

		public double GetLength()
		{
			return Begin.Distance(End);
		}

		public Point GetMidPoint()
		{
			Point midPoint = new();
			midPoint.X = (Begin.X + End.X) / 2;
			midPoint.Y = (Begin.Y + End.Y) / 2;
			return midPoint;
		}
	}
}
