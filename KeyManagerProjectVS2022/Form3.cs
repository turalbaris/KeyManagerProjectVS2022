using KeyManagerProjectVS2022.dbLoginDataSetTableAdapters;
using KeyManagerProjectVS2022.keydbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KeyManagerProjectVS2022
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLoginDataSet.Users' table.
            // You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dbLoginDataSet.Users);
            usersBindingSource.DataSource = this.dbLoginDataSet.Users;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private bool IsValidated()
        {
            //If at least one of the box is empty for the password change,
            //It'll give an error.
            if ((txtUserName.Text.Trim() == String.Empty) ||
                (txtCurrentPassword.Text.Trim() == String.Empty) ||
                (txtNewPassword.Text.Trim() == String.Empty) ||
                (txtConfirmPassword.Text.Trim() == String.Empty))
            {
                MessageBox.Show("All fields are required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //If new password and confirm password does not match
            //It gives error
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("New Password and Confirm Password does not match!", "Doesn not match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //If current password and new password are equal
            //It gives error
            if ((txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                && ((txtCurrentPassword.Text.Trim()) == txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("New Password and Current Password cant NOT BE SAME!", "Doesn not match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                try
                {
                    UpdatePassword();
                }
                catch(ApplicationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void UpdatePassword()
        {
            //It connects the loginDatabase..
            dbLoginDataSetTableAdapters.UsersTableAdapter user = new dbLoginDataSetTableAdapters.UsersTableAdapter();
            dbLoginDataSet.UsersDataTable dt = user.GetDataByUsernamePassword(txtUserName.Text, txtCurrentPassword.Text);

            //Checks if the username and password match with the database.
            //If matches change with the new one.
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You successfully changed your password.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbLogin.accdb";
                OleDbConnection connection = new OleDbConnection(connectionString);

                //It opens the database connection.
                //This code is required to run database queries.
                connection.Open();

                //It tooks the data from the text box that entered by user.
                string userName = txtUserName.Text;
                string currentPassword = txtCurrentPassword.Text;
                string newPassword = txtNewPassword.Text;

                //The sql query does not work when I don't use square brackets for the table name for this query.
                OleDbCommand command = new OleDbCommand("UPDATE Users SET [Password] = @newPassword " +
                                    "WHERE Username = @userName AND Password = @currentPassword", connection);

                //I took/received the data with the parameters. In this way,
                //there will be no vulnerabilities like SQL injection.
                command.Parameters.AddWithValue("@newPassword", newPassword);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@currentPassword", currentPassword);

                //It runs the SQL query.
                int affectedRows = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Your User Name and Current Password are NOT correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}
