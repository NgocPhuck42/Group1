
namespace BasicWinformm
{
    partial class frmLove
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
            this.lblLove = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NGÀY BẮT ĐẦU YÊU:";
            // 
            // lblLove
            // 
            this.lblLove.AutoSize = true;
            this.lblLove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLove.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLove.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLove.Location = new System.Drawing.Point(280, 17);
            this.lblLove.Name = "lblLove";
            this.lblLove.Size = new System.Drawing.Size(93, 37);
            this.lblLove.TabIndex = 1;
            this.lblLove.Text = "label2";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Chocolate;
            this.lblCount.Location = new System.Drawing.Point(229, 197);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(63, 23);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số ngày yêu nhau:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(277, 118);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(35, 13);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "label3";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblDem
            // 
            this.lblDem.AutoSize = true;
            this.lblDem.Location = new System.Drawing.Point(438, 118);
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(35, 13);
            this.lblDem.TabIndex = 5;
            this.lblDem.Text = "label3";
            // 
            // frmLove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(714, 391);
            this.Controls.Add(this.lblDem);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblLove);
            this.Controls.Add(this.label1);
            this.Name = "frmLove";
            this.Text = "frmLove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLove;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDem;
    }
}