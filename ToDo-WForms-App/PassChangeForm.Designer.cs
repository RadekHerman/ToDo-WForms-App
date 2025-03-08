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
            txtPCUsername = new TextBox();
            txtPCPassHelper = new TextBox();
            txtPCNewPassword = new TextBox();
            txtPCRepeatPassword = new TextBox();
            btnCPCancel = new Button();
            SuspendLayout();
            // 
            // btnPassChangeConfirm
            // 
            btnPassChangeConfirm.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPassChangeConfirm.Location = new Point(196, 256);
            btnPassChangeConfirm.Margin = new Padding(4);
            btnPassChangeConfirm.Name = "btnPassChangeConfirm";
            btnPassChangeConfirm.Size = new Size(129, 63);
            btnPassChangeConfirm.TabIndex = 4;
            btnPassChangeConfirm.Text = "Confirm";
            btnPassChangeConfirm.UseVisualStyleBackColor = true;
            btnPassChangeConfirm.Click += btnPassChangeConfirm_Click;
            // 
            // lblPCUsername
            // 
            lblPCUsername.AutoSize = true;
            lblPCUsername.Location = new Point(31, 87);
            lblPCUsername.Name = "lblPCUsername";
            lblPCUsername.Size = new Size(138, 33);
            lblPCUsername.TabIndex = 1;
            lblPCUsername.Text = "Username:";
            // 
            // lblPCNewPassword
            // 
            lblPCNewPassword.AutoSize = true;
            lblPCNewPassword.Location = new Point(31, 133);
            lblPCNewPassword.Name = "lblPCNewPassword";
            lblPCNewPassword.Size = new Size(191, 33);
            lblPCNewPassword.TabIndex = 2;
            lblPCNewPassword.Text = "New Password:";
            // 
            // lblPCRepeatPassword
            // 
            lblPCRepeatPassword.AutoSize = true;
            lblPCRepeatPassword.Location = new Point(31, 174);
            lblPCRepeatPassword.Name = "lblPCRepeatPassword";
            lblPCRepeatPassword.Size = new Size(216, 33);
            lblPCRepeatPassword.TabIndex = 3;
            lblPCRepeatPassword.Text = "Repeat Password:";
            // 
            // lblPCPassHelper
            // 
            lblPCPassHelper.AutoSize = true;
            lblPCPassHelper.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblPCPassHelper.Location = new Point(31, 216);
            lblPCPassHelper.Name = "lblPCPassHelper";
            lblPCPassHelper.Size = new Size(252, 34);
            lblPCPassHelper.TabIndex = 4;
            lblPCPassHelper.Text = "A place in the word:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 20);
            label5.Name = "label5";
            label5.Size = new Size(576, 33);
            label5.TabIndex = 5;
            label5.Text = "Please fill out the boxes to change your password.";
            // 
            // txtPCUsername
            // 
            txtPCUsername.Location = new Point(196, 84);
            txtPCUsername.MaxLength = 20;
            txtPCUsername.Name = "txtPCUsername";
            txtPCUsername.Size = new Size(302, 40);
            txtPCUsername.TabIndex = 0;
            // 
            // txtPCPassHelper
            // 
            txtPCPassHelper.Location = new Point(196, 208);
            txtPCPassHelper.MaxLength = 100;
            txtPCPassHelper.Name = "txtPCPassHelper";
            txtPCPassHelper.Size = new Size(302, 40);
            txtPCPassHelper.TabIndex = 3;
            // 
            // txtPCNewPassword
            // 
            txtPCNewPassword.Location = new Point(196, 125);
            txtPCNewPassword.MaxLength = 20;
            txtPCNewPassword.Name = "txtPCNewPassword";
            txtPCNewPassword.PasswordChar = '*';
            txtPCNewPassword.Size = new Size(302, 40);
            txtPCNewPassword.TabIndex = 1;
            // 
            // txtPCRepeatPassword
            // 
            txtPCRepeatPassword.Location = new Point(196, 166);
            txtPCRepeatPassword.Name = "txtPCRepeatPassword";
            txtPCRepeatPassword.PasswordChar = '*';
            txtPCRepeatPassword.Size = new Size(302, 40);
            txtPCRepeatPassword.TabIndex = 2;
            // 
            // btnCPCancel
            // 
            btnCPCancel.Location = new Point(369, 257);
            btnCPCancel.Name = "btnCPCancel";
            btnCPCancel.Size = new Size(129, 62);
            btnCPCancel.TabIndex = 5;
            btnCPCancel.Text = "Cancel";
            btnCPCancel.UseVisualStyleBackColor = true;
            btnCPCancel.Click += btnCPCancel_Click;
            // 
            // PassChangeForm
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 344);
            Controls.Add(btnCPCancel);
            Controls.Add(txtPCRepeatPassword);
            Controls.Add(txtPCPassHelper);
            Controls.Add(txtPCNewPassword);
            Controls.Add(txtPCUsername);
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
        private TextBox txtPCUsername;
        private TextBox txtPCPassHelper;
        private TextBox txtPCNewPassword;
        private TextBox txtPCRepeatPassword;
        private Button btnCPCancel;
    }
}