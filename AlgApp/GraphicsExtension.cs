using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgApp
{
    public class GraphicsExtension
    {
        internal Point ClickedPoint { get; set; }
        private Control.ControlCollection Controls;
        public List<CDot> cDots = new List<CDot>();
        public List<MSTNode> visitedPoints = new List<MSTNode>();
        public int CanvasX = 10;
        public int CanvasY = 10;
        public int y_axis1 = 20;
        public int y_axis2 = 420;
        public int x_axis1 = 35;
        public int x_axis2 = 770;
        public List<int> x_axe_points = new List<int>();
        public List<int> y_axe_points = new List<int>();

        public GraphicsExtension(Control.ControlCollection controls) 
        {
            Controls = controls;
            FillOutAxePoints();
        }

        public void PaintCanvas(PaintEventArgs pea)
        {
            // draw backgroung
            Pen pen = new Pen(Color.Black, 2.5F);
            pea.Graphics.DrawLine(pen, new Point(x_axis1, y_axis1), new Point(x_axis1, y_axis2));
            pea.Graphics.DrawLine(pen, new Point(x_axis1, y_axis2), new Point(x_axis2, y_axis2));

            if (visitedPoints.Count > 0)
            {
                foreach (var line in visitedPoints)
                {
                    int i = line.id;
                    int j = line.start;
                    Point p1 = cDots[i].Location;
                    Point p2 = cDots[j].Location;
                    pea.Graphics.DrawLine(pen, new Point(p1.X + 3, p1.Y + 4), new Point(p2.X + 3, p2.Y + 4));
                }
            }

            if (cDots.Count > 0)
            {
                foreach (CDot c in cDots)
                {
                    pea.Graphics.FillEllipse(new SolidBrush(Color.Red), c.Location.X, c.Location.Y, 10.0F, 10.0F);
                    pea.Graphics.DrawString(c.TextObject.Text, c.TextObject.Font, c.TextObject.Brush, c.TextObject.Point);
                }             
            }
        }

        public void CreateNewDot(Point loc)
        {
            var x = NormalizeNumber(loc.X, x_axis1, x_axis2, CanvasX, true);
            var y = NormalizeNumber(loc.Y, y_axis1, y_axis2, CanvasY, false);
            Point normalizedPoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));

            var b = cDots.FirstOrDefault<CDot>(c => c.Normalized.Equals(normalizedPoint));
            if (b == null)
            {
                Point p = GetPoint(loc.X, loc.Y);
                TextObject to = new TextObject($"({x},{y})", new Font("Arial", 8), new Point(p.X - 15, p.Y + 12));
                CDot cd = new CDot(to, p, normalizedPoint);

                cDots.Add(cd);
            }
            else
            {
                MessageBox.Show("ima tacke");
            }
        }

        private decimal NormalizeNumber(int number, int min, int max, int limit, bool revertOrder)
        {
            decimal d = ((number - min) / Convert.ToDecimal(max - min)) * limit;
            if (revertOrder)
            {
                return Decimal.Round(d, 0);
            }
            else
            {
                return limit - Decimal.Round(d, 0);
            }
        }


        private void FillOutAxePoints()
        {
            int x_inc = (x_axis2 - x_axis1) / CanvasX;
            for (int i = x_axis1; i <= x_axis2; i += x_inc) 
            {
                x_axe_points.Add(i);
            }

            int y_inc = (y_axis2 - y_axis1) / CanvasY;
            for (int j = y_axis1; j <= y_axis2; j += y_inc)
            {
                y_axe_points.Add(j);
            }
        }

        private Point GetPoint(int x, int y)
        {
            int closest_x = x_axe_points.OrderBy(v => Math.Abs(v - x)).FirstOrDefault();
            int closest_y = y_axe_points.OrderBy(v => Math.Abs(v - y)).FirstOrDefault();
            return new Point(closest_x, closest_y);
        }
    }
}
