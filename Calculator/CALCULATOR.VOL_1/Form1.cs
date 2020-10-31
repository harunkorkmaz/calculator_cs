using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR.VOL_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "190206051";
        }
        private void Form1_Load(object sender, EventArgs e)
        { }

        
         // programın kotu yanı sadece x+y cınsı ıslem yapalıor x+y+z yok Ç(

        public int kacıncı_islem=0;                             // X Y LI GIRDIKLERIMDE DIZIDE YER BULMAK ICIN
        public int tekli_girdigim_sayılarım_icin_sayim = 0;     // SADEC X ICIN DIZIDEKI YER
        string[] sayılarımız =new string[100];                  // X ,Y GIRDIKLERIM ICIN(+ - * / % )
        string[] tekli_girdigim_sayılarım = new string[100];    // X GIRDIKŞERIM ICIN (X^2 1/X √X)
        public int hangi_islem = 0;                             // switch case ICIN

        //public bool karar = true;
        Random rastgele = new Random();
        public int sayi;
        public void button10_Click(object sender, EventArgs e)
        {
            if(sayi < 50 && sayi > 1) {
                textBox1.Text = null;
                textBox1.Text = "0";
                sayi = rastgele.Next(51, 100);
            }
            else {
                
                if (textBox1.Text == "0"/* && textBox1.Text != "/0"*/)
            {
                    textBox1.Text = "0";
            }

                else
            {
                   
                    textBox1.Text = textBox1.Text + "0";
            }
            }
            
        }
        public void button1_Click(object sender, EventArgs e)
        {

            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "1";
                sayi = rastgele.Next(51, 100);
            }
            else {
                if (textBox1.Text == "0" && textBox1.Text != null)
            {
                    textBox1.Text = "1";
            }
                else
            {
                    textBox1.Text = textBox1.Text + "1";
            }
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "2";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "2";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "3";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "3";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "4";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "4";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
        }
        public void button5_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "5";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "5";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }
        public void button6_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "6";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "6";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
        }
        public void button7_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "7";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "7";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
        }
        public void button8_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "8";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "8";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }

        }
        public void button9_Click(object sender, EventArgs e)
        {
            if (sayi < 50 && sayi > 1)
            {
                textBox1.Text = null;
                textBox1.Text = "9";
                sayi = rastgele.Next(51, 100);
            }
            else
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "9";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
        }
        
        
        public void button12_Click(object sender, EventArgs e)
        {// X+Y
            hangi_islem = 1; // bu toplam demek olucak 
            sayılarımız[kacıncı_islem++] = textBox1.Text; //x degerı kaydet  (y degerı ıcın bır kere yazmam bunu(x'i)bırden fazla kere yazmamın nedenı dısarıda yazmamam )
            textBox1.Text = null;
        }
        public void button13_Click(object sender, EventArgs e)
        {// X-Y
            hangi_islem = 2; // bu cıkarma demek olucak ılerde
            sayılarımız[kacıncı_islem++] = textBox1.Text;  //x degerı kaydet 
            textBox1.Text = null;
        }
        public void button14_Click(object sender, EventArgs e)
        {// X*Y
            hangi_islem = 3; // bu carpım demek olucak ılerde
            sayılarımız[kacıncı_islem++] = textBox1.Text; //x degerı kaydet 
            textBox1.Text = null;
        }
        public void button15_Click(object sender, EventArgs e)
        {// X/Y
            hangi_islem = 4; // bu bolme demek olucak ılerde
            sayılarımız[kacıncı_islem++] = textBox1.Text; // x degerı kaydet
            textBox1.Text = null;
        }
        public void button18_Click(object sender, EventArgs e)
        {// x%y
            hangi_islem = 5;
            sayılarımız[kacıncı_islem++] = textBox1.Text; 
            textBox1.Text = null;
        }
        private void button24_Click(object sender, EventArgs e)
        {// x^2
            hangi_islem = 7; // bu kok demek olucak ılerde
            tekli_girdigim_sayılarım[tekli_girdigim_sayılarım_icin_sayim] = textBox1.Text; // x degerı kaydet  SAYILARIMIZ ARRAYINDE HEPSI KAYITLI TUTULUOR
            textBox1.Text = null;
            tekli_girdigim_sayılarım_icin_sayim++;
        }
        public void button17_Click(object sender, EventArgs e)
        {// √x
            hangi_islem = 6; // bu kok demek olucak ılerde
            tekli_girdigim_sayılarım[tekli_girdigim_sayılarım_icin_sayim] =  textBox1.Text; // x degerı kaydet  SAYILARIMIZ ARRAYINDE HEPSI KAYITLI TUTULUOR
            textBox1.Text = null;
            tekli_girdigim_sayılarım_icin_sayim++;
        }
        public void button19_Click(object sender, EventArgs e)
        {// 1/x  BU . KOK VE KARE ALMA ISLEMLERINDE SAYILARIMIZ DIZISINDE YANLARINDAKI Y DEGERLERI BOS KLAICAK CUNKU BIRDEN FAZLA YANLARINA 
         //DEGER ALAMIOLAR .ALDIRMAYI BASARIRSAM AYNI ZAMANDA BIRDEN FAZLA DEGGER ALDIRABLIORUZ   
            hangi_islem = 8;
            tekli_girdigim_sayılarım[tekli_girdigim_sayılarım_icin_sayim] = textBox1.Text;
            textBox1.Text = null;
            tekli_girdigim_sayılarım_icin_sayim++;
            //kacıncı_islem++;
        }
        public void button16_Click(object sender, EventArgs e)
        { // +/-

        }
        public double buyuk_carpım=1 ;
        public int sonuc = 1;

        public void button25_Click(object sender, EventArgs e)
        {// buyuk toplam  (GRAND TOTAL)
            //int dongu_degiskeni = 0;
            //while (sayılarımız[dongu_degiskeni] != null)
            //{
            //    buyuk_carpım *= Convert.ToDouble(sayılarımız[3 * dongu_degiskeni + 2]);
            //    dongu_degiskeni++;
            //}
            
            string[] clist = listBox1.Items.OfType<string>().ToArray(); // stack overflow
            foreach(string item in clist)
            {
                sonuc *= Convert.ToInt16(item);
            }
            listBox1.Items.Add(Convert.ToString(sonuc));
            textBox1.Text = Convert.ToString(sonuc);
        }
        private void button26_Click(object sender, EventArgs e)
        {// MC (MEMORY CLEAN) MC
            listBox1.Items.Clear();
        }
        public void button21_Click(object sender, EventArgs e)
        {
            // C
            string s = textBox1.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            textBox1.Text = s;
        }

        public void button22_Click(object sender, EventArgs e)
        {
            // CE
            textBox1.Text = "0";
        }

        public void button23_Click(object sender, EventArgs e)
        {
            // <---- 

        }
        
        public void button20_Click(object sender, EventArgs e)
        {//  =
            sayi = rastgele.Next(1, 50); // sayı 1 50 arası ıse '= ' butonuna basılmıs demek olucak (işaret bir tür) 0 9 arası butonlar50 100 arası degerler atıcak kendılerıne
            double x,y,i=0;
            if (hangi_islem < 6) {
                sayılarımız[kacıncı_islem] = textBox1.Text;
                y = Convert.ToDouble(textBox1.Text);
                x = Convert.ToDouble(sayılarımız[kacıncı_islem - 1]);
            }
            else
            {
                x = Convert.ToDouble(tekli_girdigim_sayılarım[tekli_girdigim_sayılarım_icin_sayim ]);
            }
            
            //ornegın '+' ısaretıne bastıktan sonra sectıgı rakamlardan sonra bu fonksıyona tıklıcagını bıldıgm ıcın burada kayıt edıorum y degerını
            switch (hangi_islem) // basta verdıgım ınt deger sayesınde hangı ıslemde oldugumuzu ogrenıoruz .
            {
                case 1:
                    textBox1.Text = Convert.ToString(x + y);
                    textBox2.Text = "X + Y =";
                    break;
                case 2:
                    textBox1.Text = Convert.ToString(x - y);
                    textBox2.Text = "X - Y =";
                    break;
                case 3:                   
                    textBox1.Text = Convert.ToString(x * y);
                    textBox2.Text = "X * Y =";
                    break;
                case 4:                 
                    textBox1.Text = Convert.ToString(x / y);
                    textBox2.Text = "X / Y =";
                    break;
                case 5:
                    textBox1.Text = Convert.ToString(x % y);
                    textBox2.Text = "X % Y =";
                    break;
// ALTTAKILER ICIN BIRDEN FAZLA ISLEMLI PROBLEMLERI UYGULAMAMIZ DESTEKLEMELI, BU YUZDEN Y DEGISKENI VE FAZLASINI ALAMIORUZ(SADECE X).
                case 6:
                    textBox1.Text = Convert.ToString(Math.Sqrt(x));
                    textBox2.Text = "√x =";
                    break;
                case 7:
                    textBox1.Text = Convert.ToString(x*x);
                    textBox2.Text = "X^2 =";
                    break;
                case 8:
                    textBox1.Text = Convert.ToString(1/x);
                    textBox2.Text = "1/X =";

                    break;
                default:

                    break;
            }
            // her gırdıgımız degerı kat-ydetmek ıcın lıstbox
            listBox1.Items.Add(textBox1.Text);
            label1.Text = Convert.ToString(x);
            label2.Text = Convert.ToString(y);
            if (hangi_islem < 6) // 6 ve sonrası teklı ıslem
            {
                sayılarımız[kacıncı_islem] =textBox1.Text; // sonuc degerını kaydet
            }
            else
            {
                tekli_girdigim_sayılarım[tekli_girdigim_sayılarım_icin_sayim ]= textBox1.Text;
            }
           
            
        }

        public void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != ",")
            {
                textBox1.Text += "," ;
                
            }
        }

        
    }
}
