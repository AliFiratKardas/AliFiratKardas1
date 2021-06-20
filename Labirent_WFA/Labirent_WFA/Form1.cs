using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void txtAsagi_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";
        }

        private void txtYatay1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }

        private void txtYatay2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";


        }
        

        private void txtYatay3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";


        }

        private void txtYatay4_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";


        }

        private void txtUst_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }

        private void txtSOl_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }

        private void txtSag_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }

        private void txtDikey1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }

        private void txtDikey2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }

        private void txtDikey3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("oyunu kaybettiniz");
            lblSkor.Text = "0";

        }


        int skor;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int skor = 1;

            lblSkor.Text = Convert.ToString(skor);

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            skor = skor + 1;
            lblSkor.Text = Convert.ToString(skor);
            MessageBox.Show("TEBRİKLER PRENSESİ KURTARDINIZ");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
