namespace BarcodeMaker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.btn_barcode = new System.Windows.Forms.Button();
            this.btn_qrCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 208);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(118, 258);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(287, 20);
            this.txt_barcode.TabIndex = 2;
            // 
            // btn_barcode
            // 
            this.btn_barcode.Location = new System.Drawing.Point(118, 285);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(75, 23);
            this.btn_barcode.TabIndex = 3;
            this.btn_barcode.Text = "Generate";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // btn_qrCode
            // 
            this.btn_qrCode.Location = new System.Drawing.Point(118, 330);
            this.btn_qrCode.Name = "btn_qrCode";
            this.btn_qrCode.Size = new System.Drawing.Size(75, 23);
            this.btn_qrCode.TabIndex = 6;
            this.btn_qrCode.Text = "Generate";
            this.btn_qrCode.UseVisualStyleBackColor = true;
            this.btn_qrCode.Click += new System.EventHandler(this.btn_qrCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "QRCode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 79);
            this.button1.TabIndex = 7;
            this.button1.Text = " Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_qrCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_barcode);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Barcode And QRCode Maker By Jiyan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.Button btn_qrCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

