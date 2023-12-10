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
        Fil fil = new Fil();
        castle tas = new castle();
        Sah sah = new Sah();
        Vezir vezir = new Vezir();
        At at = new At();
        Piyon piyon = new Piyon();
        public Form1()
        {
            InitializeComponent();
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kale.kale2(pbPiyon1, pbAt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler,harikaydınız\n\nDetaylı bilgi için https://github.com/Aakcayy", "Oyun kapanıyor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            kale.kale1(pbPiyon8, pbAt2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz", "Oyun Başlıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pictureBox31.BackColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fil.fil1(pbPiyon4, pbPiyon2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fil.fil2(pbPiyon7, pbPiyon5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sah.sah(pbVezir, pbFil2, pbPiyon6, pbPiyon5, pbPiyon4);
        }

        private void pbVezir_Click(object sender, EventArgs e)
        {
            vezir.vezir(pbFil, pbSah, pbPiyon5, pbPiyon4, pbPiyon3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            at.at1(pictureBox20, pictureBox22);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            at.at2(pictureBox17, pictureBox31);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox22, pictureBox28);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            piyon.piyon2(pictureBox21, pictureBox27);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            piyon.piyon3(pictureBox20, pictureBox26);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            piyon.piyon4(pictureBox19,pictureBox25);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            piyon.piyon5(pictureBox18, pictureBox24);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            piyon.piyon6(pictureBox17, pictureBox23);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            piyon.piyon7(pictureBox32, pictureBox30);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            piyon.piyon8(pictureBox31, pictureBox29);
        }
    }
    public class piece
    {
        public PictureBox pbKale, pbAt, pbFil, pbVezir, pbSah, pbFil2, pbAt2, pbKale2, pbPiyon8;
        public PictureBox pbPiyon7, pbPiyon6, pbPiyon5, pbPiyon2, pbPiyon4, pbPiyon3, pbPiyon1, pictureBox17, pictureBox20, pictureBox22, pictureBox28, pictureBox23,pictureBox21,pictureBox27;
        public PictureBox pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox18, pictureBox19, pictureBox24, pictureBox25, pictureBox26;
        public string baslik1;
        public string icerik1;
        public int tıklanmaSayisi=1; 


        public virtual void tas(string baslik, string icerik) //piece sınıfında tas adlı metot virtual olarak tanımladım
        {
            this.baslik1 = baslik;
            this.icerik1 = icerik;

            MessageBox.Show($"{icerik1}", $"{baslik1}");
        }
    }
    interface Ikale
    {

        void kale1(PictureBox pbPiyon8, PictureBox pictureBox8);
        void kale2(PictureBox pictureBox16, PictureBox pictureBox2);
    }
   
    interface Ifil
    {
        void fil1(PictureBox pbPiyon4, PictureBox pbPiyon2);
        void fil2(PictureBox pbPiyon5, PictureBox pbPiyon4);
    }
    
    interface Isah
    {

        void sah(PictureBox pbVezir, PictureBox pbSah, PictureBox pbPiyon6, PictureBox pbPiyon5, PictureBox pbPiyon4);
    }
    interface Ivezir
    {

        void vezir(PictureBox pbVezir, PictureBox pbFil2, PictureBox pbPiyon5, PictureBox pbPiyon4, PictureBox pbPiyon3);
    }
    interface IAt
    {

        void at1(PictureBox pictureBox20, PictureBox pictureBox22);
        void at2(PictureBox pictureBox17, PictureBox pictureBox31);
    }
   
    interface Ipiyon
    {

        void piyon1(PictureBox pictureBox22, PictureBox pictureBox28);
        void piyon2(PictureBox pictureBox21, PictureBox pictureBox27);
        void piyon3(PictureBox pictureBox20, PictureBox pictureBox26);
        void piyon4(PictureBox pictureBox19, PictureBox pictureBox25);
        void piyon5(PictureBox pictureBox18, PictureBox pictureBox24);
        void piyon6(PictureBox pictureBox17, PictureBox pictureBox23);
        void piyon7(PictureBox pictureBox32, PictureBox pictureBox30);
        void piyon8(PictureBox pictureBox31, PictureBox pictureBox29);
    }
    public class castle : piece, Ikale // < Çoklu kalıtım yapıldı,castle sınıfı, piece sınıfından miras alarak tas metodunu override etti.
    {
        bool isFirstClick = true;

        public void kale1(PictureBox pbPiyon8, PictureBox pbKale2)
        {
            this.pbPiyon8 = pbPiyon8;
            this.pbKale2 = pbKale2;


            if (isFirstClick) //ilk tıklama
            {
                pbKale2.Image = null;//Resmi kaldır
                pbPiyon8.Image = null;
                pbKale2.BackColor = Color.LightPink;
                pbPiyon8.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                                                        // mavi > gidebileceği yerler gösterilir
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else // İkinci tıklama
            {
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
                //tekrar tekrar yazmak yerine tas metodunu kullanarak fazla kod yazmaktan kurtulacağız.
                //Bunun içinde  castle sınıfının tas metodunun piece sınıfındaki tas metodunu override eder.
                //override dediğimiz  bir alt sınıfın, üst sınıftan miras aldığı bir metodu tekrar aynı kodları yazmadan aynen veya değiştirerek kullanmasıdır.
                //castle sınıfındaki tas metodunda, temel sınıf yani piece sınıfındaki tas metodunu çağırarak,piece de tanımlanan bazı işlemleri yapmasını sağlıyor.
                //Farklı sınıflar için farklı parametreler alarak çalışır
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\Knight.jpg";
                Image image = Image.FromFile(imagePath);
                pbKale2.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pbPiyon8.Image = image2;
                /* tempImage = pictureBox7.Image;
                 pictureBox7.Image = pictureBox8.Image;
                 pictureBox8.Image = tempImage;*/

            }

            isFirstClick = !isFirstClick;
        }
        public void kale2(PictureBox pbPiyon1, PictureBox pbAt)
        {
            this.pbPiyon1 = pbPiyon1;
            this.pbAt = pbAt;


            if (isFirstClick)  // İlk tıklama
            {
                pbPiyon1.Image = null;//Resmi kaldır
                pbAt.Image = null;
                pbPiyon1.BackColor = Color.LightPink;
                pbAt.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                                                        // mavi > gidebileceği yerler gösterilir
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // İkinci tıklama
            {
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\Knight.jpg";
                Image image = Image.FromFile(imagePath);
                pbAt.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pbPiyon1.Image = image2;
            }

            isFirstClick = !isFirstClick;
        }



    }
    public class Fil : piece, Ifil
    {
        bool isFirstClick = true;

        public void fil1(PictureBox pbPiyon4, PictureBox pbPiyon2)
        {
            this.pbPiyon4 = pbPiyon4;
            this.pbPiyon2 = pbPiyon2;


            if (isFirstClick) //ilk tıklama
            {
                pbPiyon2.Image = null;//Resmi kaldır
                pbPiyon4.Image = null;
                pbPiyon2.BackColor = Color.LightPink;
                pbPiyon4.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                                                       
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else // İkinci tıklama
            {
                tas("Fil", "Her zaman çapraz gider ve kesinlikle önüne çıkan başka bir taşın üzerinden atlayamaz");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image = Image.FromFile(imagePath);
                pbPiyon2.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pbPiyon4.Image = image2;
                
            }

            isFirstClick = !isFirstClick;
        }
        public void fil2(PictureBox pbPiyon7, PictureBox pbPiyon5)
        {
            this.pbPiyon7 = pbPiyon7;
            this.pbPiyon5 = pbPiyon5;


            if (isFirstClick)  // İlk tıklama
            {
                pbPiyon7.Image = null;
                pbPiyon5.Image = null;
                pbPiyon7.BackColor = Color.LightPink;
                pbPiyon5.BackColor = Color.LightPink;
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // İkinci tıklama
            {
                tas("Fil", "Her zaman çapraz gider ve kesinlikle önüne çıkan başka bir taşın üzerinden atlayamaz");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image = Image.FromFile(imagePath);
                pbPiyon7.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pbPiyon5.Image = image2;
            }

            isFirstClick = !isFirstClick;
        }



    }
    public class Sah : piece, Isah 
    {
        bool isFirstClick = true;

        public void sah(PictureBox pbFil, PictureBox pbSah, PictureBox pbPiyon6, PictureBox pbPiyon5, PictureBox pbPiyon4)
        {
            this.pbFil= pbFil;
            this.pbSah = pbSah;
            this.pbPiyon6 = pbPiyon6;
            this.pbPiyon5 = pbPiyon5;
            this.pbPiyon4 = pbPiyon4;


            if (isFirstClick) //ilk tıklama
            {
                pbFil.Image = null;
                pbSah.Image = null;
                pbPiyon6.Image = null;
                pbPiyon5.Image = null;
                pbPiyon4.Image = null;
                pbFil.BackColor = Color.LightPink;
                pbSah.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                pbPiyon6.BackColor = Color.LightPink;
                pbPiyon5.BackColor = Color.LightPink;
                pbPiyon4.BackColor = Color.LightPink;
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else // İkinci tıklama
            {
                tas("Şah", "Her yöne tek kare ilerleyebilir ancak sadece bir kare öteye hareket edebilir.");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\Bishop.jpg";
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\Queen.jpg";
                string imagePath3 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                string imagePath4 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                string imagePath5 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";

                Image image = Image.FromFile(imagePath);
                Image image2 = Image.FromFile(imagePath2);
                Image image3 = Image.FromFile(imagePath3);
                Image image4 = Image.FromFile(imagePath4);
                Image image5 = Image.FromFile(imagePath5);

                pbSah.Image = image;
                pbFil.Image = image2;
                pbPiyon6.Image = image3;
                pbPiyon5.Image = image4;
                pbPiyon4.Image = image5;
            }

            isFirstClick = !isFirstClick;
        }
    }
    public class Vezir : piece, Ivezir 
    {
        bool isFirstClick = true;

        public void vezir(PictureBox pbVezir, PictureBox pbFil2, PictureBox pbPiyon5, PictureBox pbPiyon4, PictureBox pbPiyon3)
        {
            this.pbVezir = pbVezir;
            this.pbFil2 = pbFil2;
            this.pbPiyon5 = pbPiyon5;
            this.pbPiyon4 = pbPiyon4;
            this.pbPiyon3 = pbPiyon3;


            if (isFirstClick) //ilk tıklama
            {
                pbVezir.Image = null;
                pbFil2.Image = null;
                pbPiyon5.Image = null;
                pbPiyon4.Image = null;
                pbPiyon3.Image = null;
                pbVezir.BackColor = Color.LightPink;
                pbFil2.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                pbPiyon5.BackColor = Color.LightPink;
                pbPiyon4.BackColor = Color.LightPink;
                pbPiyon3.BackColor = Color.LightPink;
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else // İkinci tıklama
            {
                tas("Vezir", "Satranç oyunundaki saldırı alanı en geniş taştır.");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\Bishop.jpg";//fil
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\King.jpeg";//şah
                string imagePath3 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                string imagePath4 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                string imagePath5 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";

                Image image = Image.FromFile(imagePath);
                Image image2 = Image.FromFile(imagePath2);
                Image image3 = Image.FromFile(imagePath3);
                Image image4 = Image.FromFile(imagePath4);
                Image image5 = Image.FromFile(imagePath5);

                pbVezir.Image = image;
                pbFil2.Image = image2;
                pbPiyon5.Image = image3;
                pbPiyon4.Image = image4;
                pbPiyon3.Image = image5;
            }

            isFirstClick = !isFirstClick;
        }
    }
    public class At : piece,IAt
    {
        bool isFirstClick = true;

        public void at1(PictureBox pictureBox20, PictureBox pictureBox22)
        {
            this.pictureBox20 = pictureBox20;
            this.pictureBox22 = pictureBox22;


            if (isFirstClick) //ilk tıklama
            {
                
                pictureBox20.BackColor = Color.LightBlue;
                pictureBox22.BackColor = Color.LightBlue;// açık pembe > gidebileceği yönler kapalı anlamında
                                                        // mavi > gidebileceği yerler gösterilir
                

            }

            else // İkinci tıklama
            {
                tas("At", "Satranç oyununda hareketi sırasında diğer taşların üzerinden atlayabilen tek taştır.");
                pictureBox20.BackColor = Color.Transparent;
                pictureBox22.BackColor = Color.Transparent;
            }
           isFirstClick = !isFirstClick;
        }
        public void at2(PictureBox pictureBox17, PictureBox pictureBox31)
        {
            this.pictureBox17 = pictureBox17;
            this.pictureBox31 = pictureBox31;


            if (isFirstClick) //ilk tıklama
            {
                pictureBox17.BackColor = Color.LightBlue; // mavi > gidebileceği yerler gösterilir
                pictureBox31.BackColor = Color.LightBlue;
            }
            else // İkinci tıklama
            {
                tas("At", "Satranç oyununda hareketi sırasında diğer taşların üzerinden atlayabilen tek taştır.");
                pictureBox17.BackColor = Color.Black;
                pictureBox31.BackColor = Color.Black;

            }
            isFirstClick = !isFirstClick;
        }
    }

   public class Piyon : piece,Ipiyon
    {
        bool isFirstClick = true;

        public void piyon1(PictureBox pictureBox22, PictureBox pictureBox28)
        {
            this.pictureBox22 = pictureBox22; this.pictureBox28 = pictureBox28;
               
            
                    if (tıklanmaSayisi == 1)
                    {
                        pictureBox22.BackColor = Color.LightBlue;

                        tıklanmaSayisi=2;
                    }
                    else if (tıklanmaSayisi == 2)
                    {
                        pictureBox22.BackColor = Color.LightBlue;
                        pictureBox28.BackColor = Color.LightBlue;
                        tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                        tıklanmaSayisi++;
                        if (tıklanmaSayisi == 3)
                        {
                            pictureBox22.BackColor = Color.Transparent;
                            pictureBox28.BackColor = Color.Black;
                            tıklanmaSayisi = 0;
                        }
                    }
               
        }
        public void piyon2(PictureBox pictureBox21, PictureBox pictureBox27)
        {
            this.pictureBox21 = pictureBox21; this.pictureBox27 = pictureBox27;
            
            
                if (tıklanmaSayisi == 1)
                {
                  pictureBox21.BackColor = Color.LightBlue;

                    tıklanmaSayisi=2;
                }
                else if (tıklanmaSayisi == 2)
                {
                    pictureBox21.BackColor = Color.LightBlue;
                    pictureBox27.BackColor = Color.LightBlue;
                   tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                    if (tıklanmaSayisi == 3)
                    {
                        pictureBox21.BackColor = Color.Black;
                        pictureBox27.BackColor = Color.Transparent;
                        tıklanmaSayisi = 0;
                    }
                }


           
        }
        public void piyon3(PictureBox pictureBox20, PictureBox pictureBox26)
        {
            this.pictureBox20 = pictureBox20; this.pictureBox26 = pictureBox26;


            if (tıklanmaSayisi == 1)
            {
                pictureBox20.BackColor = Color.LightBlue;

                tıklanmaSayisi=2;
            }
            else if (tıklanmaSayisi == 2)
            {
                pictureBox20.BackColor = Color.LightBlue;
                pictureBox26.BackColor = Color.LightBlue;
                tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                if (tıklanmaSayisi == 3)
                {
                    pictureBox20.BackColor = Color.Transparent;
                    pictureBox26.BackColor = Color.Black;
                    tıklanmaSayisi = 0;
                }
            }



        }
        public void piyon4(PictureBox pictureBox19, PictureBox pictureBox25)
        {
            this.pictureBox19 = pictureBox19; this.pictureBox25 = pictureBox25;


            if (tıklanmaSayisi == 1)
            {
                pictureBox19.BackColor = Color.LightBlue;

                tıklanmaSayisi=2;
            }
            else if (tıklanmaSayisi == 2)
            {
                pictureBox19.BackColor = Color.LightBlue;
                pictureBox25.BackColor = Color.LightBlue;
                tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                if (tıklanmaSayisi == 3)
                {
                    pictureBox19.BackColor = Color.Black;
                    pictureBox25.BackColor = Color.Transparent;
                    tıklanmaSayisi = 0;
                }
            }



        }
        public void piyon5(PictureBox pictureBox18, PictureBox pictureBox24)
        {
            this.pictureBox18 = pictureBox18; this.pictureBox24 = pictureBox24;


            if (tıklanmaSayisi == 1)
            {
                pictureBox18.BackColor = Color.LightBlue;

                tıklanmaSayisi=2;
            }
            else if (tıklanmaSayisi == 2)
            {
                pictureBox18.BackColor = Color.LightBlue;
                pictureBox24.BackColor = Color.LightBlue;
                tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                if (tıklanmaSayisi == 3)
                {
                    pictureBox18.BackColor = Color.Transparent;
                    pictureBox24.BackColor = Color.Black;
                    tıklanmaSayisi = 0;
                }
            }



        }
        public void piyon6(PictureBox pictureBox17, PictureBox pictureBox23)
        {
            this.pictureBox17 = pictureBox17; this.pictureBox23 = pictureBox23;


            if (tıklanmaSayisi == 1)
            {
                pictureBox17.BackColor = Color.LightBlue;

                tıklanmaSayisi=2;
            }
            else if (tıklanmaSayisi == 2)
            {
                pictureBox17.BackColor = Color.LightBlue;
                pictureBox23.BackColor = Color.LightBlue;
                tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                if (tıklanmaSayisi == 3)
                {
                    pictureBox17.BackColor = Color.Black;
                    pictureBox23.BackColor = Color.Transparent;
                    tıklanmaSayisi = 0;
                }
            }



        }
        public void piyon7(PictureBox pictureBox32, PictureBox pictureBox30)
        {
            this.pictureBox32 = pictureBox32; this.pictureBox30 = pictureBox30;


            if (tıklanmaSayisi == 1)
            {
                pictureBox32.BackColor = Color.LightBlue;

                tıklanmaSayisi=2;
            }
            else if (tıklanmaSayisi == 2)
            {
                pictureBox32.BackColor = Color.LightBlue;
                pictureBox30.BackColor = Color.LightBlue;
                tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                if (tıklanmaSayisi == 3)
                {
                    pictureBox32.BackColor = Color.Transparent;
                    pictureBox30.BackColor = Color.Black;
                    tıklanmaSayisi = 0;
                }
            }



        }
        public void piyon8(PictureBox pictureBox31, PictureBox pictureBox29)
        {
            this.pictureBox31 = pictureBox31; this.pictureBox29 = pictureBox29;


            if (tıklanmaSayisi == 1)
            {
                pictureBox31.BackColor = Color.LightBlue;

                tıklanmaSayisi=2;
            }
            else if (tıklanmaSayisi == 2)
            {
                pictureBox31.BackColor = Color.LightBlue;
                pictureBox29.BackColor = Color.LightBlue;
                tas("Piyon", "Satranç oyunundaki en zayıf ve sayıca en fazla olan taştır. ");
                tıklanmaSayisi++;
                if (tıklanmaSayisi== 3)
                {
                    pictureBox31.BackColor = Color.Black;
                    pictureBox29.BackColor = Color.Transparent;
                    tıklanmaSayisi = 0;
                }
            }



        }


    }
    


}

