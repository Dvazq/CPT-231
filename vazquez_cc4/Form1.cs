using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vazquez_cc4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vazquezMedicalDataSet.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.vazquezMedicalDataSet.appointments);

        }

        private void appointmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vazquezMedicalDataSet);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apptiDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apptiDLabel_Click(object sender, EventArgs e)
        {

        }

        private void apptpatientnameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
