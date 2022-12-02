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
        private List<Control> textBox = new List<Control>();
        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);
            }
        }
        private void GetAllTextBox(Control tb, List<Control> textBox)
        {
            foreach (Control _textBox in tb.Controls)
            {
                if (_textBox is TextBox)
                {
                    textBox.Add(_textBox);
                }
                
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
            GetAllTextBox(this, textBox);
        }
        private string ListOfElements()
        {
            string _tmp = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (myRect.Contains(list[i].Location))
                {
                    _tmp += list[i].Name + "\n";
                }
            }
            return _tmp;
        }

        private void fromTextBoxToClipboard()
        {
            string _tmp = "";
            for (int i = 0; i < textBox.Count; i++)
            {
                if (myRect.Contains(textBox[i].Location))
                {
                    _tmp += textBox[i].Text + "\n";
                }
            }
            Clipboard.SetText(_tmp);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show(ListOfElements());
            fromTextBoxToClipboard();
        
        }
        
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = textBox1.Text + Clipboard.GetText();
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = textBox2.Text + Clipboard.GetText();
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = textBox3.Text + Clipboard.GetText();
        }

        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = textBox4.Text + Clipboard.GetText();
        }

        private void textBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = textBox5.Text + Clipboard.GetText();
        }
    }
}
