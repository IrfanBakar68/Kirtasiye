namespace Kirtasiye
{
    partial class Siparisler
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSiparisNo = new System.Windows.Forms.TextBox();
            this.TxtFaturaNo = new System.Windows.Forms.TextBox();
            this.TxtPersonelNo = new System.Windows.Forms.TextBox();
            this.TxtMusteriNo = new System.Windows.Forms.TextBox();
            this.TxtToplamTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("SpeedBeast FREE", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(25, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Siparisler";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(572, 383);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(952, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(952, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(952, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(952, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sipariş No :";
            // 
            // TxtSiparisNo
            // 
            this.TxtSiparisNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSiparisNo.Location = new System.Drawing.Point(780, 94);
            this.TxtSiparisNo.Name = "TxtSiparisNo";
            this.TxtSiparisNo.Size = new System.Drawing.Size(150, 39);
            this.TxtSiparisNo.TabIndex = 8;
            // 
            // TxtFaturaNo
            // 
            this.TxtFaturaNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtFaturaNo.Location = new System.Drawing.Point(780, 184);
            this.TxtFaturaNo.Name = "TxtFaturaNo";
            this.TxtFaturaNo.Size = new System.Drawing.Size(150, 39);
            this.TxtFaturaNo.TabIndex = 9;
            // 
            // TxtPersonelNo
            // 
            this.TxtPersonelNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPersonelNo.Location = new System.Drawing.Point(780, 274);
            this.TxtPersonelNo.Name = "TxtPersonelNo";
            this.TxtPersonelNo.Size = new System.Drawing.Size(150, 39);
            this.TxtPersonelNo.TabIndex = 10;
            // 
            // TxtMusteriNo
            // 
            this.TxtMusteriNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMusteriNo.Location = new System.Drawing.Point(780, 229);
            this.TxtMusteriNo.Name = "TxtMusteriNo";
            this.TxtMusteriNo.Size = new System.Drawing.Size(150, 39);
            this.TxtMusteriNo.TabIndex = 11;
            // 
            // TxtToplamTutar
            // 
            this.TxtToplamTutar.BackColor = System.Drawing.SystemColors.Info;
            this.TxtToplamTutar.Location = new System.Drawing.Point(780, 139);
            this.TxtToplamTutar.Name = "TxtToplamTutar";
            this.TxtToplamTutar.Size = new System.Drawing.Size(150, 39);
            this.TxtToplamTutar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fatura No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Müşteri No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Personel No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Toplam Tutar :";
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtToplamTutar);
            this.Controls.Add(this.TxtMusteriNo);
            this.Controls.Add(this.TxtPersonelNo);
            this.Controls.Add(this.TxtFaturaNo);
            this.Controls.Add(this.TxtSiparisNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Siparisler";
            this.Text = "Siparisler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox TxtSiparisNo;
        private TextBox TxtFaturaNo;
        private TextBox TxtPersonelNo;
        private TextBox TxtMusteriNo;
        private TextBox TxtToplamTutar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}