using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public abstract class Sekil
    {
        public Sekil()
        {

        }
        public Sekil(int x, int y, int genislik, int yukseklik, Color renk)
        {
            X = x;
            Y = y;
            Genislik = genislik;
            Yukseklik = yukseklik;
            Renk = renk;
        }
        public abstract string Tur { get; }
        public int Saydamlik { get; set; } = 255;
        public int X { get; set; }
        public int Y { get; set; }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public Color Renk { get; set; } = Color.Black;
        public abstract void Ciz(Graphics g);
        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
        public override string ToString()
        {
            return $"{Tur} ([{X},{Y}] {Genislik}x{Yukseklik} Renk:{Renk} Alan:{AlanHesapla():n2} Çevre:{CevreHesapla():n2})";
        }

        public void SaydamligiDegistir(int deger)
        {
            if (deger < 0 || deger > 255)
                return;

            Saydamlik = deger;
            Renk = Color.FromArgb(Saydamlik, Renk);
        }
    }
}
