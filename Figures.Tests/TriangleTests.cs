using Figures.Interfaces;
namespace Figures.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CanExists_OneZeroValue_ReturnsFalse()
        {
            double firstSide = 0;
            double secondSide = 2;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.False(triangle.CanExists());
        }

        [Fact]
        public void CanExists_OneNegativeValue_ReturnsFalse()
        {
            double firstSide = 1;
            double secondSide = -1;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.False(triangle.CanExists());
        }

        [Fact]
        public void CanExists_PositiveValue_ReturnsTrue()
        {
            double firstSide = 2;
            double secondSide = 2;
            double thirdSide = 2;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.True(triangle.CanExists());
        }

        [Fact]
        public void CanExists_PositiveBadValue_ReturnsFalse()
        {
            double firstSide = 2;
            double secondSide = 5;
            double thirdSide = 2;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.False(triangle.CanExists());
        }

        [Fact]
        public void GetTriangleArea_PositiveValue_Returns_4_15()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var area = triangle.GetArea();

            Assert.Equal(4.15, area);
        }

        [Fact]
        public void GetTriangleArea_NegativeValue_Returns0()
        {
            double firstSide = -1;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var area = triangle.GetArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void GetTriangleArea_OneZeroValue_Returns0()
        {
            double firstSide = 0;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var area = triangle.GetArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void IsRightTriangle_PositiveValue_ReturnsFalse()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }

        [Fact]
        public void IsRightTriangle_OneNegativeValue_ReturnsFalse()
        {
            double firstSide = 3;
            double secondSide = -9;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }

        [Fact]
        public void IsRightTriangle_OneZeroValue_ReturnsFalse()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 0;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }

        [Fact]
        public void IsRightTriangle_AllGoodValues_ReturnsTrue()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 4;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.True(result);
        }

        [Fact]
        public void IsRightTriangle_BadValues_ReturnsFalse()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }
    }
}
