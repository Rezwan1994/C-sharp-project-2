using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMMS
{
    public partial class BrandName : Form
    {
        EmpProfile ep;
        public BrandName(EmpProfile ep)
        {
            this.ep = ep;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ep.Show();
            this.Hide();
        }

        private void BrandName_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BrandName_Load(object sender, EventArgs e)
        {
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer(this);
            cs.Show();
            this.Hide();
        }

    
    }
}
