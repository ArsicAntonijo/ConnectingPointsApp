namespace AlgApp
{
    public partial class Form1 : Form
    {
        PointF clickedPoint;
        GraphicsExtension ge;

        public Form1()
        {
            InitializeComponent();
            ge = new GraphicsExtension(Controls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            ge.PaintCanvas(pea);
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ge.CheckPoint(e.Location))
            {
                ge.CreateNewDot(e.Location);
                //ge.ClickedPoint = e.Location;
                this.Invalidate();
                //this.Refresh();
            } 
            else if(e.Button == MouseButtons.Right && ge.CheckPoint(e.Location))
            {
                ge.RemovePoint(e.Location);
                this.Invalidate();
            }
        }

        private void labelY_Click(object sender, EventArgs e)
        {

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findMinCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ge.visitedPoints.Clear();
            ge.pointsForLines.Clear();
            int res = MinCostConnections.MinCost(ge.cDots, out ge.visitedPoints);
            this.Invalidate();
            resultTextBox.Text = $"The cost is: {res}";
        }

        private void findMinLineNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ge.visitedPoints.Clear();
            int res = MinStraightLines.MinimumLines(ge.cDots, out ge.pointsForLines);
            this.Invalidate();
            resultTextBox.Text = $"The number of line is: {res}";
        }

        private void removeAllPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ge.cDots.Clear();
            ge.visitedPoints.Clear();
            ge.pointsForLines.Clear();
            resultTextBox.Clear();
            this.Invalidate();
        }
    }
}