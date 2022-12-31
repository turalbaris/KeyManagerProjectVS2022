namespace KeyManagerProjectVS2022
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.accountIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keydbDataSet = new KeyManagerProjectVS2022.keydbDataSet();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.accountIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.accountIdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.accountIdBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.accountIdBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.accountIdTableAdapter = new KeyManagerProjectVS2022.keydbDataSetTableAdapters.AccountIdTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.trackBarPasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.labelPasswordLength = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource4)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "URL";
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountIdBindingSource, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(136, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(366, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // accountIdBindingSource
            // 
            this.accountIdBindingSource.DataMember = "AccountId";
            this.accountIdBindingSource.DataSource = this.keydbDataSet;
            // 
            // keydbDataSet
            // 
            this.keydbDataSet.DataSetName = "keydbDataSet";
            this.keydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountIdBindingSource, "UserName", true));
            this.txtUserName.Location = new System.Drawing.Point(136, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(368, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // accountIdBindingSource1
            // 
            this.accountIdBindingSource1.DataMember = "AccountId";
            this.accountIdBindingSource1.DataSource = this.keydbDataSet;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountIdBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(136, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(368, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // accountIdBindingSource2
            // 
            this.accountIdBindingSource2.DataMember = "AccountId";
            this.accountIdBindingSource2.DataSource = this.keydbDataSet;
            // 
            // txtUrl
            // 
            this.txtUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountIdBindingSource, "URL", true));
            this.txtUrl.Location = new System.Drawing.Point(136, 142);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(368, 22);
            this.txtUrl.TabIndex = 3;
            // 
            // accountIdBindingSource3
            // 
            this.accountIdBindingSource3.DataMember = "AccountId";
            this.accountIdBindingSource3.DataSource = this.keydbDataSet;
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountIdBindingSource, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(136, 184);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(368, 154);
            this.txtNotes.TabIndex = 4;
            // 
            // accountIdBindingSource4
            // 
            this.accountIdBindingSource4.DataMember = "AccountId";
            this.accountIdBindingSource4.DataSource = this.keydbDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notes";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkOrange;
            this.panel.Controls.Add(this.txtNotes);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtUrl);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtPassword);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtUserName);
            this.panel.Controls.Add(this.txtTitle);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(543, 360);
            this.panel.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(158, 388);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Location = new System.Drawing.Point(61, 388);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(258, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.uRLDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.accountIdBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(576, 68);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(981, 662);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 75;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 120;
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            this.uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            this.uRLDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(855, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(928, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(320, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // accountIdTableAdapter
            // 
            this.accountIdTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(461, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.btnCopyPassword);
            this.panel1.Controls.Add(this.trackBarPasswordLengthSlider);
            this.panel1.Controls.Add(this.labelPasswordLength);
            this.panel1.Location = new System.Drawing.Point(12, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 296);
            this.panel1.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassword.Location = new System.Drawing.Point(127, 22);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(305, 48);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "label7";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopyPassword.Location = new System.Drawing.Point(137, 187);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(295, 56);
            this.btnCopyPassword.TabIndex = 2;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // trackBarPasswordLengthSlider
            // 
            this.trackBarPasswordLengthSlider.Location = new System.Drawing.Point(137, 125);
            this.trackBarPasswordLengthSlider.Name = "trackBarPasswordLengthSlider";
            this.trackBarPasswordLengthSlider.Size = new System.Drawing.Size(299, 56);
            this.trackBarPasswordLengthSlider.TabIndex = 1;
            this.trackBarPasswordLengthSlider.Scroll += new System.EventHandler(this.trackBarPasswordLengthSlider_Scroll);
            // 
            // labelPasswordLength
            // 
            this.labelPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPasswordLength.Location = new System.Drawing.Point(133, 70);
            this.labelPasswordLength.Name = "labelPasswordLength";
            this.labelPasswordLength.Size = new System.Drawing.Size(299, 52);
            this.labelPasswordLength.TabIndex = 0;
            this.labelPasswordLength.Text = "Password Length: 5";
            this.labelPasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLock.Location = new System.Drawing.Point(360, 388);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 14;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1569, 794);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Manager ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIdBindingSource4)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private keydbDataSet keydbDataSet;
        private System.Windows.Forms.BindingSource accountIdBindingSource;
        private keydbDataSetTableAdapters.AccountIdTableAdapter accountIdTableAdapter;
        private System.Windows.Forms.BindingSource accountIdBindingSource1;
        private System.Windows.Forms.BindingSource accountIdBindingSource2;
        private System.Windows.Forms.BindingSource accountIdBindingSource3;
        private System.Windows.Forms.BindingSource accountIdBindingSource4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelPasswordLength;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.TrackBar trackBarPasswordLengthSlider;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnLock;
    }
}