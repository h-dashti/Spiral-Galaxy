using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Galaxy__Windows_
{
    public partial class FormGalaxy : Form
    {
        #region  Fields
        Galaxy galaxy;
        double t; 
        double scaleR = 7.2;
        int rectSize = 8;
        const int minTimerInterval = 5, maxTimerInterval = 500;
        
        Bitmap bitMap;
        #endregion



        #region Methods
        void InitToolTip()
        {
            toolTip1.SetToolTip(labelATime, "The long time of shining for activated cell.");
            toolTip1.SetToolTip(labelp, "Star formation probability.");
            toolTip1.SetToolTip(labeldt, "The  time step. (scale 10  is corresponded to 10^7 years)");
            toolTip1.SetToolTip(labelv, "The cicular velocity of ecah cell. (scale 1 is corresponde to 200km/s)");
            toolTip1.SetToolTip(labelnRings, "The number of rings. ");
            toolTip1.SetToolTip(labelnINitActive, "The initial number of active cells. ");
            toolTip1.SetToolTip(textBoxTime, "Elapesd Time. (scale 1  is corresponded to 10^6 years)");
            toolTip1.SetToolTip(textBoxActiveCells, "The Numebr of current active cells.");
  
        }

        void Reset()
        {
            CalculateTimerInterval();

            t = 0;
            InitGalaxyObject();
            GC.Collect();
            textBoxTime.Text = t.ToString("f2");
            textBoxActiveCells.Text = galaxy.nActive.ToString();

            //SetPixelInBitMap();
        }

        void SetPixelInBitMap()
        {
            //int sizeBitMap = (int)(2 * galaxy.nRings * scaleR + 20);
            bitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            GC.Collect();
            int xOrigin = bitMap.Width / 2;
            int yOrigin = bitMap.Height / 2;

            int r, a, x, y;
            double theta;
            double maxColor = 200;
            double tempColor = maxColor / galaxy.activationTime;

            for (r = 1; r <= galaxy.nRings; r++)
            {
                for (a = 0; a < r * galaxy.numCells0; a++)
                {
                    if (galaxy.cell[r][a] > 0)
                    {
                        theta = (a * galaxy.s + galaxy.v * t) / r;
                        x = (int)(r * Math.Cos(theta) * scaleR + xOrigin);
                        y = (int)(r * Math.Sin(theta) * scaleR + yOrigin);

                        if (x >= 0 && y >= 0 && x <= bitMap.Width && y <= bitMap.Height)
                        {
                            int temp = 0;//(int)(-tempColor * galaxy.cell[r][a] + maxColor);
                            Color color = Color.FromArgb(255 - temp / 50, temp, temp, temp);
                            bitMap.SetPixel(x, y, color);
                        }

                    }
                }
            }

        }

        void CalculateTimerInterval()
        {
            double a = (-minTimerInterval + maxTimerInterval) / (-trackBar1.Maximum + trackBar1.Minimum);
            double b = (-minTimerInterval * trackBar1.Minimum + maxTimerInterval * trackBar1.Maximum) / (trackBar1.Maximum - trackBar1.Minimum);

            timer1.Interval = (int)(a * trackBar1.Value + b);
        }

      
        void Next()
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                t += galaxy.dt;
                textBoxTime.Text = t.ToString("f2");
                textBoxActiveCells.Text = galaxy.nActive.ToString();
                galaxy.Evolve(t);
                if (galaxy.isFinished)
                {
                    if (timer1.Enabled)
                        timer1.Stop();
                    MessageBox.Show("There is no cell shining.");
                    return;
                }
            }
        }

        void DefaultData()
        {
            textBoxp.Text = "0.18";
            textBoxdt.Text = "10";
            textBoxv.Text = "1";
            textBoxNumRings.Text = "50";
            textBoxNInitActive.Text = "20";
            textBoxActivationTime.Text = "15";
        }
        void InitGalaxyObject()
        {
            int nRings = int.Parse(textBoxNumRings.Text);
            int nActive = int.Parse(textBoxNInitActive.Text);
            byte activationTime = byte.Parse(textBoxActivationTime.Text);
            double v = double.Parse(textBoxv.Text);
            double p = double.Parse(textBoxp.Text);
            double dt = double.Parse(textBoxdt.Text);
            galaxy = new Galaxy(nRings, nActive, activationTime, v, p, dt);
        }

        #endregion




        public FormGalaxy()
        {
            InitializeComponent();
            InitToolTip();
            DefaultData();
            Reset();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            Next();
            SetPixelInBitMap();
            pictureBox1.Invalidate();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Next();
            SetPixelInBitMap();

            pictureBox1.Invalidate();
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //g.DrawImage(bitMap, 0, 0);
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

          
            int rElipse = (int)(galaxy.nRings * scaleR);
            g.DrawEllipse(new Pen(Color.Blue), -rElipse, -rElipse, 2 * rElipse, 2 * rElipse);

            int r, a;
            double x, y, theta;
            double maxColor = 200;
            double tempColor = maxColor / galaxy.activationTime;

            for (r = 1; r <= galaxy.nRings; r++)
            {
                for (a = 0; a < r * galaxy.numCells0; a++)
                {
                    if (galaxy.cell[r][a] > 0)
                    {
                        theta = (a * galaxy.s + galaxy.v * t) / r;
                        x = r * Math.Cos(theta) * scaleR;
                        y = r * Math.Sin(theta) * scaleR;

                        int temp = (int)(-tempColor * galaxy.cell[r][a] + maxColor);
                        Color color = Color.FromArgb(255 - temp / 50, temp, temp, temp);
                        Rectangle rect = new Rectangle((int)x - rectSize / 2, (int)y - rectSize / 2, rectSize, rectSize);
                        g.FillEllipse(new SolidBrush(color), rect);

                    }
                }
            }
        }

        private void FormGalaxy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1 != null)
            {
                timer1.Stop();
                timer1.Dispose();
            }
        }

       
        private void buttonAuto_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
                timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CalculateTimerInterval();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Designed by Hor Dashti (h.dashti2@gmail.com)";
            MessageBox.Show(text, "About");
        }
    }
}