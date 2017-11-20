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
    public partial class Email : Form
    {
        EmpProfile ep;
        public Email(EmpProfile ep)
        {
            this.ep=ep;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ep.Show();
            this.Hide();
        }

        private void Email_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
