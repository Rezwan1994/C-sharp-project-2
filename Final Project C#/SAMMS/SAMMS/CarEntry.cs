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
    public partial class CarEntry : Form
    {
        EmpProfile ep;
        public CarEntry(EmpProfile ep)
        {
            this.ep = ep;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep.Show();
            this.Hide();
        }

        private void CarEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
