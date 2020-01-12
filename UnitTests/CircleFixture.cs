using FluentAssertions;
using NUnit.Framework;
using TestProject;

namespace UnitTests
{
    [TestFixture]
    public class CircleFixture
    {
        [TestCase(0, 0)]
        [TestCase(1, 3.1415926535897931)]
        [TestCase(3, 28.274333882308138)]
        public void WhenICalculateAreaIGetRightValue(double radius, double expectedArea)
        {
            var sut = new Circle(radius);

            sut.GetArea().Should().Be(expectedArea);
        }
    }
}
