using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Media;
using System.Speech.Synthesis.TtsEngine;
using WMPLib;

namespace SAMMS
{
    public partial class EmpProfile : Form
    {
        EmpLogIn em;
        public EmpProfile(EmpLogIn em)
        {
            this.em = em;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BrandName bn = new BrandName(this);
            bn.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
           
            em.Show();
            this.Hide();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            MyProfile mf = new MyProfile(this);
            mf.Show();
            //WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            //myplayer.URL = "D:\\Spring 17\\Final Project C#\\Pics\\BEST.mp3";
            //myplayer.controls.play();
            this.Hide();

        }

        private void carEntryButton_Click(object sender, EventArgs e)
        {
            CarEntry cr = new CarEntry(this);
            cr.Show();
            this.Hide();
        }

        private void EmpProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            Email email = new Email(this);
            email.Show();
            this.Hide();
        }


    }
}
