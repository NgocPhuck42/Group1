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
    public partial class frmYear : Form
    {
        public frmYear()
        {
            InitializeComponent();
            label3.Visible = true;
            lblYear.Visible = true;
            timer1.Start();
        }

        DateTime dateTime = new DateTime(2021, 10, 16, 14, 52, 05);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            TimeSpan dt = dateTime.Subtract(date);
            
            lblYear.Text = $"{dt.Days:0#} Ngày {dt.Hours:0#} Giờ {dt.Minutes:0#} Phút {dt.Seconds:0#} Giây";
            if (dt.TotalSeconds <= 0)
            {
                timer1.Stop();
                label3.Visible = false;
                lblYear.Visible = false;
            }
            else {

            }

        }

    
    }
}
