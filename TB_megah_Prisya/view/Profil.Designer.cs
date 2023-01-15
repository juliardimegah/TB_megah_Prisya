namespace TB_megah_Prisya
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.PengeluaranMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.btnUP = new System.Windows.Forms.PictureBox();
            this.btnHA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(29, 89);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(601, 20);
            this.tbNama.TabIndex = 2;
            // 
            // PengeluaranMax
            // 
            this.PengeluaranMax.Location = new System.Drawing.Point(29, 186);
            this.PengeluaranMax.Name = "PengeluaranMax";
            this.PengeluaranMax.Size = new System.Drawing.Size(601, 20);
            this.PengeluaranMax.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pengeluaran Maksimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sumber Penghasilan";
            // 
            // cbSP
            // 
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Items.AddRange(new object[] {
            "Gaji",
            "Hasil Berjualan"});
            this.cbSP.Location = new System.Drawing.Point(29, 289);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(601, 21);
            this.cbSP.TabIndex = 6;
            // 
            // btnUP
            // 
            this.btnUP.Image = ((System.Drawing.Image)(resources.GetObject("btnUP.Image")));
            this.btnUP.Location = new System.Drawing.Point(74, 358);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(151, 41);
            this.btnUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnUP.TabIndex = 7;
            this.btnUP.TabStop = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnHA
            // 
            this.btnHA.Image = ((System.Drawing.Image)(resources.GetObject("btnHA.Image")));
            this.btnHA.Location = new System.Drawing.Point(419, 358);
            this.btnHA.Name = "btnHA";
            this.btnHA.Size = new System.Drawing.Size(151, 41);
            this.btnHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHA.TabIndex = 8;
            this.btnHA.TabStop = false;
            this.btnHA.Click += new System.EventHandler(this.btnHA_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.btnHA);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.cbSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PengeluaranMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox PengeluaranMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.PictureBox btnUP;
        private System.Windows.Forms.PictureBox btnHA;
    }
}