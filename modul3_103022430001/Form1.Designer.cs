namespace modul3_103022430001
{
    partial class nilaiAwal
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
            this.pilihAwal = new System.Windows.Forms.ComboBox();
            this.pilihAkhir = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.JUDUL1 = new System.Windows.Forms.Label();
            this.JUDULAKHIR = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pilihAwal
            // 
            this.pilihAwal.DisplayMember = "Celcius";
            this.pilihAwal.FormattingEnabled = true;
            this.pilihAwal.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.pilihAwal.Location = new System.Drawing.Point(81, 148);
            this.pilihAwal.Name = "pilihAwal";
            this.pilihAwal.Size = new System.Drawing.Size(121, 28);
            this.pilihAwal.TabIndex = 0;
            this.pilihAwal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pilihAkhir
            // 
            this.pilihAkhir.FormattingEnabled = true;
            this.pilihAkhir.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.pilihAkhir.Location = new System.Drawing.Point(81, 235);
            this.pilihAkhir.Name = "pilihAkhir";
            this.pilihAkhir.Size = new System.Drawing.Size(121, 28);
            this.pilihAkhir.TabIndex = 1;
            this.pilihAkhir.SelectedIndexChanged += new System.EventHandler(this.pilihAkhir_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // JUDUL1
            // 
            this.JUDUL1.AutoSize = true;
            this.JUDUL1.Location = new System.Drawing.Point(77, 125);
            this.JUDUL1.Name = "JUDUL1";
            this.JUDUL1.Size = new System.Drawing.Size(97, 20);
            this.JUDUL1.TabIndex = 5;
            this.JUDUL1.Text = "Satuan awal";
            this.JUDUL1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JUDULAKHIR
            // 
            this.JUDULAKHIR.AutoSize = true;
            this.JUDULAKHIR.Location = new System.Drawing.Point(77, 212);
            this.JUDULAKHIR.Name = "JUDULAKHIR";
            this.JUDULAKHIR.Size = new System.Drawing.Size(101, 20);
            this.JUDULAKHIR.TabIndex = 6;
            this.JUDULAKHIR.Text = "Satuan Akhir";
            this.JUDULAKHIR.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nilai Akhir";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nilai Awal";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // nilaiAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.JUDULAKHIR);
            this.Controls.Add(this.JUDUL1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pilihAkhir);
            this.Controls.Add(this.pilihAwal);
            this.Name = "nilaiAwal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pilihAwal;
        private System.Windows.Forms.ComboBox pilihAkhir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label JUDUL1;
        private System.Windows.Forms.Label JUDULAKHIR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

