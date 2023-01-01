using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyManagerProjectVS2022
{
    public partial class Form2 : Form
    {
        int currentPasswordLength = 0;
        Random randomChar = new Random();

        public Form2()
        {
            InitializeComponent();
            trackBarPasswordLengthSlider.Minimum = 5;
            trackBarPasswordLengthSlider.Maximum = 20;
            passwordGenerator(5);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keydbDataSet.AccountId' table.
            // You can move, or remove it, as needed.
            this.accountIdTableAdapter.Fill(this.keydbDataSet.AccountId);
            accountIdBindingSource.DataSource = this.keydbDataSet.AccountId;
            //It updates the number of password count when the form page uploaded for the first time.
            showNumberOfPasswords();
        }

        private void showNumberOfPasswords()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=keydb.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            string query = "SELECT COUNT(*) FROM AccountId";
            OleDbCommand command = new OleDbCommand(query, connection);
            labelRowNumber.Text = "Number of Passwords: " + command.ExecuteScalar().ToString();
        } 

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you want to delete this record ?", 
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    accountIdBindingSource.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtTitle.Focus();
                this.keydbDataSet.AccountId.AddAccountIdRow(this.keydbDataSet.AccountId.NewAccountIdRow());
                accountIdBindingSource.MoveLast();
                accountIdTableAdapter.Update(this.keydbDataSet.AccountId);
                showNumberOfPasswords();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accountIdBindingSource.ResetBindings(false);
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this record ?", "Delete !!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                accountIdBindingSource.RemoveCurrent();
                accountIdTableAdapter.Update(this.keydbDataSet.AccountId);
            }
            showNumberOfPasswords();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtUserName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                accountIdBindingSource.EndEdit();
                accountIdTableAdapter.Update(this.keydbDataSet.AccountId);
                panel.Enabled = false;

            }catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accountIdBindingSource.ResetBindings(false);
            }
            showNumberOfPasswords();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.accountIdTableAdapter.Fill(this.keydbDataSet.AccountId);
                    accountIdBindingSource.DataSource = this.keydbDataSet.AccountId;
                    //dataGridView.DataSource = accountIdBindingSource;
                }
                else
                {
                    var query = from o in this.keydbDataSet.AccountId
                                where o.Title.Contains(txtSearch.Text) || o.UserName.Contains(txtSearch.Text) || o.URL.Contains(txtSearch.Text) || o.Notes.Contains(txtSearch.Text)
                                select o;
                    accountIdBindingSource.DataSource = query.ToList();
                }
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the KeyManager ?", "Close", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }
    
        private void passwordGenerator(int passwordLength)
        {
            String allChracters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!#$%&()*+,-./:;<=>?@[]^_{|}~";
            String randomPassword = "";
            
            for(int j=0; j < passwordLength; j++)
            {
                int randomNum = randomChar.Next(0, allChracters.Length);
                randomPassword += allChracters[randomNum];
            }
            labelPassword.Text = randomPassword;
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            //It copies the generated password to the clipboard.
            Clipboard.SetText(labelPassword.Text);
            currentPasswordLength = trackBarPasswordLengthSlider.Value;
            passwordGenerator(currentPasswordLength);
            MessageBox.Show("You have succesfully coppied the password.", "Message Coppied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBarPasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            labelPasswordLength.Text = "Password Length: " + trackBarPasswordLengthSlider.Value.ToString();
            currentPasswordLength = trackBarPasswordLengthSlider.Value;
            passwordGenerator(currentPasswordLength);
        }
      
        private void btnLock_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void labelRowNumber_Click(object sender, EventArgs e)
        {
            showNumberOfPasswords();
        } 
    }
}
