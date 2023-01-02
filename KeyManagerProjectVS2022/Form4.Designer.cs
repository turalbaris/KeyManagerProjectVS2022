namespace KeyManagerProjectVS2022
{
    partial class Form4
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGitHubProject = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(80, 110);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 68);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGitHub);
            this.panel1.Controls.Add(this.btnGitHubProject);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 281);
            this.panel1.TabIndex = 2;
            // 
            // btnGitHubProject
            // 
            this.btnGitHubProject.Location = new System.Drawing.Point(284, 30);
            this.btnGitHubProject.Name = "btnGitHubProject";
            this.btnGitHubProject.Size = new System.Drawing.Size(222, 40);
            this.btnGitHubProject.TabIndex = 2;
            this.btnGitHubProject.Text = "Open Git Repository";
            this.btnGitHubProject.UseVisualStyleBackColor = true;
            this.btnGitHubProject.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Location = new System.Drawing.Point(284, 91);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(222, 40);
            this.btnGitHub.TabIndex = 3;
            this.btnGitHub.Text = "Git Profile";
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Linkedin Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "My Website";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(570, 305);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGitHubProject;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGitHub;
    }
}