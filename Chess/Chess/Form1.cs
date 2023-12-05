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
        castle kale = new castle();
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
                kale.kale2();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz", "Oyun Başlıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
    public class castle
    {
        Image tempImage;
        private PictureBox pictureBox2;
        private PictureBox pictureBox16;
        public void kale(PictureBox pictureBox2, PictureBox pictureBox16)
      {
            this.pictureBox2 = pictureBox2;
            this.pictureBox16 = pictureBox16;

        }
        public void kale2()
        {
            pictureBox2.BackColor = Color.Black;
            pictureBox16.BackColor = Color.Black;
           
        }

    }
}
