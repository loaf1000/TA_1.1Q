using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TA_1._1Q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuirk1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonQuirk2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimeDate.Text = DateTime.Now.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("..\\Farewell/ID_info.txt");
            String exitMessage = sr.ReadToEnd();
            const String MYNAME = "Laithe";

            sr.Close();

            MessageBox.Show("Thank you for viewing " + MYNAME + "'s Quirky Program!", "Goodbye!");
            
            MessageBox.Show(exitMessage, "ID Information");


            sr = new StreamReader("..\\Farewell/Credits.txt");
            exitMessage = sr.ReadToEnd();
            sr.Close();

            MessageBox.Show(exitMessage, "Credits");

            sr = new StreamReader("..\\Farewell/Media.txt");
            exitMessage = sr.ReadToEnd();
            sr.Close();

            MessageBox.Show(exitMessage, "Media");

            sr = new StreamReader("..\\Farewell/Stars.txt");
            exitMessage = sr.ReadToEnd();
            sr.Close();
            MessageBox.Show(exitMessage, "Stars");

            Close();
        }
    }
}
