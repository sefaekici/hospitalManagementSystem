namespace HastaneOtomasyonUygulamasi
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.PersonelGirisbtn = new System.Windows.Forms.Button();
            this.doktorSifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelTcmasked = new System.Windows.Forms.MaskedTextBox();
            this.PersonelSifremasked = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelGirisbtn
            // 
            this.PersonelGirisbtn.Location = new System.Drawing.Point(399, 361);
            this.PersonelGirisbtn.Name = "PersonelGirisbtn";
            this.PersonelGirisbtn.Size = new System.Drawing.Size(162, 51);
            this.PersonelGirisbtn.TabIndex = 15;
            this.PersonelGirisbtn.Text = "Giriş";
            this.PersonelGirisbtn.UseVisualStyleBackColor = true;
            this.PersonelGirisbtn.Click += new System.EventHandler(this.PersonelGirisbtn_Click);
            // 
            // doktorSifre
            // 
            this.doktorSifre.AutoSize = true;
            this.doktorSifre.Location = new System.Drawing.Point(234, 296);
            this.doktorSifre.Name = "doktorSifre";
            this.doktorSifre.Size = new System.Drawing.Size(41, 17);
            this.doktorSifre.TabIndex = 14;
            this.doktorSifre.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "T.C Kimlik No:";
            // 
            // PersonelTcmasked
            // 
            this.PersonelTcmasked.Location = new System.Drawing.Point(358, 189);
            this.PersonelTcmasked.Mask = "00000000000";
            this.PersonelTcmasked.Name = "PersonelTcmasked";
            this.PersonelTcmasked.Size = new System.Drawing.Size(233, 22);
            this.PersonelTcmasked.TabIndex = 17;
            this.PersonelTcmasked.ValidatingType = typeof(int);
            // 
            // PersonelSifremasked
            // 
            this.PersonelSifremasked.Location = new System.Drawing.Point(358, 296);
            this.PersonelSifremasked.Name = "PersonelSifremasked";
            this.PersonelSifremasked.PasswordChar = '*';
            this.PersonelSifremasked.Size = new System.Drawing.Size(233, 22);
            this.PersonelSifremasked.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(55, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PersonelTcmasked);
            this.Controls.Add(this.PersonelSifremasked);
            this.Controls.Add(this.PersonelGirisbtn);
            this.Controls.Add(this.doktorSifre);
            this.Controls.Add(this.label1);
            this.Name = "Personel";
            this.Text = "Personel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonelGirisbtn;
        private System.Windows.Forms.Label doktorSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PersonelTcmasked;
        private System.Windows.Forms.MaskedTextBox PersonelSifremasked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}