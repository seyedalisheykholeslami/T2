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

        public void FillDGV()
        {
            dgvPerson.DataSource = person.ToList();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ویرایش اطلاعات خود روی سطر مورد نظر کیلیک کنید");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frm = new frmEdit();
            frm.ShowDialog();
            FillDGV();
        }

        

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                DialogResult check = MessageBox.Show("ایا میخواهید این ستر را ویرایش کنید؟", "edit", MessageBoxButtons.OKCancel);
                if (check == DialogResult.OK)
                {
                    var frm = new frmEdit();
                    frm.ShowDialog();
                    FillDGV();

                }
            }
            else MessageBox.Show("لطفا یک سطر را انتخواب کنید", "edit");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                DialogResult check = MessageBox.Show("ایا میخواهید این ستر را حذف کنید؟", "edit", MessageBoxButtons.OKCancel);
                if (check == DialogResult.OK)
                {
                    person.RemoveAt(dgvPerson.CurrentRow.Index);
                    FillDGV();

                }
            }
            else MessageBox.Show("لطفا یک سطر را انتخواب کنید", "edit");
        }
    }
}
