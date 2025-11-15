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
            var personal=new Person();
            personal.FirstName= txtFirstName.Text;
            personal.LastName= txtLastName.Text;
            personal.NationalCode= txtNationalCode.Text;
            personal.Geder=cmbGender.SelectedItem.ToString();
            person.Add(personal);
            FillDGV();
        }

        private void FillDGV()
        {
            dgvPerson.DataSource = person.ToList();
        }
    }
}
