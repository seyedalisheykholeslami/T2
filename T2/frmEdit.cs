using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2
{
    public partial class frmEdit : Form
    {
        FrmPerson frm = Application.OpenForms[nameof(FrmPerson)] as FrmPerson;
        
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            int row = frm.dgvPerson.CurrentRow.Index;
            frm.person[row].FirstName=txtFirstName.Text;
            frm.person[row].LastName=txtLastName.Text;
            frm.person[row].NationalCode=txtNationalCode.Text;
            frm.person[row].Geder = cmbGender.SelectedItem.ToString();
            this.Close();

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            int row = frm.dgvPerson.CurrentRow.Index;
            txtFirstName.Text = frm.person[row].FirstName;
            txtLastName.Text = frm.person[row].LastName;
            txtNationalCode.Text = frm.person[row].NationalCode;
            cmbGender.SelectedItem = frm.person[row].Geder;
        }
    }
}
