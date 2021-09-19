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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                var a = txbSothu1.Text;
                float na = Convert.ToInt64(a);

                var b = txbSothu2.Text;
                float nb = long.Parse(b);

                var c = (na + nb);

                lblKetqua.Text = c.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                var a = txbSothu1.Text;
                float na = Convert.ToInt64(a);

                var b = txbSothu2.Text;
                float nb = long.Parse(b);

                var c = (na - nb);

                lblKetqua.Text = c.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var a = txbSothu1.Text;
                float na = Convert.ToInt64(a);

                var b = txbSothu2.Text;
                float nb = long.Parse(b);

                var c =(Double) (na * nb);

                lblKetqua.Text = c.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try { 
                var a = txbSothu1.Text;
                var na = Convert.ToDouble(a);

                var b = txbSothu2.Text;
                var nb = long.Parse(b);

                var c = (float) (na / nb);

                lblKetqua.Text = c.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
