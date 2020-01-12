using FluentAssertions;
using NUnit.Framework;
using TestProject;

namespace UnitTests
{
    [TestFixture]
    public class TriangleFixture
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(3, 4, 2, 2.9047375096555625)]
        public void WhenICalculateAreaIGetRightValue(double a, double b, double c, double expectedArea)
        {
            var sut = new Triangle(a, b, c);

            sut.GetArea().Should().Be(expectedArea);
        }

        [Test]
        public void WhenTriangleIsRightThePropertyShouldReturnTrue()
        {
            var sut = new Triangle(3, 4, 5);

            sut.IsRight.Should().BeTrue();
        }

        [Test]
        public void WhenTriangleIsNotRightThePropertyShouldReturnFalse()
        {
            var sut = new Triangle(3, 4, 2);

            sut.IsRight.Should().BeFalse();
        }
    }
}