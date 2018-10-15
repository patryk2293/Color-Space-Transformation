using System;
using System.Windows.Forms;

namespace AnalizaObrazu
{
    public partial class Koloryzacja : Form
    {
        public Hsv Wektor { get; private set; }

        private double _hue;
        private double _saturation;
        private double _value;

        public Koloryzacja()
        {
            InitializeComponent();
            Wektor = new Hsv { H = 0, S = 0, V = 0 };
            lb_hue.Text = _hue.ToString("F");
            lb_saturation.Text = _saturation.ToString("F");
            lb_value.Text = _value.ToString("F");
        }

        private void tb_hue_Scroll(object sender, EventArgs e)
        {
            _hue = tb_hue.Value;
            lb_hue.Text = _hue.ToString("F");
        }

        private void tb_saturation_Scroll(object sender, EventArgs e)
        {
            _saturation = tb_saturation.Value / 100.0;
            lb_saturation.Text = _saturation.ToString("F");
        }

        private void tb_value_Scroll(object sender, EventArgs e)
        {
            _value = tb_value.Value / 100.0;
            lb_value.Text = _value.ToString("F");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Wektor = new Hsv {H = _hue, S = _saturation, V = _value};
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
