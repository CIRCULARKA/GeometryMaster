using System;

namespace GeometryMaster
{
	public class Triangle : IFigure
	{
		private readonly double _halfOfPerimeter;

		public Triangle(double firstCathetus, double secondCathetus, double hypotenuse)
		{
			FirstCathetus = firstCathetus;
			SecondCathetus = secondCathetus;
			Hypotenuse = hypotenuse;

			if (!CanExist())
				throw new Exception(
					$"Triangle with sides {FirstCathetus}, {SecondCathetus} and {Hypotenuse}" +
					"can not be created as it can not exist"
				);

			Perimeter = FirstCathetus + SecondCathetus + Hypotenuse;
			_halfOfPerimeter = Perimeter / 2;
		}

		public double FirstCathetus { get; }

		public double SecondCathetus { get; }

		public double Hypotenuse { get; }

		public double Perimeter { get; }

		public bool IsRectangular
		{
			get
			{
				// Find max from all of three sides
				var maxSide = Math.Max(FirstCathetus, Math.Max(SecondCathetus, Hypotenuse));

				// Compare square of max side and sum of squares of two remaining sides
				return Math.Pow(maxSide, 2) ==
					(Math.Pow((FirstCathetus == maxSide ? 0 : FirstCathetus), 2) +
					Math.Pow((SecondCathetus == maxSide ? 0 : SecondCathetus), 2) +
					Math.Pow((Hypotenuse == maxSide ? 0 : Hypotenuse), 2));
			}
		}

		public double Square =>
			Math.Sqrt(
				_halfOfPerimeter *
				(_halfOfPerimeter - FirstCathetus) *
				(_halfOfPerimeter - SecondCathetus) *
				(_halfOfPerimeter - Hypotenuse)
			);

		private bool CanExist() =>
			(FirstCathetus + SecondCathetus > Hypotenuse) &&
			(FirstCathetus + Hypotenuse > SecondCathetus) &&
			(SecondCathetus + Hypotenuse > FirstCathetus);

	}
}
