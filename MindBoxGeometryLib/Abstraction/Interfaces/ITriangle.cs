using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxGeometryLib.Abstraction.Interfaces {
    internal interface ITriangle : IShape {
        public bool CheckIfRight();
    }
}
