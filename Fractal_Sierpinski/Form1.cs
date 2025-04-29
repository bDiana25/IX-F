using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Sierpinski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerare_Click(object sender, EventArgs e)
        {
            float lățime = pictureBox1.Width;
            float înălțime= pictureBox1.Height;
            PointF A = new PointF(lățime / 2, 10);
            PointF B = new PointF(10, înălțime - 10);
            PointF C = new PointF(lățime - 10, înălțime - 10);
            PointF punctcurent = new PointF(lățime / 2, înălțime / 2);
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.Black);
            pictureBox1.Image = canvas;
            Random rand = new Random();
            for(int i=1;i<50000;i++)
            {
                PointF vârf;
                int r=rand.Next(3);
                if (r == 0)
                    vârf = A;
                else
                    if(r==1) vârf=B;
                    else vârf= C;
                punctcurent = new PointF((punctcurent.X + vârf.X) / 2, (punctcurent.Y + vârf.Y) / 2);
                canvas.SetPixel((int)punctcurent.X, (int)punctcurent.Y, Color.Blue);


            }
            pictureBox1.Refresh();
        }
    }
}
