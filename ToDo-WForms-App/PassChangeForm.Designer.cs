namespace ToDo_WForms_App
{
    partial class PassChangeForm
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
            btnPassChangeConfirm = new Button();
            lblPCUsername = new Label();
            lblPCNewPassword = new Label();
            lblPCRepeatPassword = new Label();
            lblPCPassHelper = new Label();
            label5 = new Label();
            txtCPUsername = new TextBox();
            tztPCPassHelper = new TextBox();
            txtCPNewPassword = new TextBox();
            txtCPRepeatPassword = new TextBox();
            SuspendLayout();
            // 
            // btnPassChangeConfirm
            // 
            btnPassChangeConfirm.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPassChangeConfirm.Location = new Point(196, 266);
            btnPassChangeConfirm.Margin = new Padding(4);
            btnPassChangeConfirm.Name = "btnPassChangeConfirm";
            btnPassChangeConfirm.Size = new Size(107, 32);
            btnPassChangeConfirm.TabIndex = 0;
            btnPassChangeConfirm.Text = "Confirm";
            btnPassChangeConfirm.UseVisualStyleBackColor = true;
            btnPassChangeConfirm.Click += btnPassChangeConfirm_Click;
            // 
            // lblPCUsername
            // 
            lblPCUsername.AutoSize = true;
            lblPCUsername.Location = new Point(30, 68);
            lblPCUsername.Name = "lblPCUsername";
            lblPCUsername.Size = new Size(88, 21);
            lblPCUsername.TabIndex = 1;
            lblPCUsername.Text = "Username:";
            // 
            // lblPCNewPassword
            // 
            lblPCNewPassword.AutoSize = true;
            lblPCNewPassword.Location = new Point(30, 109);
            lblPCNewPassword.Name = "lblPCNewPassword";
            lblPCNewPassword.Size = new Size(127, 21);
            lblPCNewPassword.TabIndex = 2;
            lblPCNewPassword.Text = "New Password:";
            // 
            // lblPCRepeatPassword
            // 
            lblPCRepeatPassword.AutoSize = true;
            lblPCRepeatPassword.Location = new Point(30, 153);
            lblPCRepeatPassword.Name = "lblPCRepeatPassword";
            lblPCRepeatPassword.Size = new Size(145, 21);
            lblPCRepeatPassword.TabIndex = 3;
            lblPCRepeatPassword.Text = "Repeat Password:";
            // 
            // lblPCPassHelper
            // 
            lblPCPassHelper.AutoSize = true;
            lblPCPassHelper.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblPCPassHelper.Location = new Point(30, 194);
            lblPCPassHelper.Name = "lblPCPassHelper";
            lblPCPassHelper.Size = new Size(164, 21);
            lblPCPassHelper.TabIndex = 4;
            lblPCPassHelper.Text = "A place in the word:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 25);
            label5.Name = "label5";
            label5.Size = new Size(385, 21);
            label5.TabIndex = 5;
            label5.Text = "Please fill out the boxes to change your password.";
            // 
            // txtCPUsername
            // 
            txtCPUsername.Location = new Point(196, 66);
            txtCPUsername.Name = "txtCPUsername";
            txtCPUsername.Size = new Size(213, 29);
            txtCPUsername.TabIndex = 6;
            // 
            // tztPCPassHelper
            // 
            tztPCPassHelper.Location = new Point(196, 186);
            tztPCPassHelper.Name = "tztPCPassHelper";
            tztPCPassHelper.Size = new Size(213, 29);
            tztPCPassHelper.TabIndex = 6;
            // 
            // txtCPNewPassword
            // 
            txtCPNewPassword.Location = new Point(196, 101);
            txtCPNewPassword.Name = "txtCPNewPassword";
            txtCPNewPassword.PasswordChar = '*';
            txtCPNewPassword.Size = new Size(213, 29);
            txtCPNewPassword.TabIndex = 6;
            // 
            // txtCPRepeatPassword
            // 
            txtCPRepeatPassword.Location = new Point(196, 145);
            txtCPRepeatPassword.Name = "txtCPRepeatPassword";
            txtCPRepeatPassword.PasswordChar = '*';
            txtCPRepeatPassword.Size = new Size(213, 29);
            txtCPRepeatPassword.TabIndex = 6;
            // 
            // PassChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 340);
            Controls.Add(txtCPRepeatPassword);
            Controls.Add(tztPCPassHelper);
            Controls.Add(txtCPNewPassword);
            Controls.Add(txtCPUsername);
            Controls.Add(label5);
            Controls.Add(lblPCPassHelper);
            Controls.Add(lblPCRepeatPassword);
            Controls.Add(lblPCNewPassword);
            Controls.Add(lblPCUsername);
            Controls.Add(btnPassChangeConfirm);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "PassChangeForm";
            Text = "PassChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPassChangeConfirm;
        private Label lblPCUsername;
        private Label lblPCNewPassword;
        private Label lblPCRepeatPassword;
        private Label lblPCPassHelper;
        private Label label5;
        private TextBox txtCPUsername;
        private TextBox tztPCPassHelper;
        private TextBox txtCPNewPassword;
        private TextBox txtCPRepeatPassword;
    }
}