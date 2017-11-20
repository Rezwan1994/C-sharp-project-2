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
    public partial class Customer : Form
    {
        BrandName bs;
        public Customer(BrandName bs)
        {
            this.bs = bs;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.Show();
            this.Hide();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
