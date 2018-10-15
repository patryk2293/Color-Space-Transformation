using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace AnalizaObrazu
{
    public struct Rgb
    {
        #region pola
        public byte b, g, r;
        #endregion pola
        public Rgb Negatyw()
        {
            Rgb rob;
            rob.r = (byte) (255 - this.r);
            rob.g = (byte) (255 - this.g);
            rob.b = (byte) (255 - this.b);
            return rob;
        }
        public Rgb Jasnosc()
        {
            Byte rob =(byte)(0.299*this.r + 0.587*this.g + 0.114*this.b);
            Rgb ret;
            ret.r = rob;
            ret.g = rob;
            ret.b = rob;
            return ret;
        }

        public Hsv KonwertujNaHsv()
        {
            double delta, min;
            double h = 0, s, v;

            min = Math.Min(Math.Max(this.r, this.g), this.b);
            v = Math.Max(Math.Max(this.r, this.g), this.b);
            delta = v - min;

            s = v == 0.0 ? 0.0 : delta / v;

            if (s == 0.0)
            {
                h = 0.0;
            }
            else
            {
                if (this.r == v)
                {
                    h = (this.g - this.b) / delta;
                }
                else if (this.g == v)
                {
                    h = 2 + (this.b - this.r) / delta;
                }
                else if (this.b == v)
                {
                    h = 4 + (this.r - this.g) / delta;
                }

                h *= 60;
                if (h < 0.0)
                {
                    h = h + 360;
                }
            }

            return new Hsv { H = h, S = s, V = v / 255 };
        }
    }

    public struct Hsv
    {
        public double H, S, V;

        public void DodajWektor(Hsv wektor)
        {
            var h = wektor.H + H;
            if (h < 0)
                h = 0;
            if (h > 360)
                h = 360;
            this.H = h;

            var s = wektor.S + S;
            if (s < 0)
                s = 0;
            if (s > 1)
                s = 1;
            this.S = s;

            var v = wektor.V + V;
            if (v < 0)
                v = 0;
            if (v > 1)
                v = 1;
            this.V = v;
        }

        public Rgb KonwertujNaRgb()
        {
            double r = 0, g = 0, b = 0;

            if (this.S == 0)
            {
                r = this.V;
                g = this.V;
                b = this.V;
            }
            else
            {
                int i;
                double f, p, q, t;

                if (this.H == 360)
                {
                    this.H = 0;
                }
                else
                {
                    this.H = this.H / 60;
                }

                i = (int)Math.Truncate(this.H);
                f = this.H - i;

                p = this.V * (1.0 - this.S);
                q = this.V * (1.0 - (this.S * f));
                t = this.V * (1.0 - (this.S * (1.0 - f)));

                switch (i)
                {
                    case 0:
                        r = this.V;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = this.V;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = this.V;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = this.V;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = this.V;
                        break;
                    default:
                        r = this.V;
                        g = p;
                        b = q;
                        break;
                }
            }

            return new Rgb { r = (byte)(r * 255), g = (byte)(g * 255), b = (byte)(b * 255) }; //ograniczyc do 255 i dla 0
        }
    }

    static class Efekty
    {
        public static Bitmap Negatyw(Bitmap bitmapaWe)
        {
            int wysokosc = bitmapaWe.Height;
            int szerokosc = bitmapaWe.Width;

            Bitmap bitmapaWy = new Bitmap(szerokosc, wysokosc, PixelFormat.Format24bppRgb);

            BitmapData bmWeData = bitmapaWe.LockBits(new Rectangle(0, 0, wysokosc, wysokosc),ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmWyData = bitmapaWy.LockBits(new Rectangle(0, 0, wysokosc, wysokosc),ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int strideWe = bmWeData.Stride;
            int strideWy = bmWeData.Stride;

            IntPtr scanWe = bmWeData.Scan0;
            IntPtr scanWy = bmWyData.Scan0;

            unsafe
            {
                for (int y = 0; y < wysokosc; y++)
                {
                    byte* pWe = (byte*)(void*)scanWe + y * strideWe;
                    byte* pWy = (byte*)(void*)scanWy + y * strideWy;

                    for (int x = 0; x < szerokosc; x++)
                    {
                        //todo
                        ((Rgb*)pWy)[x] = ((Rgb*)pWe)[x];
                    }
                }
            }
            bitmapaWy.UnlockBits(bmWyData);
            bitmapaWe.UnlockBits(bmWeData);

            return bitmapaWy;
        }
        public static Bitmap Jasnosc(Bitmap bitmapaWe)
        {
            int wysokosc = bitmapaWe.Height;
            int szerokosc = bitmapaWe.Width;

            Bitmap bitmapaWy = new Bitmap(szerokosc, wysokosc, PixelFormat.Format24bppRgb);

            BitmapData bmWeData = bitmapaWe.LockBits(new Rectangle(0, 0, wysokosc, wysokosc), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmWyData = bitmapaWy.LockBits(new Rectangle(0, 0, wysokosc, wysokosc), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int strideWe = bmWeData.Stride;
            int strideWy = bmWeData.Stride;

            IntPtr scanWe = bmWeData.Scan0;
            IntPtr scanWy = bmWyData.Scan0;

            unsafe
            {
                for (int y = 0; y < wysokosc; y++)
                {
                    byte* pWe = (byte*)(void*)scanWe + y * strideWe;
                    byte* pWy = (byte*)(void*)scanWy + y * strideWy;

                    for (int x = 0; x < szerokosc; x++)
                    {
                        //todo
                        ((Rgb*)pWy)[x] = ((Rgb*)pWe)[x];
                    }
                }
            }
            bitmapaWy.UnlockBits(bmWyData);
            bitmapaWe.UnlockBits(bmWeData);

            return bitmapaWy;
        }

        public static Bitmap Koloryzacja(Bitmap bitmapaWe, Hsv wektor)
        {
            int wysokosc = bitmapaWe.Height;
            int szerokosc = bitmapaWe.Width;

            Bitmap bitmapaWy = new Bitmap(szerokosc, wysokosc, PixelFormat.Format24bppRgb);

            BitmapData bmWeData = bitmapaWe.LockBits(new Rectangle(0, 0, szerokosc, wysokosc), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            BitmapData bmWyData = bitmapaWy.LockBits(new Rectangle(0, 0, szerokosc, wysokosc), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            int strideWe = bmWeData.Stride;
            int strideWy = bmWeData.Stride;

            IntPtr scanWe = bmWeData.Scan0;
            IntPtr scanWy = bmWyData.Scan0;

            unsafe
            {
                for (int y = 0; y < wysokosc; y++)
                {
                    byte* pWe = (byte*)(void*)scanWe + y * strideWe;
                    byte* pWy = (byte*)(void*)scanWy + y * strideWy;

                    for (int x = 0; x < szerokosc; x++)
                    {
                        var rgb = ((Rgb*)pWe)[x];
                        var hsv = rgb.KonwertujNaHsv();
                        hsv.DodajWektor(wektor);
                        ((Rgb*)pWy)[x] = hsv.KonwertujNaRgb();
                    }
                }
            }

            bitmapaWy.UnlockBits(bmWyData);
            bitmapaWe.UnlockBits(bmWeData);

            return bitmapaWy;
        }
    }
}
