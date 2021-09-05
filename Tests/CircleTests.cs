using Xunit;
using System;

namespace GeometryMaster.Tests
{
	public class CircleTests
	{
		[Fact]
		public void CannotCreateWithNegativeRadius()
		{
			Assert.Throws(
				new Exception().GetType(),
				() => { new Circle(-1); }
			);

			Assert.Throws(
				new Exception().GetType(),
				() => { new Circle(-0.00000001); }
			);

			new Circle(1);
			new Circle(0.00001);
			new Circle(100);
		}

		[Fact]
		public void IsSquareCalculatesRight()
		{
			var circle1 = new Circle(10);
			var circle2 = new Circle(2.5);
			var circle3 = new Circle(3.33);

			Assert.Equal(314.16, circle1.Square, 2);
			Assert.Equal(19.63, circle2.Square, 2);
			Assert.Equal(34.84, circle3.Square, 2);
		}
	}
}
