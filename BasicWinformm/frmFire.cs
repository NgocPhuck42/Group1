using BasicWinformm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BasicWinformm
{
    public partial class frmFire : Form
    {
        //  WindowsMediaPlayer sound;
        SoundManager sound = new SoundManager("E:\\NET Framework\\Group1\\BasicWinformm\\Sound\\Phaohoa.mp3");
        public frmFire()
        {

            InitializeComponent();
            pbFire.Visible = false;
            pbFire2.Visible = false;
            lblFire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            sound.Stop();
            timer2.Start();
            
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            second = int.Parse(lblFire.Text);
            if(!timer1.Enabled)
            {
                this.Opacity = 0.7;
                btnStar.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStar.Text = "Star";
                timer1.Stop();
            }
        }
 

        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0)
            {
                    
                pbFire.Visible = true;
                pbFire2.Visible = true;
                sound.Play();               
                lblFire.Visible = false;
                btnStar.Text = "Star";
                timer1.Stop();
               
            }
            else
            {
                
                second--;
                if(second <= 5)
                {
                    
                    lblFire.ForeColor = Color.Black;
                }
                
                lblFire.Text = $"{second.ToString("00")}";
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblTimeNow.Text = date.ToString();
        }

        private void btnCountLove_Click(object sender, EventArgs e)
        {
            frmLove love = new frmLove();
           // this.Hide();
            love.ShowDialog();
            this.Show();


        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            frmYear frmYear = new frmYear();
            frmYear.ShowDialog();
            this.Show();
        }
    }
}
