using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyManagerProjectVS2022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keydbDataSet.AccountId' table. You can move, or remove it, as needed.
            this.accountIdTableAdapter.Fill(this.keydbDataSet.AccountId);
            accountIdBindingSource.DataSource = this.keydbDataSet.AccountId;

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accountIdBindingSource.ResetBindings(false);
            }
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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
                                where o.Title.Contains(txtSearch.Text) || o.UserName.Contains(txtSearch.Text) || o.Notes.Contains(txtSearch.Text)
                                select o;
                    accountIdBindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
        
       
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
