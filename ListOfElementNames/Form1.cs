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
        private Point rectPoint;
        private Rectangle myRect;
        private List<Control> list = new List<Control>();
        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = e.Location;
                int x = Math.Min(rectPoint.X, p.X);
                int y = Math.Min(rectPoint.Y, p.Y);
                int w = Math.Abs(p.X - rectPoint.X);
                int h = Math.Abs(p.Y - rectPoint.Y);
                myRect = new Rectangle(x, y, w, h);
                this.Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rectPoint = e.Location;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Gray, myRect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllControl(this, list);
        }
        private string ListOfElements()
        {
            string _tmp = "";
            for (int i = 0; i < list.Count; i++)
            {
                _tmp += list[i].Name + "\n";
            }
            return _tmp;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show(ListOfElements());
        }
    }
}
