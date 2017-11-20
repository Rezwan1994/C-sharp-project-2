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
    public partial class EmpLogIn : Form
    {

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuild = new PromptBuilder();
        SpeechRecognitionEngine sEng = new SpeechRecognitionEngine();
        public static int x = 0;
        public EmpLogIn()
        {
            InitializeComponent();
            linkLabel1.Text = "";
            linkLabel2.Text = "";

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (eText.Text.Equals("") || pText.Text.Equals(""))
            {
                linkLabel2.Text = "Required to Fill All The Field !!!";
                linkLabel1.Hide();
                pBuild.ClearContent();
                pBuild.AppendText("Required to Fill All The Field");
                sSynth.Speak(pBuild);
            }
            else
            {
                pBuild.ClearContent();
                pBuild.AppendText("Access Granted");
                sSynth.Speak(pBuild);
                
                EmpProfile em = new EmpProfile(this);
                em.Show();
                this.Hide();
                
            }
        }

        private void EmpLogIn_Load(object sender, EventArgs e)
        {
            panel1.Hide();

        }

        private void eText_Enter(object sender, EventArgs e)
        {

        }

        private void eText_Leave(object sender, EventArgs e)
        {
            if (eText.Text.Equals(""))
            {
                linkLabel1.Text = "Required to Fill Employee Id !!!";
            }

            else
            {
                linkLabel1.Hide();
            }
        }

        private void pText_Enter(object sender, EventArgs e)
        {

        }

        private void pText_Leave(object sender, EventArgs e)
        {
            if (pText.Text.Equals(""))
            {
                linkLabel2.Text = "Required to Fill Password !!!";
            }
            else
            {
                linkLabel2.Hide();
            }
        }


        private void register_Click(object sender, EventArgs e)
        {
           // WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
           // myplayer.URL = "E:\\Raees\\Dua.mp4";
           // myplayer.controls.play();
           // Registration r = new Registration(this);
            
            if (x==0)
            {
                panel1.Show();
                x = 1;
            }
            else if(x==1)
            {
                panel1.Hide();
                x = 0;
            }
            
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            pBuild.ClearContent();
            pBuild.AppendText("Welcome To System");
            sSynth.Speak(pBuild);
        }

        private void EmpLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logIn_Enter(object sender, EventArgs e)
        {
            if (eText.Text.Equals("") || pText.Text.Equals(""))
            {
                linkLabel2.Text = "Required to Fill All The Field !!!";
                linkLabel1.Hide();
                pBuild.ClearContent();
               // pBuild.AppendText("Required to Fill All The Field");
                sSynth.Speak(pBuild);
            }
            else
            {
                pBuild.ClearContent();
                pBuild.AppendText("Access Granted");
                sSynth.Speak(pBuild);

                EmpProfile em = new EmpProfile(this);
                em.Show();
                this.Hide();

            }
        }

        private void BckButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            FirstText.Text = "";
            LastText.Text = "";
            UserText.Text = "";
            PassText.Text = "";
            ConfirnText.Text = "";
            MobileText.Text = "";
            EmailText.Text = "";
        }









    }
}
