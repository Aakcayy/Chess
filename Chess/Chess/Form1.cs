using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isFirstClick = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image tempImage; //Image sınıfından tempImage değişkeni
            if (isFirstClick)
            {
                // İlk tıklama
                pictureBox2.BackColor = Color.Black;
                pictureBox16.BackColor = Color.Black;// veya başka bir resim veya null olarak ayarlayabilirsiniz
            }
            else
            {
                // İkinci tıklama
                pictureBox2.BackColor = Color.Transparent;
                pictureBox16.BackColor = Color.Transparent;
                tempImage = pictureBox1.Image;
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = tempImage;
            }

            isFirstClick = !isFirstClick;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Image tempImage;
            if (isFirstClick)
            {
                // İlk tıklama
                pictureBox9.BackColor = Color.Black;
                pictureBox8.BackColor = Color.Black;// 
                MessageBox.Show("Önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir. ", "Kale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // İkinci tıklama
                pictureBox9.BackColor = Color.Transparent;
                pictureBox8.BackColor = Color.Transparent;
                tempImage = pictureBox7.Image;
                pictureBox7.Image = pictureBox8.Image;
                pictureBox8.Image = tempImage;
            }

            isFirstClick = !isFirstClick;
        }
    }
}
