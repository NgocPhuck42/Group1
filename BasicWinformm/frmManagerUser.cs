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
    }
}
