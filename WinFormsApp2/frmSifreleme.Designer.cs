namespace WinFormsApp2
{
    partial class frmSifreleme
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
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.btnDosyaKaydet = new System.Windows.Forms.Button();
            this.txtCozulmusIcerik = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Location = new System.Drawing.Point(29, 36);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(144, 33);
            this.btnDosyaAc.TabIndex = 0;
            this.btnDosyaAc.Text = "Dosya Aç";
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // btnDosyaKaydet
            // 
            this.btnDosyaKaydet.Location = new System.Drawing.Point(29, 75);
            this.btnDosyaKaydet.Name = "btnDosyaKaydet";
            this.btnDosyaKaydet.Size = new System.Drawing.Size(144, 33);
            this.btnDosyaKaydet.TabIndex = 1;
            this.btnDosyaKaydet.Text = "Dosya Kaydet";
            this.btnDosyaKaydet.UseVisualStyleBackColor = true;
            this.btnDosyaKaydet.Click += new System.EventHandler(this.btnDosyaKaydet_Click);
            // 
            // txtCozulmusIcerik
            // 
            this.txtCozulmusIcerik.Location = new System.Drawing.Point(199, 36);
            this.txtCozulmusIcerik.Name = "txtCozulmusIcerik";
            this.txtCozulmusIcerik.Size = new System.Drawing.Size(375, 304);
            this.txtCozulmusIcerik.TabIndex = 2;
            this.txtCozulmusIcerik.Text = "";
            // 
            // frmSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.txtCozulmusIcerik);
            this.Controls.Add(this.btnDosyaKaydet);
            this.Controls.Add(this.btnDosyaAc);
            this.Name = "frmSifreleme";
            this.Text = "Şifreleme";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDosyaAc;
        private Button btnDosyaKaydet;
        private RichTextBox txtCozulmusIcerik;
    }
}