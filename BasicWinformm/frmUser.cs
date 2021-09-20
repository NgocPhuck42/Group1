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
    public partial class frmUser : Form
    {
        Person person;
        public frmUser(string idPerson = "1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person != null)
            {

                txbHoten.Text = $"{person.LastName} {person.FirstName}";
              //  txbHoten.Text = person.FullName;
                dtpNgaysinh.Value = person.DOB;
                if (person.Sex == EGioiTinh.Nam)
                {
                    rdNam.Checked = true;
                }
                else rdNu.Checked = true;
                txbQuequan.Text = person.HowTown;
            }

            
        }

        
    }
}
