namespace Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CanExistPos()
        {
            double radius = 1.2;
            var circle = new Circle(radius);

            Assert.True(circle.CanExists());
        }

        [Fact]
        public void CanExistNeg()
        {
            double radius = -1;
            var circle = new Circle(radius);

            Assert.False(circle.CanExists());
        }

        [Fact]
        public void CanExistZero()
        {
            double radius = 0;
            var circle = new Circle(radius);

            Assert.False(circle.CanExists());
        }

        [Fact]
        public void GetCirclePosArea()
        {
            double radius = 20;
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(1256.64, area);
        }

        [Fact]
        public void GetCircleAreaNegParam()
        {
            double radius = -1;
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(0.0, area);
        }

        [Fact]
        public void GetCircleAreaZeroParam()
        {
            double radius = 0;
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(0.0, area);
        }
    }
}
