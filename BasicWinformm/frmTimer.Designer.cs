
namespace BasicWinformm
{
    partial class frmTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmTimer = new System.Windows.Forms.NumericUpDown();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian (m):";
            // 
            // nmTimer
            // 
            this.nmTimer.Location = new System.Drawing.Point(86, 7);
            this.nmTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmTimer.Name = "nmTimer";
            this.nmTimer.Size = new System.Drawing.Size(120, 20);
            this.nmTimer.TabIndex = 1;
            this.nmTimer.ThousandsSeparator = true;
            this.nmTimer.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(25, 45);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(75, 23);
            this.btnStar.TabIndex = 2;
            this.btnStar.Text = "Bắt đầu";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(131, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Dừng lại";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTimer.Location = new System.Drawing.Point(118, 121);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(162, 73);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "1:30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 282);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.nmTimer);
            this.Controls.Add(this.label1);
            this.Name = "frmTimer";
            this.Text = "frmTimer";
            ((System.ComponentModel.ISupportInitialize)(this.nmTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmTimer;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}