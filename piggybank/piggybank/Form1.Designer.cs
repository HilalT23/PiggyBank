
namespace piggybank
{
    partial class Form1
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
            this.gbParaCinsi = new System.Windows.Forms.GroupBox();
            this.rbBanknot = new System.Windows.Forms.RadioButton();
            this.rbMadeni = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblKumbaraH = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnParaekle = new System.Windows.Forms.Button();
            this.btnKır = new System.Windows.Forms.Button();
            this.lbltoplampara = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblKMH = new System.Windows.Forms.Label();
            this.lblKumbaraMH = new System.Windows.Forms.Label();
            this.gbParaCinsi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParaCinsi
            // 
            this.gbParaCinsi.Controls.Add(this.rbBanknot);
            this.gbParaCinsi.Controls.Add(this.rbMadeni);
            this.gbParaCinsi.Location = new System.Drawing.Point(16, 94);
            this.gbParaCinsi.Margin = new System.Windows.Forms.Padding(2);
            this.gbParaCinsi.Name = "gbParaCinsi";
            this.gbParaCinsi.Padding = new System.Windows.Forms.Padding(2);
            this.gbParaCinsi.Size = new System.Drawing.Size(337, 89);
            this.gbParaCinsi.TabIndex = 0;
            this.gbParaCinsi.TabStop = false;
            this.gbParaCinsi.Text = "Para Tipi Seçin";
            // 
            // rbBanknot
            // 
            this.rbBanknot.AutoSize = true;
            this.rbBanknot.Location = new System.Drawing.Point(25, 44);
            this.rbBanknot.Margin = new System.Windows.Forms.Padding(2);
            this.rbBanknot.Name = "rbBanknot";
            this.rbBanknot.Size = new System.Drawing.Size(65, 17);
            this.rbBanknot.TabIndex = 0;
            this.rbBanknot.TabStop = true;
            this.rbBanknot.Text = "Banknot";
            this.rbBanknot.UseVisualStyleBackColor = true;
            this.rbBanknot.CheckedChanged += new System.EventHandler(this.rbBanknot_CheckedChanged);
            // 
            // rbMadeni
            // 
            this.rbMadeni.AutoSize = true;
            this.rbMadeni.Location = new System.Drawing.Point(128, 44);
            this.rbMadeni.Margin = new System.Windows.Forms.Padding(2);
            this.rbMadeni.Name = "rbMadeni";
            this.rbMadeni.Size = new System.Drawing.Size(63, 17);
            this.rbMadeni.TabIndex = 1;
            this.rbMadeni.TabStop = true;
            this.rbMadeni.Text = "Madeni ";
            this.rbMadeni.UseVisualStyleBackColor = true;
            this.rbMadeni.CheckedChanged += new System.EventHandler(this.rbMadeni_CheckedChanged);
            // 
            // lblKumbaraH
            // 
            this.lblKumbaraH.Location = new System.Drawing.Point(11, 15);
            this.lblKumbaraH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKumbaraH.Name = "lblKumbaraH";
            this.lblKumbaraH.Size = new System.Drawing.Size(138, 17);
            this.lblKumbaraH.TabIndex = 2;
            this.lblKumbaraH.Text = "Kumbara Hacmi:";
            // 
            // lblH
            // 
            this.lblH.Location = new System.Drawing.Point(167, 15);
            this.lblH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(77, 17);
            this.lblH.TabIndex = 3;
            this.lblH.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para Miktaraı seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 221);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnParaekle
            // 
            this.btnParaekle.Location = new System.Drawing.Point(16, 245);
            this.btnParaekle.Margin = new System.Windows.Forms.Padding(2);
            this.btnParaekle.Name = "btnParaekle";
            this.btnParaekle.Size = new System.Drawing.Size(149, 46);
            this.btnParaekle.TabIndex = 6;
            this.btnParaekle.Text = "Para ekle";
            this.btnParaekle.UseVisualStyleBackColor = true;
            this.btnParaekle.Click += new System.EventHandler(this.btnParaekle_Click);
            // 
            // btnKır
            // 
            this.btnKır.Location = new System.Drawing.Point(16, 296);
            this.btnKır.Margin = new System.Windows.Forms.Padding(2);
            this.btnKır.Name = "btnKır";
            this.btnKır.Size = new System.Drawing.Size(148, 46);
            this.btnKır.TabIndex = 7;
            this.btnKır.Text = "Kumbarayı Aç";
            this.btnKır.UseVisualStyleBackColor = true;
            this.btnKır.Click += new System.EventHandler(this.btnKır_Click);
            // 
            // lbltoplampara
            // 
            this.lbltoplampara.AutoSize = true;
            this.lbltoplampara.Location = new System.Drawing.Point(252, 15);
            this.lbltoplampara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltoplampara.Name = "lbltoplampara";
            this.lbltoplampara.Size = new System.Drawing.Size(31, 13);
            this.lbltoplampara.TabIndex = 8;
            this.lbltoplampara.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Shake";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Shake);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(288, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(64, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Kumbarayı Yapıştır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.KumbarayıYapıstir);
            // 
            // lblKMH
            // 
            this.lblKMH.Location = new System.Drawing.Point(167, 44);
            this.lblKMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKMH.Name = "lblKMH";
            this.lblKMH.Size = new System.Drawing.Size(77, 17);
            this.lblKMH.TabIndex = 13;
            this.lblKMH.Text = "0";
            // 
            // lblKumbaraMH
            // 
            this.lblKumbaraMH.Location = new System.Drawing.Point(11, 44);
            this.lblKumbaraMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKumbaraMH.Name = "lblKumbaraMH";
            this.lblKumbaraMH.Size = new System.Drawing.Size(138, 17);
            this.lblKumbaraMH.TabIndex = 12;
            this.lblKumbaraMH.Text = "Kumbara Mevcut Hacmi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 438);
            this.Controls.Add(this.lblKMH);
            this.Controls.Add(this.lblKumbaraMH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltoplampara);
            this.Controls.Add(this.btnKır);
            this.Controls.Add(this.btnParaekle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblKumbaraH);
            this.Controls.Add(this.gbParaCinsi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbParaCinsi.ResumeLayout(false);
            this.gbParaCinsi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParaCinsi;
        private System.Windows.Forms.RadioButton rbBanknot;
        private System.Windows.Forms.RadioButton rbMadeni;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblKumbaraH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnParaekle;
        private System.Windows.Forms.Button btnKır;
        private System.Windows.Forms.Label lbltoplampara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblKMH;
        private System.Windows.Forms.Label lblKumbaraMH;
    }
}

