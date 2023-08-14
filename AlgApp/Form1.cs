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
            if (e.Button == MouseButtons.Left)
            {
                ge.CreateNewDot(e.Location);
                //ge.ClickedPoint = e.Location;
                this.Invalidate();
                //this.Refresh();
            }
        }

        private void labelY_Click(object sender, EventArgs e)
        {

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            int res = MinCostConnections.MinCost(ge.cDots, out ge.visitedPoints);
            MessageBox.Show("" + res);
            //this.Refresh();
            this.Invalidate();

            //int res = MinStraightLines.MinimumLines(ge.cDots);
            //MessageBox.Show("" + res);
        }
    }
}