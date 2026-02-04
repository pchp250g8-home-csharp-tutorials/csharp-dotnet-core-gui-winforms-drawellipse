namespace DrawEllipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rcPaint = new Rectangle(0,0, ClientSize.Width, ClientSize.Height);
            Pen oRedPen = new Pen(Color.Red, 5);
            g.Clear(Color.Black);
            g.DrawEllipse(oRedPen,rcPaint);
            g.FillEllipse(Brushes.Yellow, rcPaint);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
