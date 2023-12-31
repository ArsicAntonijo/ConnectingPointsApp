﻿using Microsoft.VisualBasic.Logging;
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
        private Control.ControlCollection Controls;
        public List<CDot> cDots = new List<CDot>();
        public List<Node> visitedPoints = new List<Node>();
        public List<Point> pointsForLines = new List<Point>();
        public int CanvasX = 10;
        public int CanvasY = 10;
        public int y_axis1 = 110;
        public int y_axis2 = 510;
        public int x_axis1 = 100;
        public int x_axis2 = 840;
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
            pea.Graphics.DrawLine(pen, new Point(x_axis1, y_axis1), new Point(x_axis1 - 4, y_axis1 + 4));
            pea.Graphics.DrawLine(pen, new Point(x_axis1, y_axis1), new Point(x_axis1 + 4, y_axis1 + 4));
            pea.Graphics.DrawLine(pen, new Point(x_axis1, y_axis2), new Point(x_axis2, y_axis2));
            pea.Graphics.DrawLine(pen, new Point(x_axis2, y_axis2), new Point(x_axis2 - 4, y_axis2 + 4));
            pea.Graphics.DrawLine(pen, new Point(x_axis2, y_axis2), new Point(x_axis2 - 4, y_axis2 - 4));
            pea.Graphics.DrawString(CanvasX.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), new Point(x_axis1 - 30, y_axis1));
            pea.Graphics.DrawString(CanvasY.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), new Point(x_axis2 - 25, y_axis2 + 10));
            pea.Graphics.DrawString("0", new Font("Arial", 10), new SolidBrush(Color.Black), new Point(x_axis1 - 15, y_axis2 + 8));

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

            if (pointsForLines.Count > 0)
            {
                for (int i = 0; i < pointsForLines.Count - 1; i++) 
                {
                    Point p1 = pointsForLines[i];
                    Point p2 = pointsForLines[i + 1];
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
                MessageBox.Show("On chosen position point already exists.");
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

        public bool CheckPoint(Point location)
        {
            if (location.X > x_axis1 && location.X < x_axis2) 
            {
                if (location.Y > y_axis1 && location.Y < y_axis2) return true;
                else return false;
            } 
            else return false;
        }

        public void RemovePoint(Point location)
        {
            var x = NormalizeNumber(location.X, x_axis1, x_axis2, CanvasX, true);
            var y = NormalizeNumber(location.Y, y_axis1, y_axis2, CanvasY, false);
            Point normalizedPoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));

            var b = cDots.FirstOrDefault<CDot>(c => c.Normalized.Equals(normalizedPoint));
            if (b != null)
            {
                cDots.Remove(b);
                visitedPoints.Clear();
                pointsForLines.Clear();
            }
        }
    }
}
