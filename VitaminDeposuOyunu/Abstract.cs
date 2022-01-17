using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaminDeposuOyunu
{
    public abstract class SuluMeyve
    {
        Random rnd = new Random();
        public int MeyveVerim { get; set; }
        public int MeyveAgirlik { get; set; }
        public double AVitamini { get; set; }
        public double CVitamini { get; set; }
        public double PureAgirlik { get; set; }
        public double SiviAgirlik { get; set; }

        public int AgirlikMeyve()
        {
            MeyveAgirlik = rnd.Next(70, 120);   //Meyvelerin ağırlığı random olarak alınıyor.
            return MeyveAgirlik;
        }
        public int Verim()   
        {
            MeyveVerim = rnd.Next(30, 70);  //Meyvelerin verimi random olarak alınıyor. Sulu meyveler verim 30-70 arası.
            return MeyveVerim;
        }
        public virtual double VitaminA(int VitaminADeger)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;  // Meyvenin 100 gramında olan A vitamini değeri meyvenin ağırlığına bağlı olarak hesaplanıyor. 
            return AVitamini;
        }
        public virtual double VitaminC(int VitaminCDeger)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;  // Meyvenin 100 gramında olan C vitamini değeri meyvenin ağırlığına bağlı olarak hesaplanıyor.
            return CVitamini;
        }
        public double Sivi()
        {
            SiviAgirlik = (AgirlikMeyve() * Verim()) / 100;   // Meyvenin sıvı ağırlığı meyvenin ağırlığına ve verimine bağlı olarak hesaplanıyor.
            return SiviAgirlik;
        }
        public double Pure()
        {
            PureAgirlik = (AgirlikMeyve() - Sivi());  // Meyvenin püre ağırlığı meyvenin tüm ağırlığından sıvı ağırlığı çıkartılarak hesaplanıyor.
            return PureAgirlik;
        }

    }

    public abstract class KatiMeyve
    {
        Random rnd = new Random();
        public int MeyveVerim { get; set; }
        public int MeyveAgirlik { get; set; }
        public double AVitamini { get; set; }
        public double CVitamini { get; set; }
        public double PureAgirlik { get; set; }
        public double SiviAgirlik { get; set; }

        public int AgirlikMeyve()
        {
            MeyveAgirlik = rnd.Next(70, 120);  //Meyvelerin ağırlığı random olarak alınıyor.
            return MeyveAgirlik;
        }
        public int Verim()
        {
            MeyveVerim = rnd.Next(80, 95);  //Meyvelerin verimi random olarak alınıyor. Katı meyveler verim 80-95 arası.
            return MeyveVerim;
        }
        public virtual double VitaminA(int VitaminADeger)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;  // Meyvenin 100 gramında olan A vitaminİ değeri meyvenin ağırlığına bağlı olarak hesaplanıyor.
            return AVitamini;
        }
        public virtual double VitaminC(int VitaminCDeger)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;  // Meyvenin 100 gramında olan C vitaminİ değeri meyvenin ağırlığına bağlı olarak hesaplanıyor.
            return CVitamini;
        }
        public double Sivi()
        {
            SiviAgirlik = (AgirlikMeyve() * Verim()) / 100;  // Meyvenin sıvı ağırlığı meyvenin ağırlığına ve verimine bağlı olarak hesaplanıyor.
            return SiviAgirlik;
        }
        public double Pure()
        {
            PureAgirlik = (AgirlikMeyve() - Sivi());  // Meyvenin püre ağırlığı meyvenin tüm ağırlığından sıvı ağırlığı çıkartılarak hesaplanıyor.
            return PureAgirlik;
        }
    }
}
