namespace uçantopoyunuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yerX = 8, yerY = 8, can = 3;

        private void CarpmaOlayı()

        {
            //label2 için çarpma
            if (ball.Top <= label2.Bottom)
                yerY = yerY * -1;

            //kontrole carpma olayı
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
                yerY = yerY * -1;
            //sag kenara carpma olayı
            else if (ball.Right >= label4.Left)
                yerX = yerX * -1;
            //sol kenara carpma olayı 
            else if (ball.Left <= label1.Right)
                yerX = yerX * -1;
        }

        private void YanmaOlayı(object sender, EventArgs e)
        {
            if (ball.Top >= label4.Bottom)

            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız Kalan Can >=" + can.ToString());
                    Form1_Load(sender, e);
                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti", "", MessageBoxButtons.OK);
                }
            }
            label3.Text = can.ToString();
        }
        private void Topbasa()
        {
            ball.Location = new Point(252, 156);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kontrol_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Topbasa();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarpmaOlayı();
            YanmaOlayı(sender, e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}