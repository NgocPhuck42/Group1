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
    public partial class frmLopHoc : Form
    {
        bool flag = true;
        public frmLopHoc()
        {
            InitializeComponent();

            List<Faculty> lstKhoa = new List<Faculty>();
            lstKhoa = Faculty.getList();
            
            flag = false;
            BindingSource binding = new BindingSource();
            binding.DataSource = lstKhoa;
             cbKhoa.DataSource = Faculty.getList();
           dtgvKhoa.DataSource = binding;
            cbKhoa.DisplayMember = "Name";
           cbKhoa.ValueMember = "Id";
            flag = true;
           
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                var index = cbKhoa.SelectedIndex;
                var item = cbKhoa.SelectedItem as Faculty;
                var lsPerson = Person.GetList(item.Id);
                MessageBox.Show($"Index = {index}. Item = {item.Name}");
                dtgvKhoa.DataSource = lsPerson;
            }
        }

       
    }
}
