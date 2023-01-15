namespace TB_megah_Prisya
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.btnID = new System.Windows.Forms.PictureBox();
            this.btnProfil = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.datauser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datauser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang USER !";
            // 
            // btnID
            // 
            this.btnID.Image = ((System.Drawing.Image)(resources.GetObject("btnID.Image")));
            this.btnID.Location = new System.Drawing.Point(22, 73);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(152, 50);
            this.btnID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnID.TabIndex = 1;
            this.btnID.TabStop = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.Location = new System.Drawing.Point(252, 73);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(155, 50);
            this.btnProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnProfil.TabIndex = 2;
            this.btnProfil.TabStop = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(483, 73);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 50);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // datauser
            // 
            this.datauser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datauser.Location = new System.Drawing.Point(12, 146);
            this.datauser.Name = "datauser";
            this.datauser.Size = new System.Drawing.Size(635, 292);
            this.datauser.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.datauser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datauser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnID;
        private System.Windows.Forms.PictureBox btnProfil;
        private System.Windows.Forms.PictureBox btnLogout;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datauser;
    }
}