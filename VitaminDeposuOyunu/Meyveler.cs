using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaminDeposuOyunu
{
    public class Meyve : IMeyve
    {
        public Meyve(Image image)
        {
            Image = image;
        }
        public System.Drawing.Image Image { get; set; }
    }

    class Portakal : SuluMeyve
    {

        public override double VitaminA(int VitaminADeger = 225)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;
            return AVitamini;
        }
        public override double VitaminC(int VitaminCDeger = 45)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;
            return CVitamini;
        }
    }

    class Mandalina : SuluMeyve
    {
        public override double VitaminA(int VitaminADeger = 681)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;
            return AVitamini;
        }
        public override double VitaminC(int VitaminCDeger = 26)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;
            return CVitamini;
        }
    }

    class Greyfurt : SuluMeyve
    {
        public override double VitaminA(int VitaminADeger = 3)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;
            return AVitamini;
        }
        public override double VitaminC(int VitaminCDeger = 44)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;
            return CVitamini;
        }
    }

    class Elma : KatiMeyve
    {
        public override double VitaminA(int VitaminADeger = 54)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;
            return AVitamini;
        }
        public override double VitaminC(int VitaminCDeger = 5)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;
            return CVitamini;
        }
    }

    class Armut : KatiMeyve
    {
        public override double VitaminA(int VitaminADeger = 25)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;
            return AVitamini;
        }
        public override double VitaminC(int VitaminCDeger = 5)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;
            return CVitamini;
        }
    }

    class Cilek : KatiMeyve
    {
        public override double VitaminA(int VitaminADeger = 12)
        {
            AVitamini = (AgirlikMeyve() * VitaminADeger) / 100;
            return AVitamini;
        }
        public override double VitaminC(int VitaminCDeger = 60)
        {
            CVitamini = (AgirlikMeyve() * VitaminCDeger) / 100;
            return CVitamini;
        }
    }
}
