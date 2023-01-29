namespace RSSileVeriCekme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Getir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Getir
            // 
            this.Getir.Location = new System.Drawing.Point(12, 254);
            this.Getir.Name = "Getir";
            this.Getir.Size = new System.Drawing.Size(120, 44);
            this.Getir.TabIndex = 0;
            this.Getir.Text = "Getir";
            this.Getir.UseVisualStyleBackColor = true;
            this.Getir.Click += new System.EventHandler(this.Getir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 212);
            this.listBox1.TabIndex = 1;
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(366, 254);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(120, 44);
            this.Temizle.TabIndex = 2;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 319);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Getir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Getir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Temizle;
    }
}

