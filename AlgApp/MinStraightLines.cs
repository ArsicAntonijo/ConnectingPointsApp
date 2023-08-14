using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgApp
{
    public class MinStraightLines
    {
        // Function to find minimum number of lines
        public static int MinimumLines(List<CDot> arr, out List<Point> points)
        {
            int n = arr.Count;
            // object where we store point for lines to be drawn
            points = new List<Point>();


            // Base case when there is only one point,
            // then min lines = 0
            if (n == 1)
                return 0;

            // Sorting in ascending order of X coordinate
            // Array.Sort<int[]>(arr, new Comparer());
            arr.Sort((x, y) => x.Normalized.X.CompareTo(y.Normalized.X));
            
            // adding starting point
            points.Add(arr[0].Location);
            int numoflines = 1;

            // Traverse through points and check
            // whether the slopes matches or not.
            // If they does not match
            // increment the count of lines            
            for (int i = 2; i < n; i++)
            {
                int x1 = arr[i].Normalized.X;
                int x2 = arr[i - 1].Normalized.X;
                int x3 = arr[i - 2].Normalized.X;
                int y1 = arr[i].Normalized.Y;
                int y2 = arr[i - 1].Normalized.Y;
                int y3 = arr[i - 2].Normalized.Y;
                int slope1 = (y3 - y2) * (x2 - x1);
                int slope2 = (y2 - y1) * (x3 - x2);

                if (slope1 != slope2)
                {
                    points.Add(arr[i - 1].Location);
                    numoflines++;
                }
                    
            }

            // add last point to be drawn
            points.Add(arr[arr.Count - 1].Location);

            // Return the num of lines
            return numoflines;
        }
    }

    // Comparer class implementation
    class Comparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0].CompareTo(y[0]);
        }
    }
}
