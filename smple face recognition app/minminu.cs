using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace smple_face_recognition_app
{
    public partial class minminu : System.Windows.Forms.Form
    {
       
        SpeechSynthesizer ss = new SpeechSynthesizer();
        Form1 f = new Form1();
      
        public minminu()
        {
            InitializeComponent();
            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync("pleac click on capture");
            if (f== null)
            {
               
                f = new Form1();
                f.Show();
            }
            else
            {
                f.Show();
                f.Focus();


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start("C:/Users/Majd Hammoud/Desktop/task/chrome1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
