using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectors1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a Graphics object to draw on the form
        Graphics g = e.Graphics;

        // Create a Pen and a Brush for drawing
        Pen pen = new Pen(Color.Blue, 2);
        Brush brush = new SolidBrush(Color.Red);

        // Draw a rectangle
        Rectangle rect = new Rectangle(50, 50, 100, 100);
        g.DrawRectangle(pen, rect);
        g.FillRectangle(brush, rect);

        // Dispose of the Pen and Brush
        pen.Dispose();
        brush.Dispose();
    }
}
