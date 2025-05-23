﻿namespace ToDo_WForms_App
{
    partial class PasswordHelperChangeForm
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
            txtCPHNewHelper = new TextBox();
            lblCPHWelcone1 = new Label();
            lblCPHName = new Label();
            lblCPHPassword = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            lblCPHWelcone2 = new Label();
            btnCPHConfirm = new Button();
            button2 = new Button();
            txtCPHPassword = new TextBox();
            SuspendLayout();
            // 
            // txtCPHNewHelper
            // 
            txtCPHNewHelper.Location = new Point(442, 104);
            txtCPHNewHelper.Margin = new Padding(4);
            txtCPHNewHelper.MaxLength = 100;
            txtCPHNewHelper.Name = "txtCPHNewHelper";
            txtCPHNewHelper.Size = new Size(335, 40);
            txtCPHNewHelper.TabIndex = 0;
            // 
            // lblCPHWelcone1
            // 
            lblCPHWelcone1.AutoEllipsis = true;
            lblCPHWelcone1.AutoSize = true;
            lblCPHWelcone1.Location = new Point(31, 9);
            lblCPHWelcone1.Margin = new Padding(4, 0, 4, 0);
            lblCPHWelcone1.Name = "lblCPHWelcone1";
            lblCPHWelcone1.Size = new Size(458, 33);
            lblCPHWelcone1.TabIndex = 1;
            lblCPHWelcone1.Text = "You can change your Password Helper. ";
            // 
            // lblCPHName
            // 
            lblCPHName.AutoSize = true;
            lblCPHName.Location = new Point(31, 111);
            lblCPHName.Margin = new Padding(4, 0, 4, 0);
            lblCPHName.Name = "lblCPHName";
            lblCPHName.Size = new Size(391, 33);
            lblCPHName.TabIndex = 1;
            lblCPHName.Text = "Name a NEW place in the world:";
            // 
            // lblCPHPassword
            // 
            lblCPHPassword.AutoSize = true;
            lblCPHPassword.Location = new Point(31, 157);
            lblCPHPassword.Margin = new Padding(4, 0, 4, 0);
            lblCPHPassword.Name = "lblCPHPassword";
            lblCPHPassword.Size = new Size(223, 33);
            lblCPHPassword.TabIndex = 1;
            lblCPHPassword.Text = "Current Password:";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // lblCPHWelcone2
            // 
            lblCPHWelcone2.AutoEllipsis = true;
            lblCPHWelcone2.AutoSize = true;
            lblCPHWelcone2.Location = new Point(31, 52);
            lblCPHWelcone2.Margin = new Padding(4, 0, 4, 0);
            lblCPHWelcone2.Name = "lblCPHWelcone2";
            lblCPHWelcone2.Size = new Size(746, 33);
            lblCPHWelcone2.TabIndex = 1;
            lblCPHWelcone2.Text = "The phrase that will help you to change your password if needed.";
            // 
            // btnCPHConfirm
            // 
            btnCPHConfirm.Location = new Point(442, 197);
            btnCPHConfirm.Name = "btnCPHConfirm";
            btnCPHConfirm.Size = new Size(130, 65);
            btnCPHConfirm.TabIndex = 2;
            btnCPHConfirm.Text = "Confirm";
            btnCPHConfirm.UseVisualStyleBackColor = true;
            btnCPHConfirm.Click += btnCPHConfirm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(647, 197);
            button2.Name = "button2";
            button2.Size = new Size(130, 65);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCPHPassword
            // 
            txtCPHPassword.Location = new Point(442, 150);
            txtCPHPassword.Margin = new Padding(4);
            txtCPHPassword.MaxLength = 20;
            txtCPHPassword.Name = "txtCPHPassword";
            txtCPHPassword.PasswordChar = '*';
            txtCPHPassword.Size = new Size(335, 40);
            txtCPHPassword.TabIndex = 1;
            // 
            // PasswordHelperChangeForm
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 341);
            Controls.Add(button2);
            Controls.Add(btnCPHConfirm);
            Controls.Add(lblCPHPassword);
            Controls.Add(lblCPHName);
            Controls.Add(lblCPHWelcone2);
            Controls.Add(lblCPHWelcone1);
            Controls.Add(txtCPHPassword);
            Controls.Add(txtCPHNewHelper);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "PasswordHelperChangeForm";
            Text = "Your To Do List - Change Password Helper";
            Load += PasswordHelperChangeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPHNewHelper;
        private Label lblCPHWelcone1;
        private Label lblCPHName;
        private Label lblCPHPassword;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label lblCPHWelcone2;
        private Button btnCPHConfirm;
        private Button button2;
        private TextBox txtCPHPassword;
    }
}