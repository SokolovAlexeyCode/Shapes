using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using TopSystemsOOPExample.Classes.Shapes;
using TopSystemsOOPExample.Classes.TechnicalDetails;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Factories
{
    public class ShapesFromXmlFactory : IShapesFactory
    {
        public IList<IShape> GetShapes()
        {
            var settPath = ConfigurationManager.AppSettings["xmlshapesettingpath"];
            var serializer = new XmlSerializer(typeof(ShapesFromXml.Shapes));
      
            ShapesFromXml.Shapes shapes;
            using (Stream reader = new FileStream(settPath, FileMode.Open))
            {
                try
                {
                    shapes = (ShapesFromXml.Shapes)serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Bad xml data file", e);
                }
            }

            var result = new List<IShape>();

            result.AddRange(shapes.Circles.Select(GetCircle).ToList());
            result.AddRange(shapes.Triangles.Select(GetTriangle).ToList());
            result.AddRange(shapes.Rectangle.Select(GetRectangle).ToList());

       return result;
        }

   
        private static IShape GetCircle(ShapesFromXml.Circle circle)
        {
            return new Circle(circle.X, circle.Y, circle.R);
        }

        private static IShape GetRectangle(ShapesFromXml.Rectangle rectangle)
        {
            return new Rectangle(rectangle.X, rectangle.Y, rectangle.W, rectangle.H);
        }

        private static IShape GetTriangle(ShapesFromXml.Triangle triangle)
        {
            return new Triangle(triangle.X1, triangle.Y1, triangle.X2, triangle.Y2, triangle.X3, triangle.Y3);
        }
    }
}
