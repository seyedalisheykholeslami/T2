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
        List<Person> person =new List<Person>();
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            var information=new Person();
            information.FirstName= txtFirstName.Text;
            information.LastName= txtLastName.Text;
            information.NationalCode= txtNationalCode.Text;
            information.Geder=cmbGender.SelectedItem.ToString();
            person.Add(information);
            FillDGV();
        }

        private void FillDGV()
        {
            dgvPerson.DataSource = person.ToList();
        }
    }
}
