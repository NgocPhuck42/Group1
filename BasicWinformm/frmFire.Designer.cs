
namespace BasicWinformm
{
    partial class frmFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFire));
            this.lblFire = new System.Windows.Forms.Label();
            this.btnStar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbFire = new System.Windows.Forms.PictureBox();
            this.pbFire2 = new System.Windows.Forms.PictureBox();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnCountLove = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.BackColor = System.Drawing.Color.Lime;
            this.lblFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFire.Location = new System.Drawing.Point(235, 145);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(153, 108);
            this.lblFire.TabIndex = 0;
            this.lblFire.Text = "10";
            this.lblFire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStar
            // 
            this.btnStar.BackColor = System.Drawing.Color.Lime;
            this.btnStar.Location = new System.Drawing.Point(12, 369);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(75, 23);
            this.btnStar.TabIndex = 1;
            this.btnStar.Text = "Star";
            this.btnStar.UseVisualStyleBackColor = false;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbFire
            // 
            this.pbFire.Image = ((System.Drawing.Image)(resources.GetObject("pbFire.Image")));
            this.pbFire.Location = new System.Drawing.Point(267, 22);
            this.pbFire.Name = "pbFire";
            this.pbFire.Size = new System.Drawing.Size(345, 315);
            this.pbFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire.TabIndex = 2;
            this.pbFire.TabStop = false;
            // 
            // pbFire2
            // 
            this.pbFire2.Image = ((System.Drawing.Image)(resources.GetObject("pbFire2.Image")));
            this.pbFire2.Location = new System.Drawing.Point(-1, 44);
            this.pbFire2.Name = "pbFire2";
            this.pbFire2.Size = new System.Drawing.Size(273, 293);
            this.pbFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire2.TabIndex = 3;
            this.pbFire2.TabStop = false;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.BackColor = System.Drawing.Color.Black;
            this.lblTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimeNow.Location = new System.Drawing.Point(12, 8);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(146, 33);
            this.lblTimeNow.TabIndex = 4;
            this.lblTimeNow.Text = "TimeNow";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnCountLove
            // 
            this.btnCountLove.BackColor = System.Drawing.Color.Lime;
            this.btnCountLove.Location = new System.Drawing.Point(488, 369);
            this.btnCountLove.Name = "btnCountLove";
            this.btnCountLove.Size = new System.Drawing.Size(124, 23);
            this.btnCountLove.TabIndex = 5;
            this.btnCountLove.Text = "Đếm ngày yêu nhau";
            this.btnCountLove.UseVisualStyleBackColor = false;
            this.btnCountLove.Click += new System.EventHandler(this.btnCountLove_Click);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.Lime;
            this.btnYear.Location = new System.Drawing.Point(244, 369);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(117, 23);
            this.btnYear.TabIndex = 6;
            this.btnYear.Text = "Chúc mừng năm mới";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // frmFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 404);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnCountLove);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.pbFire2);
            this.Controls.Add(this.pbFire);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "frmFire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FireWork";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbFire;
        private System.Windows.Forms.PictureBox pbFire2;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnCountLove;
        private System.Windows.Forms.Button btnYear;
    }
}