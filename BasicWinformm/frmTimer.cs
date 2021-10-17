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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (totalsecond == 0)
                timer1.Stop();
            else {
                totalsecond--;
                lblTimer.Text = $"{totalsecond/60:0#}:{totalsecond%60:0#}";
            }
        }
        int totalsecond = 0;
        private void btnStar_Click(object sender, EventArgs e)
        {
            var minute = (int) nmTimer.Value;
            totalsecond = minute * 60;
            timer1.Start();
        }
    }
}
