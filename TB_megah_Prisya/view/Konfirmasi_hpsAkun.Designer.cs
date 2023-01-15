namespace TB_megah_Prisya
{
    partial class Konfirmasi_hpsAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konfirmasi_hpsAkun));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTidak = new System.Windows.Forms.PictureBox();
            this.btnYA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnTidak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apakah Anda yakin untuk menghapus akun?";
            // 
            // btnTidak
            // 
            this.btnTidak.Image = ((System.Drawing.Image)(resources.GetObject("btnTidak.Image")));
            this.btnTidak.Location = new System.Drawing.Point(31, 77);
            this.btnTidak.Name = "btnTidak";
            this.btnTidak.Size = new System.Drawing.Size(119, 36);
            this.btnTidak.TabIndex = 1;
            this.btnTidak.TabStop = false;
            this.btnTidak.Click += new System.EventHandler(this.btnTidak_Click);
            // 
            // btnYA
            // 
            this.btnYA.Image = ((System.Drawing.Image)(resources.GetObject("btnYA.Image")));
            this.btnYA.Location = new System.Drawing.Point(177, 77);
            this.btnYA.Name = "btnYA";
            this.btnYA.Size = new System.Drawing.Size(117, 36);
            this.btnYA.TabIndex = 2;
            this.btnYA.TabStop = false;
            this.btnYA.Click += new System.EventHandler(this.btnYA_Click);
            // 
            // Konfirmasi_hpsAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnYA);
            this.Controls.Add(this.btnTidak);
            this.Controls.Add(this.label1);
            this.Name = "Konfirmasi_hpsAkun";
            this.Text = "Peringatan !";
            ((System.ComponentModel.ISupportInitialize)(this.btnTidak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnTidak;
        private System.Windows.Forms.PictureBox btnYA;
    }
}