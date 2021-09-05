using System;

namespace GeometryMaster
{
	public class Circle : IFigure
	{
		public Circle(double radius)
		{
			if (radius < 0)
				throw new Exception($"Can not create circle with negative radius {radius}");
			Radius = radius;
		}

		public double Square =>
			Math.PI * Math.Pow(Radius, 2);

		public double Perimeter =>
			Diameter * Math.PI;

		public double Diameter => Radius * 2;

		public double Radius { get; }
	}
}
