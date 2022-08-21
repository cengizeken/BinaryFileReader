namespace SampleBinaryReader
{
    partial class BellenimYukleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BellenimYukleme));
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(13, 12);
            this.tbFileName.Multiline = true;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(399, 136);
            this.tbFileName.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.ImageIndex = 0;
            this.btnGonder.ImageList = this.imageList1;
            this.btnGonder.Location = new System.Drawing.Point(418, 83);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(145, 65);
            this.btnGonder.TabIndex = 0;
            this.btnGonder.Text = "Dosya Gönder";
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDosyaSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSec.ImageIndex = 1;
            this.btnDosyaSec.ImageList = this.imageList1;
            this.btnDosyaSec.Location = new System.Drawing.Point(418, 12);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(145, 65);
            this.btnDosyaSec.TabIndex = 0;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.ImageIndex = 2;
            this.btnKapat.ImageList = this.imageList1;
            this.btnKapat.Location = new System.Drawing.Point(569, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 136);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mcsDosyaGonder.png");
            this.imageList1.Images.SetKeyName(1, "mcsDosyasiSec.png");
            this.imageList1.Images.SetKeyName(2, "FormKapat.png");
            // 
            // BellenimYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 155);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnDosyaSec);
            this.Name = "BellenimYukleme";
            this.Text = "Binary File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ImageList imageList1;
    }
}

