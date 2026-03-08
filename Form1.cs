using System.Diagnostics;

namespace CS_Week01_25017050_MyBusinessCard
{
    public partial class Form1 : Form
    {
        Image img1;
        Image img2;
        bool toggle = false;

        public Form1()
        {
            InitializeComponent();

            img1 = Image.FromFile("wjdwkd1.png");
            img2 = Image.FromFile("wjdwkd2.jpg");

            pictureBox1.Image = img1;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (toggle)
                pictureBox1.Image = img1;
            else
                pictureBox1.Image = img2;

            toggle = !toggle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/cks0612",
                UseShellExecute = true
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
