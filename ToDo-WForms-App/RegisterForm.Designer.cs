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
            SuspendLayout();
            // 
            // lblRegUsername
            // 
            lblRegUsername.AutoSize = true;
            lblRegUsername.Location = new Point(12, 70);
            lblRegUsername.Name = "lblRegUsername";
            lblRegUsername.Size = new Size(167, 27);
            lblRegUsername.TabIndex = 0;
            lblRegUsername.Text = "Enter Username";
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.Location = new Point(12, 126);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(163, 27);
            lblRegPassword.TabIndex = 1;
            lblRegPassword.Text = "Enter Password";
            // 
            // lblRegConfirmPass
            // 
            lblRegConfirmPass.AutoSize = true;
            lblRegConfirmPass.Location = new Point(12, 189);
            lblRegConfirmPass.Name = "lblRegConfirmPass";
            lblRegConfirmPass.Size = new Size(190, 27);
            lblRegConfirmPass.TabIndex = 2;
            lblRegConfirmPass.Text = "Confirm Password";
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(243, 63);
            txtRegUsername.MaxLength = 20;
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(299, 34);
            txtRegUsername.TabIndex = 3;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(243, 119);
            txtRegPassword.MaxLength = 20;
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(299, 34);
            txtRegPassword.TabIndex = 4;
            // 
            // txtRegConfirmPass
            // 
            txtRegConfirmPass.Location = new Point(243, 182);
            txtRegConfirmPass.MaxLength = 20;
            txtRegConfirmPass.Name = "txtRegConfirmPass";
            txtRegConfirmPass.PasswordChar = '*';
            txtRegConfirmPass.Size = new Size(299, 34);
            txtRegConfirmPass.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(317, 246);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(136, 47);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Confirm";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnOpenLoginForm
            // 
            btnOpenLoginForm.Location = new Point(317, 321);
            btnOpenLoginForm.Name = "btnOpenLoginForm";
            btnOpenLoginForm.Size = new Size(136, 44);
            btnOpenLoginForm.TabIndex = 7;
            btnOpenLoginForm.Text = "Login";
            btnOpenLoginForm.UseVisualStyleBackColor = true;
            btnOpenLoginForm.Click += btnOpenLoginForm_Click;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.Location = new Point(12, 295);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(243, 27);
            lblHaveAccount.TabIndex = 8;
            lblHaveAccount.Text = "Already Have Account?";
            // 
            // lblRegWelcone
            // 
            lblRegWelcone.AutoSize = true;
            lblRegWelcone.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegWelcone.Location = new Point(118, 9);
            lblRegWelcone.Name = "lblRegWelcone";
            lblRegWelcone.Size = new Size(292, 31);
            lblRegWelcone.TabIndex = 9;
            lblRegWelcone.Text = "Register To To-Do App!";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 398);
            Controls.Add(lblRegWelcone);
            Controls.Add(lblHaveAccount);
            Controls.Add(btnOpenLoginForm);
            Controls.Add(btnRegister);
            Controls.Add(txtRegConfirmPass);
            Controls.Add(txtRegPassword);
            Controls.Add(txtRegUsername);
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
    }
}