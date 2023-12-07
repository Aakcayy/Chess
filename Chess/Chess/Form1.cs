using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chess.piece;

namespace Chess
{
    public partial class Form1 : Form
    {
        castle kale = new castle();
        castle tas= new castle();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             kale.kale2(pictureBox1, pictureBox22, pictureBox2);

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler,harikaydınız", "Oyun kapanıyor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            kale.kale1(pictureBox9, pictureBox8, pictureBox7);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz", "Oyun Başlıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox31.BackColor = Color.Black;
        }

    }
    public class piece
    {
        public PictureBox pictureBox7;
        public PictureBox pictureBox8;
        public PictureBox pictureBox9;
        public PictureBox pictureBox1,pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox22, pictureBox28, pictureBox31;
        public string baslik1;
        public string icerik1;

        public virtual void tas(string baslik,string icerik)
        {
            this.baslik1=baslik;
            this.icerik1 =icerik;

            MessageBox.Show($"{icerik1}",$"{baslik1}");
        }
    }
    interface Ikale1
    {

        void kale1(PictureBox pictureBox9, PictureBox pictureBox8, PictureBox pictureBox7);
    }
    interface Ikale2
    {

        void kale2(PictureBox pictureBox1, PictureBox pictureBox22, PictureBox pictureBox2);
    }
    public class castle : piece, Ikale1,Ikale2 //29 10 7
    {
        bool isFirstClick = true;
        
        public void kale1(PictureBox pictureBox9, PictureBox pictureBox8, PictureBox pictureBox7)
        {
            this.pictureBox9 = pictureBox9;
            this.pictureBox7 = pictureBox7;
            this.pictureBox8 = pictureBox8;


            if (isFirstClick)
            {
                // İlk tıklama
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox8.BackColor = Color.LightPink;
                pictureBox9.BackColor = Color.LightPink;// açık pembe > oynamaz yerinde
                                                         // mavi > oynar


            }
            
            else
            {
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");

                // İkinci tıklama

                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image = Image.FromFile(imagePath);
                pictureBox8.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pictureBox9.Image = image2;
                /* tempImage = pictureBox7.Image;
                 pictureBox7.Image = pictureBox8.Image;
                 pictureBox8.Image = tempImage;*/

            }

            isFirstClick = !isFirstClick;
        }
        public void kale2(PictureBox pictureBox1, PictureBox pictureBox22, PictureBox pictureBox2)
        {
            this.pictureBox1 = pictureBox1;
            this.pictureBox22 = pictureBox22;
            this.pictureBox2 = pictureBox2;


            if (isFirstClick)
            {
                // İlk tıklama
                pictureBox2.BackColor = Color.LightPink;
                pictureBox22.BackColor = Color.LightPink;// açık pembe



            }

            else
            {
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");

                // İkinci tıklama

                pictureBox2.BackColor = Color.Transparent;
                pictureBox22.BackColor = Color.Transparent;
                /* tempImage = pictureBox7.Image;
                 pictureBox7.Image = pictureBox8.Image;
                 pictureBox8.Image = tempImage;*/

            }

            isFirstClick = !isFirstClick;
        }



    }
}

