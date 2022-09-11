using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CanExistsOneZeroParam()
        {
            double firstSide = 0;
            double secondSide = 2;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.False(triangle.CanExists());
        }

        [Fact]
        public void CanExistsOneNegParam()
        {
            double firstSide = 1;
            double secondSide = -1;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.False(triangle.CanExists());
        }

        [Fact]
        public void CanExistsPosParams()
        {
            double firstSide = 2;
            double secondSide = 2;
            double thirdSide = 2;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.True(triangle.CanExists());
        }

        [Fact]
        public void CanExistsPosBadParams()
        {
            double firstSide = 2;
            double secondSide = 5;
            double thirdSide = 2;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.False(triangle.CanExists());
        }

        [Fact]
        public void GetTrianglePosArea()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var area = triangle.GetArea();

            Assert.Equal(4.15, area);
        }

        [Fact]
        public void GetTriangleAreaNegParam()
        {
            double firstSide = -1;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var area = triangle.GetArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void GetCircleAreaZeroParam()
        {
            double firstSide = 0;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var area = triangle.GetArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void IsRightTrianglePosParams()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }

        [Fact]
        public void IsRightTriangleNegParams()
        {
            double firstSide = 3;
            double secondSide = -9;
            double thirdSide = 3;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }

        [Fact]
        public void IsRightTriangleZeroParams()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 0;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.False(result);
        }

        [Fact]
        public void IsRightTriangleGoodParams()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 4;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.IsRightTriangle();

            Assert.True(result);
        }

        [Fact]
        public void IsRightTriangleBadParams()
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
