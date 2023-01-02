using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeyManagerProjectVS2022
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/turalbaris/KeyManagerProjectVS2022";
            System.Diagnostics.Process.Start(url);
        }

        private void btnGitHub_Click_1(object sender, EventArgs e)
        {
            string url2 = "https://github.com/turalbaris";
            System.Diagnostics.Process.Start(url2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url3 = "https://www.linkedin.com/in/baristural";
            System.Diagnostics.Process.Start(url3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url4 = "http://baristural.com/";
            System.Diagnostics.Process.Start(url4);
        }
    }
}
