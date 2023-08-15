using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgApp
{
    public class MinCostConnections
    {
        public static int MinCost(List<CDot> points, out List<Node> visited)
        {
            int n = points.Count;
            Node[,] mst = CreateNodes(points, n);

            //Prim
            int res = 0;
            visited = new List<Node>();
            var PQ = new PriorityQueue<Node, int>();
            PQ.Enqueue(new Node(0, 0, 0), 0);

            while (visited.Count < n)
            {
                Node temp = PQ.Dequeue();
                if (visited.Where(v => v.id == temp.id).FirstOrDefault() != null) continue;

                res += temp.cost;
                visited.Add(temp);
                for (int i = 0; i < n; i++)
                {
                    var neighbor = mst[temp.id, i];
                    if (neighbor != null && visited.Where(v => v.id == neighbor.id).FirstOrDefault() == null)
                    {
                        PQ.Enqueue(neighbor, neighbor.cost);
                    }
                }
            }
            return res;
        }


        private static Node[,] CreateNodes(List<CDot> points, int n)
        {
            Node[,] mst = new Node[n, n];
            for (int i = 0; i < n; i++)
            {
                //int[] x = points[i];
                Point x = points[i].Normalized;
                for (int j = i + 1; j < n; j++)
                {
                    //int[] y = points[j];
                    Point y = points[j].Normalized;
                    int cost = Distance(x, y);
                    mst[i, j] = new Node(j, cost, i);
                    mst[j, i] = new Node(i, cost, j);
                }
            }
            return mst;
        }

        private static int Distance(Point p1, Point p2)
        {
            return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y);
        }
    }

    public class Node
    {
        public int id;
        public int start;
        public int cost;

        public Node(int i, int c, int s) { id = i; cost = c; start = s; }
    }
}
