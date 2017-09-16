using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollapsingPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GeneratePoints();
            SetLinks();
            GetBounds();

         
            g = panel1.CreateGraphics();
            b = new SolidBrush(Color.Black);
            panel1.Refresh();
            timer = new Timer();
            timer.Interval = 40;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CalculateNextAndMove();
            GetBounds();

            if (boundingBox.Width < eps || boundingBox.Height < eps)
                timer.Stop();

            panel1.Invalidate();
            
        }

        public Timer timer;

        public List<Point> points = new List<Point>();
        public int pointsCount = 50;
        public int startRadius = 1000;
        public float maxDeltaStep = 0.05f;
        public float eps = 0.000000001f;
        public Graphics g;
        public Brush b;

        public RectangleF boundingBox;
        float minX = float.MaxValue,
              minY = float.MaxValue,
              maxX = float.MinValue,
              maxY = float.MinValue;

        public void GeneratePoints()
        {
            PointF coords;
            double angle = 2 * Math.PI / pointsCount;
            for (int i = 0; i < pointsCount; i++)
            {
                coords = new PointF((float)(startRadius * Math.Sin(angle * i)),
                                    (float)(startRadius * Math.Cos(angle * i)));
                points.Add(new Point(coords));
            }
        }

        public void SetLinks()
        {
            Random r = new Random((int)DateTime.Now.Ticks);

            for(int i=0; i < pointsCount; i++)
            {
                var point = points.ElementAt(i);
                while (true) { 
                    int i1 = (r.Next(1, pointsCount) + i) % pointsCount;
                    point.FirstLink = points.ElementAt(i1);

                    int i2 = (r.Next(1, pointsCount) + i) % pointsCount;
                    point.SecondLink = points.ElementAt(i2);

                    if (point.FirstLink == point.SecondLink)
                        continue;
                    else
                        break;
                }                
            }
        }

        public void CalculateNextAndMove()
        {
            foreach (var p in points)   
                p.CalculateNext(maxDeltaStep);

            foreach (var p in points)
                p.Coords = p.NextCoords;
        }

        public void GetBounds()
        {
            minX = float.MaxValue;
            minY = float.MaxValue;
            maxX = float.MinValue;
            maxY = float.MinValue;

            foreach (var point in points)
            {
                minX = Math.Min(point.Coords.X, minX);
                minY = Math.Min(point.Coords.Y, minY);
                maxX = Math.Max(point.Coords.X, maxX);
                maxY = Math.Max(point.Coords.Y, maxY);
            }

            var width  = maxX - minX;
            var height = maxY - minY;
            boundingBox = new RectangleF(minX, maxY, width, height);
            Debug.WriteLine("{0} - {1} - {2} - {3}", minX, minY, maxX, maxY);
            UpdateLabels();
        }

        public void DrawPoints()
        {
            float x, y;

            foreach (var point in points)
            {
                x = LinearSegmentCoordTransform(point.Coords.X, minX, maxX, 0, ClientSize.Width);
                y = ClientSize.Height - LinearSegmentCoordTransform(point.Coords.Y, minY, maxY, 0, ClientSize.Height);
                Debug.WriteLine("({0}|{1})", x, y);
                g.FillRectangle(b, x, y, 2, 2);          
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           DrawPoints();
        }

        public void UpdateLabels()
        {
            lblMaxX.Text = maxX.ToString();
            lblMaxY.Text = maxY.ToString();
            lblMinX.Text = minX.ToString();
            lblMinY.Text = minY.ToString();
        }
        
        private float LinearSegmentCoordTransform( float in_curr, float in_min, float in_max, float out_min, float out_max)
        {
            float alpha = (in_curr - in_min) / (in_max - in_min);

            return out_min + alpha * (out_max - out_min);
        }

    }
}
