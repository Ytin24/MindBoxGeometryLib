using MindBoxGeometryLib.Implementations.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeometryTest {
    public class CircleTest {
        [Fact]
        public void CircleDiameterEquals20() {
            Assert.Equal(20, new Circle(10).Diameter);
        }
        [Fact]
        public void CircleAreaEquals314dot15() {
            Assert.Equal(314.159, new Circle(10).Area, 3);
        }
        [Fact]
        public void CirclePerimeterEquals62dot83() {
            Assert.Equal(62.83, new Circle(10).Perimeter, 2);
        }
    }
    
}
