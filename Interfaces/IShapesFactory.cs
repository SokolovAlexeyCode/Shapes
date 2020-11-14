using System.Collections.Generic;

namespace TopSystemsOOPExample.Interfaces
{
    interface IShapesFactory
    {
        IList<IShape> GetShapes();
    }
}
