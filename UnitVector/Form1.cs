using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitVector
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Pen p;
        List<Vector> vectorList = new List<Vector>();
        Vector currentVector = new Vector();
        Circle currentCircle = new Circle();

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pbGraph.Width, pbGraph.Height);
            p = new Pen(Color.Black);
            pbGraph.Refresh();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Base(g);

            g.DrawLine(p, new Point(250, 250), new Point((currentVector.x + 25) * 10, (-(currentVector.y) + 25) * 10));
            g.DrawEllipse(p, new RectangleF(new PointF(250-(currentCircle.width/2)*10,250-(currentCircle.height/2)*10), new SizeF(currentCircle.width*10, currentCircle.height*10)));

            foreach (var vector in vectorList)
            {
                g.DrawLine(p, new Point(250, 250), new Point(vector.x, vector.y));
            }
        }

        private void Base(Graphics g)
        {
            g.DrawLine(p, new Point(0, 250), new Point(500, 250));
            g.DrawLine(p, new Point(250, 0), new Point(250, 500));
        }

        private void refreshVector(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);

                currentVector.x = a;
                currentVector.y = b;
                
                double i = Math.Pow(currentVector.x, 2) + (Math.Pow(currentVector.y, 2));
                double j = Math.Pow(currentVector.x, 2) + (Math.Pow(currentVector.y, 2));

                double[] unitMagX = { currentVector.x, i };
                double[] unitMagY = { currentVector.y, j };

                lblMag.Text = "\u221A" + (Math.Pow(currentVector.x, 2) + (Math.Pow(currentVector.y, 2)));
                lblUnitVecMag.Text = "X: " + unitMagX[0] + " / \u221A" + unitMagX[1] + "   Y: " + unitMagY[0] + " / \u221A" + unitMagY[1];
                // lblAngle.Text = ""+Math.Atan2(currentVector.x, currentVector.y);

                Refresh();
            }
            catch (Exception)
            {
                lblMag.Text = "N/A";
                lblUnitVecMag.Text = "N/A";
            }
        }

        private void MakeCircle(object sender, EventArgs e)
        {
            try
            {
                currentCircle.width = float.Parse(tbCirc.Text);
                currentCircle.height = float.Parse(tbCirc.Text);

                Refresh();
            }
            catch (Exception)
            {
            }
            
        }
    }
}
