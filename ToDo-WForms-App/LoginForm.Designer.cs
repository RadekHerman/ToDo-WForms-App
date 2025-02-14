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
            txtLogUsername = new TextBox();
            txtLogPassword = new TextBox();
            btnLogin = new Button();
            btnOpenRegisterForm = new Button();
            lblLoginUsername = new Label();
            lblLoginPassword = new Label();
            lblRegister = new Label();
            lblLoginWelcome = new Label();
            SuspendLayout();
            // 
            // txtLogUsername
            // 
            txtLogUsername.Location = new Point(228, 80);
            txtLogUsername.Margin = new Padding(4);
            txtLogUsername.Name = "txtLogUsername";
            txtLogUsername.Size = new Size(287, 40);
            txtLogUsername.TabIndex = 0;
            // 
            // txtLogPassword
            // 
            txtLogPassword.Location = new Point(228, 149);
            txtLogPassword.Margin = new Padding(4);
            txtLogPassword.Name = "txtLogPassword";
            txtLogPassword.Size = new Size(287, 40);
            txtLogPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(300, 215);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(168, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnOpenRegisterForm
            // 
            btnOpenRegisterForm.Location = new Point(300, 286);
            btnOpenRegisterForm.Margin = new Padding(4);
            btnOpenRegisterForm.Name = "btnOpenRegisterForm";
            btnOpenRegisterForm.Size = new Size(168, 45);
            btnOpenRegisterForm.TabIndex = 3;
            btnOpenRegisterForm.Text = "Register";
            btnOpenRegisterForm.UseVisualStyleBackColor = true;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Location = new Point(29, 80);
            lblLoginUsername.Margin = new Padding(4, 0, 4, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(191, 33);
            lblLoginUsername.TabIndex = 4;
            lblLoginUsername.Text = "Enter Username";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(29, 156);
            lblLoginPassword.Margin = new Padding(4, 0, 4, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(188, 33);
            lblLoginPassword.TabIndex = 5;
            lblLoginPassword.Text = "Enter Password";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(29, 292);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(256, 33);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Do Not Have Accout?";
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.AutoSize = true;
            lblLoginWelcome.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginWelcome.Location = new Point(53, 18);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(420, 36);
            lblLoginWelcome.TabIndex = 7;
            lblLoginWelcome.Text = "Welcome To Your To-Do App!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 371);
            Controls.Add(lblLoginWelcome);
            Controls.Add(lblRegister);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(btnOpenRegisterForm);
            Controls.Add(btnLogin);
            Controls.Add(txtLogPassword);
            Controls.Add(txtLogUsername);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Login";
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
    }
}
