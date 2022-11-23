using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListOfElementNames
{
    public partial class Form1 : Form
    {
        Point selPoint;
        Rectangle mRect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = e.Location;
                int x = Math.Min(selPoint.X, p.X);
                int y = Math.Min(selPoint.Y, p.Y);
                int w = Math.Abs(p.X - selPoint.X);
                int h = Math.Abs(p.Y - selPoint.Y);
                mRect = new Rectangle(x, y, w, h);
                this.Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            selPoint = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            int y = location.Y;
      
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Gray, mRect);
        }
    }
}
