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
            g.Clear(Color.Black);
            g.DrawEllipse(Pens.Yellow, 0, 0, ClientSize.Width, ClientSize.Height);
            g.FillEllipse(Brushes.Red, 0, 0, ClientSize.Width, ClientSize.Height);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
