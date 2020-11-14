using System;
using System.Collections.Generic;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Factories
{
    class ShapesFromLinesFactory : IShapesFactory
    {
        public IList<IShape> GetShapes()
        {
            throw new NotImplementedException();
        }
    }
}
