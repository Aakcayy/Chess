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
            kale.kale2(pictureBox16, pictureBox2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler,harikaydınız\n\nDetaylı bilgi için https://github.com/Aakcayy", "Oyun kapanıyor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            kale.kale1(pictureBox9, pictureBox8);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz", "Oyun Başlıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pictureBox31.BackColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fil.fil1(pictureBox13, pictureBox15);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fil.fil2(pictureBox10, pictureBox12);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sah.sah(pbVezir, pictureBox5, pictureBox11, pictureBox12, pictureBox13);
        }

        private void pbVezir_Click(object sender, EventArgs e)
        {
            vezir.vezir(pictureBox4, pictureBox6, pictureBox12, pictureBox13, pictureBox14);
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
            piyon.piyon1(pictureBox20, pictureBox22);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            piyon.piyon2(pictureBox21, pictureBox22);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox17, pictureBox21);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox23,pictureBox24);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox25, pictureBox26);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox27, pictureBox28);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox29, pictureBox30);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            piyon.piyon1(pictureBox31, pictureBox32);
        }
    }
    public class piece
    {
        public PictureBox pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9;
        public PictureBox pictureBox10, pictureBox11, pictureBox12, pictureBox15, pictureBox13, pictureBox14, pictureBox16, pictureBox17, pictureBox20, pictureBox22, pictureBox28, pictureBox23,pictureBox21,pictureBox27;
        public PictureBox pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox18, pictureBox19, pictureBox24, pictureBox25, pictureBox26;
        public string baslik1;
        public string icerik1;
       


        public virtual void tas(string baslik, string icerik) //piece sınıfında tas adlı metot virtual olarak tanımladım
        {
            this.baslik1 = baslik;
            this.icerik1 = icerik;

            MessageBox.Show($"{icerik1}", $"{baslik1}");
        }
    }
    interface Ikale
    {

        void kale1(PictureBox pictureBox9, PictureBox pictureBox8);
        void kale2(PictureBox pictureBox16, PictureBox pictureBox2);
    }
   
    interface Ifil
    {
        void fil1(PictureBox pictureBox13, PictureBox pictureBox15);
        void fil2(PictureBox pictureBox12, PictureBox pictureBox13);
    }
    
    interface Isah
    {

        void sah(PictureBox pbVezir, PictureBox pictureBox5, PictureBox pictureBox11, PictureBox pictureBox12, PictureBox pictureBox13);
    }
    interface Ivezir
    {

        void vezir(PictureBox pictureBox4, PictureBox pictureBox6, PictureBox pictureBox12, PictureBox pictureBox13, PictureBox pictureBox14);
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
    }
    public class castle : piece, Ikale // < Çoklu kalıtım yapıldı,castle sınıfı, piece sınıfından miras alarak tas metodunu override etti.
    {
        bool isFirstClick = true;

        public void kale1(PictureBox pictureBox9, PictureBox pictureBox8)
        {
            this.pictureBox9 = pictureBox9;
            this.pictureBox8 = pictureBox8;


            if (isFirstClick) //ilk tıklama
            {
                pictureBox8.Image = null;//Resmi kaldır
                pictureBox9.Image = null;
                pictureBox8.BackColor = Color.LightPink;
                pictureBox9.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
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
        public void kale2(PictureBox pictureBox16, PictureBox pictureBox2)
        {
            this.pictureBox16 = pictureBox16;
            this.pictureBox2 = pictureBox2;


            if (isFirstClick)  // İlk tıklama
            {
                pictureBox16.Image = null;//Resmi kaldır
                pictureBox2.Image = null;
                pictureBox16.BackColor = Color.LightPink;
                pictureBox2.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                                                        // mavi > gidebileceği yerler gösterilir
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // İkinci tıklama
            {
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\Knight.jpg";
                Image image = Image.FromFile(imagePath);
                pictureBox2.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pictureBox16.Image = image2;
            }

            isFirstClick = !isFirstClick;
        }



    }
    public class Fil : piece, Ifil
    {//29 10 7
        bool isFirstClick = true;

        public void fil1(PictureBox pictureBox13, PictureBox pictureBox15)
        {
            this.pictureBox13 = pictureBox13;
            this.pictureBox15 = pictureBox15;


            if (isFirstClick) //ilk tıklama
            {
                pictureBox15.Image = null;//Resmi kaldır
                pictureBox13.Image = null;
                pictureBox15.BackColor = Color.LightPink;
                pictureBox13.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                                                         // mavi > gidebileceği yerler gösterilir
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else // İkinci tıklama
            {
                tas("Fil", "Her zaman çapraz gider ve kesinlikle önüne çıkan başka bir taşın üzerinden atlayamaz");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image = Image.FromFile(imagePath);
                pictureBox15.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pictureBox13.Image = image2;
                /* tempImage = pictureBox7.Image;
                 pictureBox7.Image = pictureBox8.Image;
                 pictureBox8.Image = tempImage;*/

            }

            isFirstClick = !isFirstClick;
        }
        public void fil2(PictureBox pictureBox10, PictureBox pictureBox12)
        {
            this.pictureBox10 = pictureBox10;
            this.pictureBox12 = pictureBox12;


            if (isFirstClick)  // İlk tıklama
            {
                pictureBox10.Image = null;
                pictureBox12.Image = null;
                pictureBox10.BackColor = Color.LightPink;
                pictureBox12.BackColor = Color.LightPink;
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // İkinci tıklama
            {
                tas("Fil", "Her zaman çapraz gider ve kesinlikle önüne çıkan başka bir taşın üzerinden atlayamaz");
                string imagePath = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image = Image.FromFile(imagePath);
                pictureBox10.Image = image;
                string imagePath2 = "C:\\Users\\ahmet\\Desktop\\Proglama\\Ders-8\\Chess\\Piece\\pawn.jpg";
                Image image2 = Image.FromFile(imagePath2);
                pictureBox12.Image = image2;
            }

            isFirstClick = !isFirstClick;
        }



    }
    public class Sah : piece, Isah 
    {
        bool isFirstClick = true;

        public void sah(PictureBox pictureBox3, PictureBox pictureBox5, PictureBox pictureBox11, PictureBox pictureBox12, PictureBox pictureBox13)
        {
            this.pictureBox3 = pictureBox3;
            this.pictureBox5 = pictureBox5;
            this.pictureBox11 = pictureBox11;
            this.pictureBox12 = pictureBox12;
            this.pictureBox13 = pictureBox13;


            if (isFirstClick) //ilk tıklama
            {
                pictureBox3.Image = null;
                pictureBox5.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox3.BackColor = Color.LightPink;
                pictureBox5.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                pictureBox11.BackColor = Color.LightPink;
                pictureBox12.BackColor = Color.LightPink;
                pictureBox13.BackColor = Color.LightPink;
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

                pictureBox5.Image = image;
                pictureBox3.Image = image2;
                pictureBox11.Image = image3;
                pictureBox12.Image = image4;
                pictureBox13.Image = image5;
            }

            isFirstClick = !isFirstClick;
        }
    }
    public class Vezir : piece, Ivezir 
    {
        bool isFirstClick = true;

        public void vezir(PictureBox pictureBox4, PictureBox pictureBox6, PictureBox pictureBox12, PictureBox pictureBox13, PictureBox pictureBox14)
        {
            this.pictureBox4 = pictureBox4;
            this.pictureBox6 = pictureBox6;
            this.pictureBox12 = pictureBox12;
            this.pictureBox13 = pictureBox13;
            this.pictureBox14 = pictureBox14;


            if (isFirstClick) //ilk tıklama
            {
                pictureBox4.Image = null;
                pictureBox6.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox4.BackColor = Color.LightPink;
                pictureBox6.BackColor = Color.LightPink;// açık pembe > gidebileceği yönler kapalı anlamında
                pictureBox12.BackColor = Color.LightPink;
                pictureBox13.BackColor = Color.LightPink;
                pictureBox14.BackColor = Color.LightPink;
                MessageBox.Show("Hata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else // İkinci tıklama
            {
                tas("Şah", "Her yöne tek kare ilerleyebilir ancak sadece bir kare öteye hareket edebilir.");
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

                pictureBox4.Image = image;
                pictureBox6.Image = image2;
                pictureBox12.Image = image3;
                pictureBox13.Image = image4;
                pictureBox14.Image = image5;
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
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
                pictureBox20.BackColor = Color.Black;
                pictureBox22.BackColor = Color.Black;
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
                tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
                pictureBox17.BackColor = Color.Black;
                pictureBox31.BackColor = Color.Black;

            }
            isFirstClick = !isFirstClick;
        }
    }

   public class Piyon : piece,Ipiyon
    {
        bool isFirstClick = true;
        public int tıklanmaSayisi = 1;
        public int tıklanmaSayisi2 = 1;

        public void piyon1(PictureBox pictureBox22, PictureBox pictureBox28)
        {
            this.pictureBox22 = pictureBox22; this.pictureBox28 = pictureBox28;
               
            
                    if (tıklanmaSayisi == 1)
                    {
                        pictureBox22.BackColor = Color.LightBlue;

                        tıklanmaSayisi++;
                    }
                    else if (tıklanmaSayisi == 2)
                    {
                        pictureBox22.BackColor = Color.LightBlue;
                        pictureBox28.BackColor = Color.LightBlue;
                        tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
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
            
            
                if (tıklanmaSayisi2 == 1)
                {
                    pictureBox21.BackColor = Color.LightBlue;

                    tıklanmaSayisi2++;
                }
                else if (tıklanmaSayisi2 == 2)
                {
                    pictureBox21.BackColor = Color.LightBlue;
                    pictureBox27.BackColor = Color.LightBlue;
                    tas("Kale", "önünde bir taş olmadığı takdirde ileriye, geriye, sola ve sağa doğru istenildiği kadar gidilebilir");
                    tıklanmaSayisi2++;
                    if (tıklanmaSayisi2 == 3)
                    {
                        pictureBox21.BackColor = Color.Black;
                        pictureBox27.BackColor = Color.Transparent;
                        tıklanmaSayisi2 = 0;
                    }
                }


           
        }
            
   }
    


}

