namespace Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CanExist_PositiveValue_ReturnsTrue()
        {
            double radius = 1.2;
            var circle = new Circle(radius);

            Assert.True(circle.CanExists());
        }

        [Fact]
        public void CanExist_NegativeValue_ReturnsFalse()
        {
            double radius = -1;
            var circle = new Circle(radius);

            Assert.False(circle.CanExists());
        }

        [Fact]
        public void CanExist_ZeroValue_ReturnsFalse()
        {
            double radius = 0;
            var circle = new Circle(radius);

            Assert.False(circle.CanExists());
        }

        [Fact]
        public void GetCircleArea_PositiveValue_Returns1256_64()
        {
            double radius = 20;
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(1256.64, area);
        }

        [Fact]
        public void GetCircleArea_NegativeValue_Returns0()
        {
            double radius = -1;
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(0.0, area);
        }

        [Fact]
        public void GetCircleArea_ZeroValue_Returns0()
        {
            double radius = 0;
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(0.0, area);
        }
    }
}
