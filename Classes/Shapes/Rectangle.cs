using System.Drawing;
using System.Windows.Forms;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Shapes
{
    internal class Rectangle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        
        public Rectangle(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
        }

        public void Draw(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawRectangle(Pens.Red, new System.Drawing.Rectangle(X, Y, W, H));
        }

    }

}
