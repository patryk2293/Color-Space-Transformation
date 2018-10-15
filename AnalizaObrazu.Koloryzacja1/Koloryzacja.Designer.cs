namespace AnalizaObrazu
{
    partial class Koloryzacja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_hue = new System.Windows.Forms.TrackBar();
            this.tb_saturation = new System.Windows.Forms.TrackBar();
            this.tb_value = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_hue = new System.Windows.Forms.Label();
            this.lb_saturation = new System.Windows.Forms.Label();
            this.lb_value = new System.Windows.Forms.Label();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_value)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_hue
            // 
            this.tb_hue.Location = new System.Drawing.Point(74, 12);
            this.tb_hue.Maximum = 360;
            this.tb_hue.Minimum = -360;
            this.tb_hue.Name = "tb_hue";
            this.tb_hue.Size = new System.Drawing.Size(270, 45);
            this.tb_hue.TabIndex = 0;
            this.tb_hue.TickFrequency = 36;
            this.tb_hue.Scroll += new System.EventHandler(this.tb_hue_Scroll);
            // 
            // tb_saturation
            // 
            this.tb_saturation.Location = new System.Drawing.Point(74, 63);
            this.tb_saturation.Maximum = 100;
            this.tb_saturation.Minimum = -100;
            this.tb_saturation.Name = "tb_saturation";
            this.tb_saturation.Size = new System.Drawing.Size(270, 45);
            this.tb_saturation.TabIndex = 1;
            this.tb_saturation.TickFrequency = 10;
            this.tb_saturation.Scroll += new System.EventHandler(this.tb_saturation_Scroll);
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(74, 114);
            this.tb_value.Maximum = 100;
            this.tb_value.Minimum = -100;
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(270, 45);
            this.tb_value.TabIndex = 2;
            this.tb_value.TickFrequency = 10;
            this.tb_value.Scroll += new System.EventHandler(this.tb_value_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // lb_hue
            // 
            this.lb_hue.AutoSize = true;
            this.lb_hue.Location = new System.Drawing.Point(350, 12);
            this.lb_hue.Name = "lb_hue";
            this.lb_hue.Size = new System.Drawing.Size(35, 13);
            this.lb_hue.TabIndex = 6;
            this.lb_hue.Text = "label4";
            // 
            // lb_saturation
            // 
            this.lb_saturation.AutoSize = true;
            this.lb_saturation.Location = new System.Drawing.Point(350, 63);
            this.lb_saturation.Name = "lb_saturation";
            this.lb_saturation.Size = new System.Drawing.Size(35, 13);
            this.lb_saturation.TabIndex = 7;
            this.lb_saturation.Text = "label5";
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.Location = new System.Drawing.Point(350, 114);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(35, 13);
            this.lb_value.TabIndex = 8;
            this.lb_value.Text = "label6";
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(310, 165);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(75, 23);
            this.btn_anuluj.TabIndex = 9;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(229, 165);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Koloryzacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.lb_value);
            this.Controls.Add(this.lb_saturation);
            this.Controls.Add(this.lb_hue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.tb_saturation);
            this.Controls.Add(this.tb_hue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Koloryzacja";
            this.Text = "Koloryzacja";
            ((System.ComponentModel.ISupportInitialize)(this.tb_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_hue;
        private System.Windows.Forms.TrackBar tb_saturation;
        private System.Windows.Forms.TrackBar tb_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_hue;
        private System.Windows.Forms.Label lb_saturation;
        private System.Windows.Forms.Label lb_value;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Button btn_ok;
    }
}