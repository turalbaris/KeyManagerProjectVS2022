using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyManagerProjectVS2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {          

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter your usarname.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            try
            {
                dbLoginDataSetTableAdapters.UsersTableAdapter user = new dbLoginDataSetTableAdapters.UsersTableAdapter();
                dbLoginDataSet.UsersDataTable dt = user.GetDataByUsernamePassword(txtUsername.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You have succesfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Process your login here :)))
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your usarname or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Gives error if the username and password don't match.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
