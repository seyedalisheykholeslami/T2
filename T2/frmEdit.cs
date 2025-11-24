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
        private Person Add()
        {

                var information = new Person();
                information.FirstName = txtFirstName.Text;
                information.LastName = txtLastName.Text;
                information.NationalCode = txtNationalCode.Text;
                if (rdbWoman.Checked)
                {
                    information.Geder = "زن";
                }
                else if (rdbMan.Checked)
                {
                    information.Geder = "مرد";
                }
                else information.Geder = "نامشخص";

            
                var valid = information.ValidationInputs();
            if (valid.IsSuccess == true)
            {
                var isValidCode = txtNationalCode.Text.ValidationNC();
                if (isValidCode.IsSuccess == true)
                {
                    return information;

                }
                else
                {
                   
                    MessageBox.Show($"{isValidCode.Message}");
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"{valid.Message}");
                return null;
            }
               
        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (frm.dgvPerson.SelectedRows.Count == 0)
            {
                
                Person information= Add();
                if (information != null)
                {
                    frm.person.Add(information);
                    this.Close();
                }
                
            }
            else if (frm.dgvPerson.SelectedRows.Count == 1)
            {
                int row = frm.dgvPerson.CurrentRow.Index;
                Person information = Add();
                if (information != null)
                {
                    frm.person[row]=information;
                    this.Close();
                }
            }
            
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if (frm.dgvPerson.SelectedRows.Count != 0)
            {
                int row = frm.dgvPerson.CurrentRow.Index;
                txtFirstName.Text = frm.person[row].FirstName;
                txtLastName.Text = frm.person[row].LastName;
                txtNationalCode.Text = frm.person[row].NationalCode;
                if (frm.person[row].Geder == "زن")
                {
                    rdbWoman.Checked = true;
                }
                else if (frm.person[row].Geder == "مرد")
                {
                    rdbMan.Checked = true;
                }
 
            }
        }
    }
}
