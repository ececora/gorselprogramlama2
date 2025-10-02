using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUTONHAREKETİ
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastButtonLocation;

        public Form1()
        {
            InitializeComponent();

            button1.MouseDown += button1_MouseDown;
            button1.MouseMove += button1_MouseMove;
            button1.MouseUp += button1_MouseUp;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastButtonLocation = button1.Location;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(Cursor.Position.X - lastCursor.X, Cursor.Position.Y - lastCursor.Y);
                button1.Location = new Point(lastButtonLocation.X + delta.X, lastButtonLocation.Y + delta.Y);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }

}