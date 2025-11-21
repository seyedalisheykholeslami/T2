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
    public partial class FrmPerson : Form
    {
       public List<Person> person =new List<Person>();

        public FrmPerson()
        {
            InitializeComponent();
            FillDGV();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            
            var information=new Person();
            information.FirstName= txtFirstName.Text;
            information.LastName= txtLastName.Text;
            information.NationalCode= txtNationalCode.Text;
            information.Geder=cmbGender.SelectedItem.ToString();


            var isValid = information.ValidationInputs();
            if (isValid.Success == true)
            {
                var isValidCode = txtNationalCode.Text.ValidationNC();
                if (isValidCode.Success == true)
                {
                    person.Add(information);
                    FillDGV();
                }
                else
                {
                    MessageBox.Show($"{isValidCode.Message}");
                }
            }
            else
                MessageBox.Show($"{isValid.Message}");
            
            
        }

        private void FillDGV()
        {
            dgvPerson.DataSource = person.ToList();
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult check = MessageBox.Show("ایا میخواهید این ستر را ویرایش کنید؟","edit",MessageBoxButtons.OKCancel);
                if (check == DialogResult.OK)
                {
                    var frm = new frmEdit();
                    frm.ShowDialog();
                    FillDGV();
                   
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ویرایش اطلاعات خود روی سطر مورد نظر کیلیک کنید");
        }
    }
}
