using System.Drawing;
using System.Windows.Forms;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Shapes
{
    internal class Triangle : IShape
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public int X3 { get; set; }
        public int Y3 { get; set; }



        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        


        public void Draw(PaintEventArgs e)
        {
            var point1 = new Point(X1, Y1);
            var point2 = new Point(X2, Y2);
            var point3 = new Point(X3, Y3);

            var points = new []
            {
                point1,
                point2,
                point3
            };

            e.Graphics.DrawPolygon(Pens.Red, points);
            
        }
    }
}
