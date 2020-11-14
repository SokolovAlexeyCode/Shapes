using System.Collections.Generic;
using System.Xml.Serialization;

namespace TopSystemsOOPExample.Classes.TechnicalDetails
{
    public class ShapesFromXml
    {

    
        [XmlRoot(ElementName = "Circle")]
        public class Circle
        {
            [XmlAttribute(AttributeName = "x")]
            public int X { get; set; }
            [XmlAttribute(AttributeName = "y")]
            public int Y { get; set; }
            [XmlAttribute(AttributeName = "r")]
            public int R { get; set; }
        }

        [XmlRoot(ElementName = "Triangle")]
        public class Triangle
        {
            [XmlAttribute(AttributeName = "x1")]
            public int X1 { get; set; }
            [XmlAttribute(AttributeName = "y1")]
            public int Y1 { get; set; }
            [XmlAttribute(AttributeName = "x2")]
            public int X2 { get; set; }
            [XmlAttribute(AttributeName = "y2")]
            public int Y2 { get; set; }
            [XmlAttribute(AttributeName = "x3")]
            public int X3 { get; set; }
            [XmlAttribute(AttributeName = "y3")]
            public int Y3 { get; set; }
        }

        [XmlRoot(ElementName = "Rectangle")]
        public class Rectangle
        {
            [XmlAttribute(AttributeName = "x")]
            public int X { get; set; }
            [XmlAttribute(AttributeName = "y")]
            public int Y { get; set; }
            [XmlAttribute(AttributeName = "h")]
            public int H { get; set; }
            [XmlAttribute(AttributeName = "w")]
            public int W { get; set; }
        }

        [XmlRoot(ElementName = "Shapes")]
        public class Shapes
        {
            [XmlElement(ElementName = "Circle")] public List<Circle> Circles { get; set; }
            [XmlElement(ElementName = "Triangle")] public List<Triangle> Triangles { get; set; }

            [XmlElement(ElementName = "Rectangle")]
            public List<Rectangle> Rectangle { get; set; }
        }


    }
}
