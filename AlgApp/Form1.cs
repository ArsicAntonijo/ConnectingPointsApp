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
                //this.Invalidate();
                this.Refresh();
            }
        }

        private void labelY_Click(object sender, EventArgs e)
        {

        }
    }
}