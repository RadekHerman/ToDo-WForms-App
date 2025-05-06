namespace ToDo_WForms_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogUsername = new TextBox();
            txtLogPassword = new TextBox();
            btnLogin = new Button();
            btnOpenRegisterForm = new Button();
            lblLoginUsername = new Label();
            lblLoginPassword = new Label();
            lblRegister = new Label();
            lblLoginWelcome = new Label();
            lblForgotPass = new Label();
            btnForgotPass = new Button();
            SuspendLayout();
            // 
            // txtLogUsername
            // 
            txtLogUsername.Location = new Point(212, 84);
            txtLogUsername.Margin = new Padding(4);
            txtLogUsername.MaxLength = 20;
            txtLogUsername.Name = "txtLogUsername";
            txtLogUsername.Size = new Size(287, 29);
            txtLogUsername.TabIndex = 0;
            // 
            // txtLogPassword
            // 
            txtLogPassword.Location = new Point(212, 132);
            txtLogPassword.Margin = new Padding(4);
            txtLogPassword.MaxLength = 20;
            txtLogPassword.Name = "txtLogPassword";
            txtLogPassword.PasswordChar = '*';
            txtLogPassword.Size = new Size(287, 29);
            txtLogPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(276, 195);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(168, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOpenRegisterForm
            // 
            btnOpenRegisterForm.Location = new Point(276, 257);
            btnOpenRegisterForm.Margin = new Padding(4);
            btnOpenRegisterForm.Name = "btnOpenRegisterForm";
            btnOpenRegisterForm.Size = new Size(168, 45);
            btnOpenRegisterForm.TabIndex = 3;
            btnOpenRegisterForm.Text = "Register";
            btnOpenRegisterForm.UseVisualStyleBackColor = true;
            btnOpenRegisterForm.Click += btnOpenRegisterForm_Click;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Location = new Point(13, 87);
            lblLoginUsername.Margin = new Padding(4, 0, 4, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(128, 21);
            lblLoginUsername.TabIndex = 4;
            lblLoginUsername.Text = "Enter Username";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(13, 146);
            lblLoginPassword.Margin = new Padding(4, 0, 4, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(128, 21);
            lblLoginPassword.TabIndex = 5;
            lblLoginPassword.Text = "Enter Password";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(13, 269);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(176, 21);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Do Not Have Accout?";
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.AutoSize = true;
            lblLoginWelcome.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginWelcome.Location = new Point(12, 18);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(293, 25);
            lblLoginWelcome.TabIndex = 7;
            lblLoginWelcome.Text = "Welcome To Your To-Do App!";
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblForgotPass.Location = new Point(13, 325);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(150, 21);
            lblForgotPass.TabIndex = 6;
            lblForgotPass.Text = "Forgot Password?";
            // 
            // btnForgotPass
            // 
            btnForgotPass.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnForgotPass.Location = new Point(276, 313);
            btnForgotPass.Margin = new Padding(4);
            btnForgotPass.Name = "btnForgotPass";
            btnForgotPass.Size = new Size(168, 45);
            btnForgotPass.TabIndex = 3;
            btnForgotPass.Text = "Try this!";
            btnForgotPass.UseVisualStyleBackColor = true;
            btnForgotPass.Click += btnForgotPass_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 413);
            Controls.Add(lblLoginWelcome);
            Controls.Add(lblForgotPass);
            Controls.Add(lblRegister);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(btnForgotPass);
            Controls.Add(btnOpenRegisterForm);
            Controls.Add(btnLogin);
            Controls.Add(txtLogPassword);
            Controls.Add(txtLogUsername);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Your To Do List - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogUsername;
        private TextBox txtLogPassword;
        private Button btnLogin;
        private Button btnOpenRegisterForm;
        private Label lblLoginUsername;
        private Label lblLoginPassword;
        private Label lblRegister;
        private Label lblLoginWelcome;
        private Label lblForgotPass;
        private Button btnForgotPass;
    }
}
