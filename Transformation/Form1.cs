using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalizaObrazu
{
    public partial class Form1 : Form
    {        
        private Bitmap _bitmapa;

        public Form1()
        {
            InitializeComponent();
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _bitmapa = new Bitmap(this.openFileDialog.FileName);
                this.mainPictureBox.Image = _bitmapa;
            }
        }

        private void negatywToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmapaWynikowa = Efekty.Negatyw(_bitmapa);
            this.mainPictureBox.Image = bitmapaWynikowa;
        }

        private void jasnośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToDo
        }

        private void koloryzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var koloryzacjaForm = new Koloryzacja();
            if (koloryzacjaForm.ShowDialog() == DialogResult.OK)
            {
                var bitmapaWynikowa = Efekty.Koloryzacja(_bitmapa, koloryzacjaForm.Wektor);
                this.mainPictureBox.Image = bitmapaWynikowa;
            }
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
