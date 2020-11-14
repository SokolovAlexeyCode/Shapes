using System.Collections.Generic;
using TopSystemsOOPExample.Classes.Shapes;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Factories
{
    class DefaultShapesFactory : IShapesFactory
    {
        public IList<IShape> GetShapes()
        {
            return new List<IShape>
            {
                new Circle(100, 100, 70),
                new Rectangle(400, 200, 80, 120),
                new Triangle(200, 150, 300, 270, 110, 220)
            };
        }
    }
}
