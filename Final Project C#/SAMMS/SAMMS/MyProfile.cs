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
    public partial class MyProfile : Form
    {
        EmpProfile ep;

        public MyProfile( EmpProfile ep)
        {
            this.ep = ep;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ep.Show();
            this.Hide();
        }

        private void MyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
