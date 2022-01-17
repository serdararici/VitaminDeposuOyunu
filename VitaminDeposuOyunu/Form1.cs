using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaminDeposuOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time = 60;  // Süre 0'dan başlar.
        double toplamVitaminA = 0;  // Toplam A vitamini değeri 0'dan başlar.
        double toplamVitaminC = 0;  // Toplam C vitamini değeri başlar.
        double toplamAgirlikSivi = 0;  // Toplam sıvı ağırlık 0'dan başlar.
        double toplamAgirlikPure = 0;  // Toplam püre ağırlık 0'dan başlar.

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop(); // Oyuna başlamadan süre başlamaz.

            // Oyun başlamadan sıkacak butonları çalışmaz.
            SuluMeyveSikacagiButonu.Enabled = false;
            KatiMeyveSikacagiButonu.Enabled = false;

            Sayaclabeli.Text = time.ToString();
            toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
            toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
            toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();
            toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0) // süre sıfırdan büyük olduğu sürece azalmaya devam eder.
            {
                timer1.Interval = 1000;
                int sayac = time--;
                Sayaclabeli.Text = sayac.ToString();
            }
            else
            {
                // süre 0 olduğunda sadece başla butonuna erişilebilir.
                baslaButonu.Enabled = true;
                SuluMeyveSikacagiButonu.Enabled = false;
                KatiMeyveSikacagiButonu.Enabled = false;
                timer1.Stop();
            }
        }

        private void baslaButonu_Click(object sender, EventArgs e)
        {
            time = 60; // süre sıfırlanır.
            timer1.Start();

            toplamVitaminA = 0;  // Toplam A vitamini Labeli sıfırlanır.
            toplamAVitaminiLabel.Text = toplamVitaminA.ToString();

            toplamVitaminC = 0;  // Toplam B vitamini Labeli sıfırlanır.
            toplamCVitaminiLabel.Text = toplamVitaminC.ToString();

            toplamAgirlikSivi = 0;  // Toplam Sıvı Ağırlık Labeli sıfırlanır.
            toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();

            toplamAgirlikPure = 0;  // Toplam Pure Ağırlık Labeli sıfırlanır.
            toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();

            Random rnd = new Random();
            Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.

            SuluMeyveSikacagiButonu.Enabled = true;  // Program başladığında sıkacak seçme butonları aktif olur.
            KatiMeyveSikacagiButonu.Enabled = true;
        }

        private void SuluMeyveSikacagiButonu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (Resimler.Image == meyves[0].Image)  // Ekrana gelen reim portakal ise
            {

                Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.
                Portakal portakal = new Portakal();
                toplamVitaminA += portakal.VitaminA();
                toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
                toplamVitaminC += portakal.VitaminC();
                toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
                toplamAgirlikPure += portakal.Pure();
                toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
                toplamAgirlikSivi += portakal.Sivi();
                toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();

            }
            else if (Resimler.Image == meyves[1].Image)  // Ekrana gelen resim mandalina ise
            {
                Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.
                Mandalina mandalina = new Mandalina();
                toplamVitaminA += mandalina.VitaminA();
                toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
                toplamVitaminC += mandalina.VitaminC();
                toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
                toplamAgirlikPure += mandalina.Pure();
                toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
                toplamAgirlikSivi += mandalina.Sivi();
                toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();
            }
            else if (Resimler.Image == meyves[2].Image)  // Ekrana gelen resim greyfurt ise
            {
                Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.
                Greyfurt greyfurt = new Greyfurt();
                toplamVitaminA += greyfurt.VitaminA();
                toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
                toplamVitaminC += greyfurt.VitaminC();
                toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
                toplamAgirlikPure += greyfurt.Pure();
                toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
                toplamAgirlikSivi += greyfurt.Sivi();
                toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();
            }
        }

        private void KatiMeyveSikacagiButonu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (Resimler.Image == meyves[3].Image)  // Ekrana gelen resim elma ise
            {
                Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.
                Elma elma = new Elma();
                toplamVitaminA += elma.VitaminA();
                toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
                toplamVitaminC += elma.VitaminC();
                toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
                toplamAgirlikPure += elma.Pure();
                toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
                toplamAgirlikSivi += elma.Sivi();
                toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();
            }
            else if (Resimler.Image == meyves[4].Image)  // Ekrana gelen resim armut ise
            {
                Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.
                Armut armut = new Armut();
                toplamVitaminA += armut.VitaminA();
                toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
                toplamVitaminC += armut.VitaminC();
                toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
                toplamAgirlikPure += armut.Pure();
                toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
                toplamAgirlikSivi += armut.Sivi();
                toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();
            }
            else if (Resimler.Image == meyves[5].Image)  // Ekrana gelen resim çilek ise
            {
                Resimler.Image = meyves[rnd.Next(0, 6)].Image;  // Random resim gelir.
                Cilek cilek = new Cilek();
                toplamVitaminA += cilek.VitaminA();
                toplamAVitaminiLabel.Text = toplamVitaminA.ToString();
                toplamVitaminC += cilek.VitaminC();
                toplamCVitaminiLabel.Text = toplamVitaminC.ToString();
                toplamAgirlikPure += cilek.Pure();
                toplamPureAgirlikLabel.Text = toplamAgirlikPure.ToString();
                toplamAgirlikSivi += cilek.Sivi();
                toplamSiviAgirlikLabel.Text = toplamAgirlikSivi.ToString();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Çıkış butonuna basınca program sona erer.
        }

        // Uygulamada kullanılcak resimler için List kullandım.
        
        List<IMeyve> meyves = new List<IMeyve>()
        {
            new Meyve (Image.FromFile("portakal.jpg")),
            new Meyve (Image.FromFile("mandalina.jpg")),
            new Meyve (Image.FromFile("greyfurt.jpg")),
            new Meyve (Image.FromFile("elma.jpg")),
            new Meyve (Image.FromFile("armut.jpg")),
            new Meyve (Image.FromFile("çilek.jpg"))
        };
    }
}
