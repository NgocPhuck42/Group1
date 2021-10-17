using BasicWinform;
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
    public partial class frmManagerUser : Form
    {
        public frmManagerUser()
        {
            InitializeComponent();
            var ls = Person.GetList();
            personBindingSource.DataSource = ls;
            dtgvUser.DataSource = personBindingSource;
        }

        public Person selectPerson {
            get
            {
                var p = personBindingSource.Current as Person;
                return p;
            }
        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(selectPerson != null)
            {
                var f = new frmUser(selectPerson.Id);
                f.Show();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectPerson != null)
            {
                var result = MessageBox.Show("Bạn có chắc muôn xóa sinh viên này không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    personBindingSource.RemoveCurrent(); // Xóa hiện tại mình đang đứng
                }
            }
        }
    }
}
