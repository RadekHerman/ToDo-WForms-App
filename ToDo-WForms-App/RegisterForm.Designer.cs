namespace ToDo_WForms_App
{
    partial class RegisterForm
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
            lblRegUsername = new Label();
            lblRegPassword = new Label();
            lblRegConfirmPass = new Label();
            txtRegUsername = new TextBox();
            txtRegPassword = new TextBox();
            txtRegConfirmPass = new TextBox();
            btnRegister = new Button();
            btnOpenLoginForm = new Button();
            lblHaveAccount = new Label();
            lblRegWelcone = new Label();
            label1 = new Label();
            lblPasswordChangeHelper = new Label();
            txtPassHelper = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblRegUsername
            // 
            lblRegUsername.AutoSize = true;
            lblRegUsername.Location = new Point(12, 70);
            lblRegUsername.Name = "lblRegUsername";
            lblRegUsername.Size = new Size(132, 21);
            lblRegUsername.TabIndex = 0;
            lblRegUsername.Text = "Enter Username:";
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.Location = new Point(12, 126);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(132, 21);
            lblRegPassword.TabIndex = 1;
            lblRegPassword.Text = "Enter Password:";
            // 
            // lblRegConfirmPass
            // 
            lblRegConfirmPass.AutoSize = true;
            lblRegConfirmPass.Location = new Point(12, 189);
            lblRegConfirmPass.Name = "lblRegConfirmPass";
            lblRegConfirmPass.Size = new Size(155, 21);
            lblRegConfirmPass.TabIndex = 2;
            lblRegConfirmPass.Text = "Confirm Password:";
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(243, 63);
            txtRegUsername.MaxLength = 20;
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(299, 29);
            txtRegUsername.TabIndex = 0;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(243, 119);
            txtRegPassword.MaxLength = 20;
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(299, 29);
            txtRegPassword.TabIndex = 1;
            // 
            // txtRegConfirmPass
            // 
            txtRegConfirmPass.Location = new Point(243, 182);
            txtRegConfirmPass.MaxLength = 20;
            txtRegConfirmPass.Name = "txtRegConfirmPass";
            txtRegConfirmPass.PasswordChar = '*';
            txtRegConfirmPass.Size = new Size(299, 29);
            txtRegConfirmPass.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(317, 421);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(136, 47);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Confirm";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnOpenLoginForm
            // 
            btnOpenLoginForm.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOpenLoginForm.Location = new Point(317, 508);
            btnOpenLoginForm.Name = "btnOpenLoginForm";
            btnOpenLoginForm.Size = new Size(136, 44);
            btnOpenLoginForm.TabIndex = 5;
            btnOpenLoginForm.Text = "Login";
            btnOpenLoginForm.UseVisualStyleBackColor = true;
            btnOpenLoginForm.Click += btnOpenLoginForm_Click;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHaveAccount.Location = new Point(12, 514);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(189, 21);
            lblHaveAccount.TabIndex = 8;
            lblHaveAccount.Text = "Already Have Account?";
            // 
            // lblRegWelcone
            // 
            lblRegWelcone.AutoSize = true;
            lblRegWelcone.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegWelcone.Location = new Point(118, 9);
            lblRegWelcone.Name = "lblRegWelcone";
            lblRegWelcone.Size = new Size(234, 25);
            lblRegWelcone.TabIndex = 9;
            lblRegWelcone.Text = "Register To To-Do App!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 244);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 2;
            label1.Text = "Confirm Password";
            // 
            // lblPasswordChangeHelper
            // 
            lblPasswordChangeHelper.Location = new Point(12, 244);
            lblPasswordChangeHelper.Name = "lblPasswordChangeHelper";
            lblPasswordChangeHelper.Size = new Size(372, 43);
            lblPasswordChangeHelper.TabIndex = 2;
            lblPasswordChangeHelper.Text = "Please name a place in a world:";
            // 
            // txtPassHelper
            // 
            txtPassHelper.Location = new Point(243, 290);
            txtPassHelper.MaxLength = 100;
            txtPassHelper.Name = "txtPassHelper";
            txtPassHelper.Size = new Size(299, 29);
            txtPassHelper.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(530, 76);
            label2.TabIndex = 2;
            label2.Text = "Remember your answer, it will help you to change your password if you forget it!";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 580);
            Controls.Add(lblRegWelcone);
            Controls.Add(lblHaveAccount);
            Controls.Add(btnOpenLoginForm);
            Controls.Add(btnRegister);
            Controls.Add(txtPassHelper);
            Controls.Add(txtRegConfirmPass);
            Controls.Add(txtRegPassword);
            Controls.Add(txtRegUsername);
            Controls.Add(label2);
            Controls.Add(lblPasswordChangeHelper);
            Controls.Add(label1);
            Controls.Add(lblRegConfirmPass);
            Controls.Add(lblRegPassword);
            Controls.Add(lblRegUsername);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegUsername;
        private Label lblRegPassword;
        private Label lblRegConfirmPass;
        private TextBox txtRegUsername;
        private TextBox txtRegPassword;
        private TextBox txtRegConfirmPass;
        private Button btnRegister;
        private Button btnOpenLoginForm;
        private Label lblHaveAccount;
        private Label lblRegWelcone;
        private Label label1;
        private Label lblPasswordChangeHelper;
        private TextBox textBox1;
        private TextBox txtPassHelper;
        private Label label2;
    }
}