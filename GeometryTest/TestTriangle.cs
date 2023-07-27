using Xunit;
using MindBoxGeometryLib.Implementations.Shapes;

namespace GeometryTest {
    public class TestTriangle {
        [Fact]
        public void TriangleException() {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 200));
        }
        [Fact]
        public void TriangleAreaEquals58dot8() {
            Assert.Equal(58.8, Math.Round(new Triangle(12, 10, 14).Area,1));
        }
        [Fact]
        public void TrianglePerimeterEquals30() {
            Assert.Equal(30, new Triangle(10, 10, 10).Perimeter);
        }
        [Fact]
        public void TriangleIsRight() {
            Assert.True(new Triangle(3, 4, 5).CheckIfRight());
        }
        [Fact]
        public void TriangleNotRight() {
            Assert.False(new Triangle(10, 10, 10).CheckIfRight());
        }
    }
}