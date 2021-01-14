
namespace ZarAtmaOyunu
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
            this.buttonOyuncu1 = new System.Windows.Forms.Button();
            this.buttonZar1 = new System.Windows.Forms.Button();
            this.textBoxOyuncu1Ad = new System.Windows.Forms.TextBox();
            this.labelOyuncu1 = new System.Windows.Forms.Label();
            this.labelOyuncu2 = new System.Windows.Forms.Label();
            this.textBoxOyuncu2Ad = new System.Windows.Forms.TextBox();
            this.buttonZar2 = new System.Windows.Forms.Button();
            this.buttonOyuncu2 = new System.Windows.Forms.Button();
            this.labelKazanan = new System.Windows.Forms.Label();
            this.labelKazananYazı = new System.Windows.Forms.Label();
            this.labelOyuncu1Zar = new System.Windows.Forms.Label();
            this.labelOyuncu2Zar = new System.Windows.Forms.Label();
            this.textBoxOyuncu1Para = new System.Windows.Forms.TextBox();
            this.textBoxOyuncu2Para = new System.Windows.Forms.TextBox();
            this.textBoxOyuncu1BahisVer = new System.Windows.Forms.TextBox();
            this.buttonOyuncu1BahisVer = new System.Windows.Forms.Button();
            this.textBoxOyuncu2BahisVer = new System.Windows.Forms.TextBox();
            this.buttonOyuncu2BahisVer = new System.Windows.Forms.Button();
            this.labelOyuncu1KalanBakiye = new System.Windows.Forms.Label();
            this.label1BakiyeYazan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOyuncu2KalanBakiye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOyuncu1
            // 
            this.buttonOyuncu1.Location = new System.Drawing.Point(189, 61);
            this.buttonOyuncu1.Name = "buttonOyuncu1";
            this.buttonOyuncu1.Size = new System.Drawing.Size(89, 30);
            this.buttonOyuncu1.TabIndex = 0;
            this.buttonOyuncu1.Text = "Oyuncu 1";
            this.buttonOyuncu1.UseVisualStyleBackColor = true;
            this.buttonOyuncu1.Click += new System.EventHandler(this.buttonOyuncu1_Click);
            // 
            // buttonZar1
            // 
            this.buttonZar1.Location = new System.Drawing.Point(52, 267);
            this.buttonZar1.Name = "buttonZar1";
            this.buttonZar1.Size = new System.Drawing.Size(131, 31);
            this.buttonZar1.TabIndex = 1;
            this.buttonZar1.Text = "1. Oyuncu Zar At";
            this.buttonZar1.UseVisualStyleBackColor = true;
            this.buttonZar1.Click += new System.EventHandler(this.buttonZar1_Click);
            // 
            // textBoxOyuncu1Ad
            // 
            this.textBoxOyuncu1Ad.Location = new System.Drawing.Point(42, 61);
            this.textBoxOyuncu1Ad.Name = "textBoxOyuncu1Ad";
            this.textBoxOyuncu1Ad.Size = new System.Drawing.Size(131, 22);
            this.textBoxOyuncu1Ad.TabIndex = 2;
            // 
            // labelOyuncu1
            // 
            this.labelOyuncu1.AutoSize = true;
            this.labelOyuncu1.Location = new System.Drawing.Point(49, 236);
            this.labelOyuncu1.Name = "labelOyuncu1";
            this.labelOyuncu1.Size = new System.Drawing.Size(46, 17);
            this.labelOyuncu1.TabIndex = 3;
            this.labelOyuncu1.Text = "label1";
            // 
            // labelOyuncu2
            // 
            this.labelOyuncu2.AutoSize = true;
            this.labelOyuncu2.Location = new System.Drawing.Point(342, 236);
            this.labelOyuncu2.Name = "labelOyuncu2";
            this.labelOyuncu2.Size = new System.Drawing.Size(46, 17);
            this.labelOyuncu2.TabIndex = 7;
            this.labelOyuncu2.Text = "label2";
            // 
            // textBoxOyuncu2Ad
            // 
            this.textBoxOyuncu2Ad.Location = new System.Drawing.Point(335, 62);
            this.textBoxOyuncu2Ad.Name = "textBoxOyuncu2Ad";
            this.textBoxOyuncu2Ad.Size = new System.Drawing.Size(131, 22);
            this.textBoxOyuncu2Ad.TabIndex = 6;
            // 
            // buttonZar2
            // 
            this.buttonZar2.Enabled = false;
            this.buttonZar2.Location = new System.Drawing.Point(345, 267);
            this.buttonZar2.Name = "buttonZar2";
            this.buttonZar2.Size = new System.Drawing.Size(131, 30);
            this.buttonZar2.TabIndex = 5;
            this.buttonZar2.Text = "2. Oyuncu Zar At";
            this.buttonZar2.UseVisualStyleBackColor = true;
            this.buttonZar2.Click += new System.EventHandler(this.buttonZar2_Click);
            // 
            // buttonOyuncu2
            // 
            this.buttonOyuncu2.Location = new System.Drawing.Point(482, 62);
            this.buttonOyuncu2.Name = "buttonOyuncu2";
            this.buttonOyuncu2.Size = new System.Drawing.Size(93, 29);
            this.buttonOyuncu2.TabIndex = 4;
            this.buttonOyuncu2.Text = "Oyuncu 2";
            this.buttonOyuncu2.UseVisualStyleBackColor = true;
            this.buttonOyuncu2.Click += new System.EventHandler(this.buttonOyuncu2_Click);
            // 
            // labelKazanan
            // 
            this.labelKazanan.AutoSize = true;
            this.labelKazanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKazanan.Location = new System.Drawing.Point(226, 442);
            this.labelKazanan.Name = "labelKazanan";
            this.labelKazanan.Size = new System.Drawing.Size(93, 32);
            this.labelKazanan.TabIndex = 8;
            this.labelKazanan.Text = "label2";
            // 
            // labelKazananYazı
            // 
            this.labelKazananYazı.AutoSize = true;
            this.labelKazananYazı.Location = new System.Drawing.Point(229, 413);
            this.labelKazananYazı.Name = "labelKazananYazı";
            this.labelKazananYazı.Size = new System.Drawing.Size(64, 17);
            this.labelKazananYazı.TabIndex = 9;
            this.labelKazananYazı.Text = "Kazanan";
            // 
            // labelOyuncu1Zar
            // 
            this.labelOyuncu1Zar.AutoSize = true;
            this.labelOyuncu1Zar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOyuncu1Zar.Location = new System.Drawing.Point(65, 318);
            this.labelOyuncu1Zar.Name = "labelOyuncu1Zar";
            this.labelOyuncu1Zar.Size = new System.Drawing.Size(93, 32);
            this.labelOyuncu1Zar.TabIndex = 10;
            this.labelOyuncu1Zar.Text = "label2";
            // 
            // labelOyuncu2Zar
            // 
            this.labelOyuncu2Zar.AutoSize = true;
            this.labelOyuncu2Zar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOyuncu2Zar.Location = new System.Drawing.Point(370, 318);
            this.labelOyuncu2Zar.Name = "labelOyuncu2Zar";
            this.labelOyuncu2Zar.Size = new System.Drawing.Size(93, 32);
            this.labelOyuncu2Zar.TabIndex = 11;
            this.labelOyuncu2Zar.Text = "label2";
            // 
            // textBoxOyuncu1Para
            // 
            this.textBoxOyuncu1Para.Location = new System.Drawing.Point(42, 102);
            this.textBoxOyuncu1Para.Name = "textBoxOyuncu1Para";
            this.textBoxOyuncu1Para.Size = new System.Drawing.Size(131, 22);
            this.textBoxOyuncu1Para.TabIndex = 13;
            // 
            // textBoxOyuncu2Para
            // 
            this.textBoxOyuncu2Para.Location = new System.Drawing.Point(335, 102);
            this.textBoxOyuncu2Para.Name = "textBoxOyuncu2Para";
            this.textBoxOyuncu2Para.Size = new System.Drawing.Size(131, 22);
            this.textBoxOyuncu2Para.TabIndex = 15;
            // 
            // textBoxOyuncu1BahisVer
            // 
            this.textBoxOyuncu1BahisVer.Location = new System.Drawing.Point(42, 196);
            this.textBoxOyuncu1BahisVer.Name = "textBoxOyuncu1BahisVer";
            this.textBoxOyuncu1BahisVer.Size = new System.Drawing.Size(131, 22);
            this.textBoxOyuncu1BahisVer.TabIndex = 17;
            // 
            // buttonOyuncu1BahisVer
            // 
            this.buttonOyuncu1BahisVer.Location = new System.Drawing.Point(189, 196);
            this.buttonOyuncu1BahisVer.Name = "buttonOyuncu1BahisVer";
            this.buttonOyuncu1BahisVer.Size = new System.Drawing.Size(89, 50);
            this.buttonOyuncu1BahisVer.TabIndex = 16;
            this.buttonOyuncu1BahisVer.Text = "Oyuncu 1 Bahis Ver";
            this.buttonOyuncu1BahisVer.UseVisualStyleBackColor = true;
            this.buttonOyuncu1BahisVer.Click += new System.EventHandler(this.buttonOyuncu1BahisVer_Click);
            // 
            // textBoxOyuncu2BahisVer
            // 
            this.textBoxOyuncu2BahisVer.Location = new System.Drawing.Point(339, 196);
            this.textBoxOyuncu2BahisVer.Name = "textBoxOyuncu2BahisVer";
            this.textBoxOyuncu2BahisVer.Size = new System.Drawing.Size(131, 22);
            this.textBoxOyuncu2BahisVer.TabIndex = 20;
            // 
            // buttonOyuncu2BahisVer
            // 
            this.buttonOyuncu2BahisVer.Location = new System.Drawing.Point(486, 196);
            this.buttonOyuncu2BahisVer.Name = "buttonOyuncu2BahisVer";
            this.buttonOyuncu2BahisVer.Size = new System.Drawing.Size(89, 50);
            this.buttonOyuncu2BahisVer.TabIndex = 19;
            this.buttonOyuncu2BahisVer.Text = "Oyuncu 2 Bahis Ver";
            this.buttonOyuncu2BahisVer.UseVisualStyleBackColor = true;
            this.buttonOyuncu2BahisVer.Click += new System.EventHandler(this.buttonOyuncu2BahisVer_Click);
            // 
            // labelOyuncu1KalanBakiye
            // 
            this.labelOyuncu1KalanBakiye.AutoSize = true;
            this.labelOyuncu1KalanBakiye.Location = new System.Drawing.Point(68, 399);
            this.labelOyuncu1KalanBakiye.Name = "labelOyuncu1KalanBakiye";
            this.labelOyuncu1KalanBakiye.Size = new System.Drawing.Size(46, 17);
            this.labelOyuncu1KalanBakiye.TabIndex = 21;
            this.labelOyuncu1KalanBakiye.Text = "label1";
            // 
            // label1BakiyeYazan
            // 
            this.label1BakiyeYazan.AutoSize = true;
            this.label1BakiyeYazan.Location = new System.Drawing.Point(68, 382);
            this.label1BakiyeYazan.Name = "label1BakiyeYazan";
            this.label1BakiyeYazan.Size = new System.Drawing.Size(54, 17);
            this.label1BakiyeYazan.TabIndex = 22;
            this.label1BakiyeYazan.Text = "Bakiye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bakiye:";
            // 
            // labelOyuncu2KalanBakiye
            // 
            this.labelOyuncu2KalanBakiye.AutoSize = true;
            this.labelOyuncu2KalanBakiye.Location = new System.Drawing.Point(373, 399);
            this.labelOyuncu2KalanBakiye.Name = "labelOyuncu2KalanBakiye";
            this.labelOyuncu2KalanBakiye.Size = new System.Drawing.Size(46, 17);
            this.labelOyuncu2KalanBakiye.TabIndex = 23;
            this.labelOyuncu2KalanBakiye.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOyuncu2KalanBakiye);
            this.Controls.Add(this.label1BakiyeYazan);
            this.Controls.Add(this.labelOyuncu1KalanBakiye);
            this.Controls.Add(this.textBoxOyuncu2BahisVer);
            this.Controls.Add(this.buttonOyuncu2BahisVer);
            this.Controls.Add(this.textBoxOyuncu1BahisVer);
            this.Controls.Add(this.buttonOyuncu1BahisVer);
            this.Controls.Add(this.textBoxOyuncu2Para);
            this.Controls.Add(this.textBoxOyuncu1Para);
            this.Controls.Add(this.labelOyuncu2Zar);
            this.Controls.Add(this.labelOyuncu1Zar);
            this.Controls.Add(this.labelKazananYazı);
            this.Controls.Add(this.labelKazanan);
            this.Controls.Add(this.labelOyuncu2);
            this.Controls.Add(this.textBoxOyuncu2Ad);
            this.Controls.Add(this.buttonZar2);
            this.Controls.Add(this.buttonOyuncu2);
            this.Controls.Add(this.labelOyuncu1);
            this.Controls.Add(this.textBoxOyuncu1Ad);
            this.Controls.Add(this.buttonZar1);
            this.Controls.Add(this.buttonOyuncu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOyuncu1;
        private System.Windows.Forms.Button buttonZar1;
        private System.Windows.Forms.TextBox textBoxOyuncu1Ad;
        private System.Windows.Forms.Label labelOyuncu1;
        private System.Windows.Forms.Label labelOyuncu2;
        private System.Windows.Forms.TextBox textBoxOyuncu2Ad;
        private System.Windows.Forms.Button buttonZar2;
        private System.Windows.Forms.Button buttonOyuncu2;
        private System.Windows.Forms.Label labelKazanan;
        private System.Windows.Forms.Label labelKazananYazı;
        private System.Windows.Forms.Label labelOyuncu1Zar;
        private System.Windows.Forms.Label labelOyuncu2Zar;
        private System.Windows.Forms.TextBox textBoxOyuncu1Para;
        private System.Windows.Forms.TextBox textBoxOyuncu2Para;
        private System.Windows.Forms.TextBox textBoxOyuncu1BahisVer;
        private System.Windows.Forms.Button buttonOyuncu1BahisVer;
        private System.Windows.Forms.TextBox textBoxOyuncu2BahisVer;
        private System.Windows.Forms.Button buttonOyuncu2BahisVer;
        private System.Windows.Forms.Label labelOyuncu1KalanBakiye;
        private System.Windows.Forms.Label label1BakiyeYazan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOyuncu2KalanBakiye;
    }
}

