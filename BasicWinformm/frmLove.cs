using BasicWinformm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinformm
{
    public partial class frmLove : Form
    {
        public frmLove()
        {
            InitializeComponent();
            Love();
            lblLoveDate();
            CountLove();
            Load += FrmLove_Load;
            timer1.Start();
        }

        Timer t;
        DateTime dateTime = new DateTime(2021, 8, 16, 23, 07, 48);
        private void FrmLove_Load(object sender, EventArgs e)
        {
            int result = DateTime.Compare(dateTime, now);

            if (result < 0)
            {
                dateTime = dateTime.AddMonths(1);
                d++;

            }
            else
            {
                TimeSpan ts = dateTime.Subtract(now);
                lblEnd.Text = $"{ts.Days:0#} Ngày {ts.Hours:0#} Giờ {ts.Minutes:0#} Phút {ts.Seconds:0#} Giây";
                timer1.Start();
            }

            lblDem.Text = d.ToString();
        }

        public void lblLoveDate()
        {
            DateTime dateTime = new DateTime(2021, 8, 16, 23, 07, 48);
            lblLove.Text= dateTime.ToString();
        }

        public void CountLove()
        {
            DateTime dateTime = new DateTime(2021, 8, 16, 23, 07, 48);
            DateTime date = DateTime.Now;

            TimeSpan count = date - dateTime;

            lblCount.Text = $"{count.Days:0#} Ngày {count.Hours:0#} Giờ {count.Minutes:0#} Phút {count.Seconds:0#} Giây";
            
        }

        void Love()
        {
  
        }
        
        DateTime now = DateTime.Now;
        int d = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            CountLove();
            int result = DateTime.Compare(dateTime, now);
            
            if(result < 0)
            {
                dateTime = dateTime.AddMonths(1);
                d++;
                
            }
            else { 
                TimeSpan ts = dateTime.Subtract(now);
                lblEnd.Text = $"{ts.Days:0#} Ngày {ts.Hours:0#} Giờ {ts.Minutes:0#} Phút {ts.Seconds:0#} Giây";
                timer1.Start();
            }
            
            lblDem.Text = d.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
