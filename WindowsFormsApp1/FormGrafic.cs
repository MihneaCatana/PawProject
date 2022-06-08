using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FormGrafic : Form
    {
        int nrobs ;
        float[] y;
        string[] x;
        public FormGrafic(ListView LVM)
        {

            InitializeComponent();
            nrobs = LVM.Items.Count;
            y = new float[nrobs];
            x = new string[nrobs];  
            for (int p = 0; p < nrobs; p++)
               y[p] = 0.0f;

            int i = 0;
            foreach(ListViewItem lv in LVM.Items)
            {
                y[i] = ((Materiale)lv.Tag).PretBucata;
                x[i] = ((Materiale)lv.Tag).DenumireMaterial;
                i++;
            }
            
            this.ResizeRedraw = true;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //acces la contextul grafic 
            Graphics g = e.Graphics;
            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);

            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20;
            zonaClient.Y += 20;
            zonaClient.Height -= 40;
            zonaClient.Width -= 40;

            int vl = zonaClient.Left;
            int vr = zonaClient.Right;
            int vt = zonaClient.Top;
            int vb = zonaClient.Bottom;

            Pen CreionRosu = new Pen(Color.Red);
            g.DrawRectangle(CreionRosu, zonaClient);

            int lat, dist;
            string denx = "";
            float rap_dist_lat = 0.2f, max;

            SolidBrush[] pensule = new SolidBrush[] {
            new SolidBrush(Color.Blue),
            new SolidBrush(Color.IndianRed),
            new SolidBrush(Color.Yellow),
            new SolidBrush(Color.Green),
            new SolidBrush(Color.PowderBlue),
            new SolidBrush(Color.GreenYellow)
        };

            Pen[] creioane = new Pen[] { new Pen(Color.Blue),
            new Pen(Color.IndianRed),
            new Pen(Color.Yellow),
            new Pen(Color.Green),
            new Pen(Color.PowderBlue),
            new Pen(Color.GreenYellow)};

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);

            dist = (int)(lat * rap_dist_lat);

            max = y[0];
            for (int i = 1; i < nrobs; i++)
                if (max < y[i])
                    max = y[i];

            creionCurent = creioane[0];
            pensulaCurenta = pensule[0];

            g.DrawLine(creionCurent, vl, vt, vl, vb);
            g.DrawLine(creionCurent, vl, vb, vr, vb);

            for (int i = 0; i < nrobs; i++)
            {
                pensulaCurenta = pensule[i % pensule.Length];
                PointF pnt = new PointF(
                    vl + i * (lat + dist) + rap_dist_lat + dist,
                    vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

                denx = "" + x[i];
                g.DrawString(denx, Font, pensulaCurenta,
                    vl + dist + lat / 2 + i * (lat + dist), vb + 5);
            }
       
        }
    }
}
