using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1,at2,at3;
        Random rastgele = new Random();
        int secim;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           at1 = pictureBox1.Left;
           at2 = pictureBox2.Left;
           at3 = pictureBox3.Left;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(65,142);
            pictureBox2.Location = new Point(65,245);
            pictureBox3.Location = new Point(65,344);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             secim = 1;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
             secim = 3;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
             secim = 2;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int atGenislik1 = pictureBox1.Width;
            int atGenislik2 = pictureBox2.Width;
            int atGenislik3 = pictureBox3.Width;

            int bitis = label1.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(14, 15);

            if(atGenislik1+ pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 1.AT kazandýnýz");
                if(secim == 1)
                {
                    MessageBox.Show("seçiminiz doðru 1.at kazandý");
                }
                else
                {
                    MessageBox.Show("seçim yanlýþ");
                } 
            }




            if (atGenislik2+ pictureBox2.Left>= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 2.AT kazandýnýz");
                if (secim == 2)
                {
                    MessageBox.Show("seçiminiz doðru 2.at kazandý");
                }
                else
                {
                    MessageBox.Show("seçim yanlýþ");
                }
            }
            





            if (atGenislik3 + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 3.AT kazandýnýz");
                if (secim == 3)
                {
                    MessageBox.Show("seçiminiz doðru 3.at kazandý");
                }
                else 
                {
                    MessageBox.Show("seçim yanlýþ");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
    }
}