using System;
using System.Windows.Forms;
using TopSystemsOOPExample.Classes.Singleton;

namespace TopSystemsOOPExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            var shapes = Singleton.GetSingleton().ShapesFactory.GetShapes();
            foreach (var shapeE in shapes)
                shapeE.Draw(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawPanel.Refresh();
        }
    }
}
