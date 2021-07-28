using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciuzak;
        int ikinciuzak;
        int üçüncüuzak;

        Random rastgele = new Random();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciuzak = pictureBox1.Left;
            ikinciuzak = pictureBox2.Left;
            üçüncüuzak = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birincigenis = pictureBox1.Width;
            int ikincigenis = pictureBox2.Width;
            int ücüncügenis = pictureBox3.Width;

            int bitis = panel5.Left;


            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 18);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 18);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 18);

            if (pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+5)
            {
                label1.Text = "1 NUMARALI AT ÖNDE";
            }


            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label1.Text = "2 NUMARALI AT ÖNDE";
            }



            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label1.Text = "3 NUMARALI AT ÖNDE";
            }
            if (birincigenis+pictureBox1.Left >=bitis)
            {
                timer1.Enabled = false;
                label1.Text = "BİRİNCİ AT KAZANDI!!";


            }
            if (ikincigenis + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                label1.Text = "İKİNCİ AT KAZANDI!!";


            }

            if (ücüncügenis + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                label1.Text = "ÜÇÜNCÜ AT KAZANDI!!";


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label1.Text = "";
            timer1.Enabled = true;
        }
    }
}
