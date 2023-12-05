using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chess.piece;

namespace Chess
{
    public partial class Form1 : Form
    {
        castle kale = new castle();
        public Form1()
        {
            InitializeComponent();

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // kale.kale1(pictureBox1, pictureBox16, pictureBox2);
           
            bool isFirstClick = true;
            Image tempImage; //Image sınıfından tempImage değişkeni
            if (isFirstClick)
            {
                // İlk tıklama
               
                pictureBox2.BackColor = Color.Black;
                pictureBox16.BackColor = Color.Black;
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
            kale.kale1(pictureBox8, pictureBox9, pictureBox7);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz", "Oyun Başlıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
    public class piece
    {
        Image tempImage;
        bool isFirstClick = true;
        public PictureBox pictureBox7;
        public PictureBox pictureBox8;
        public PictureBox pictureBox9;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2, pictureBox3,pictureBox4, pictureBox5, pictureBox6, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16;
       

    }



    public class castle : piece
    {
        bool isFirstClick = true;
        public void kale(PictureBox pictureBox8, PictureBox pictureBox9, PictureBox pictureBox7)
        {

           

        }
        public void kale1(PictureBox pictureBox8, PictureBox pictureBox9, PictureBox pictureBox7)
        {
            this.pictureBox8 = pictureBox8;
            this.pictureBox7 = pictureBox7;
            this.pictureBox9 = pictureBox9;

         
            if (isFirstClick)
            {
                // İlk tıklama
                pictureBox9.BackColor = Color.LightPink;
                pictureBox8.BackColor = Color.LightPink;// 
                MessageBox.Show("Önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir. ", "Kale", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                // İkinci tıklama
                MessageBox.Show("Hareket alanı kapalı", "Kale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox9.BackColor = Color.Transparent;
                pictureBox8.BackColor = Color.Transparent;
                /*tempImage = pictureBox7.Image;
                pictureBox7.Image = pictureBox8.Image;
                pictureBox8.Image = tempImage;*/
              
            }

            isFirstClick = !isFirstClick;
        }
    }
}
