using System;
using Xunit;
using GeometryMaster;

namespace GeometryMaster.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsSquareCalculatesRight()
        {
            var triangle1 = new Triangle(3, 3, 3);
            var triangle2 = new Triangle(10, 11, 2.33);

            Assert.Equal(3.89711, triangle1.Square, 5);
            Assert.Equal(10.98038, triangle2.Square, 5);
        }

        [Fact]
        public void CannotCreateUnexistingTriangles()
        {
            var triangle1 = new Triangle(3, 3, 3);
            var triangle2 = new Triangle(3, 5, 4);
            var triangle3 = new Triangle(10.33, 5.9, 10);

            Assert.Throws(
                new Exception().GetType(),
                () => { new Triangle(1, 1, 3); }
            );

            Assert.Throws(
                new Exception().GetType(),
                () => { new Triangle(3, 1, 1); }
            );

            Assert.Throws(
                new Exception().GetType(),
                () => { new Triangle(1, 3, 1); }
            );
        }

        [Fact]
        public void IsRectangularMethodWorksRight()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(3, 3, 3);

            Assert.True(triangle1.IsRectangular);
            Assert.False(triangle2.IsRectangular);
        }
    }
}
