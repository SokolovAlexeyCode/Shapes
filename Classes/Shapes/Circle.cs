using System.Drawing;
using System.Windows.Forms;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Shapes
{
    internal class Circle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int r { get; set; }


        public Circle(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.r = r;
        }


        public void Draw(PaintEventArgs e)
        {
            var rect = new System.Drawing.Rectangle(X, Y, r * 2, r * 2);
            e.Graphics.DrawEllipse(Pens.Red, rect);
        }

    }
}
