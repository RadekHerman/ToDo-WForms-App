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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonLogin = new Button();
            buttonRegister = new Button();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRegister = new Label();
            labelWelcome = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 80);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 40);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 149);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 40);
            textBox2.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogin.Location = new Point(300, 215);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(168, 45);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(300, 286);
            buttonRegister.Margin = new Padding(4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(168, 45);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(29, 80);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(191, 33);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "Enter Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(29, 156);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(188, 33);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Enter Password";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Location = new Point(29, 292);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(256, 33);
            labelRegister.TabIndex = 6;
            labelRegister.Text = "Do Not Have Accout?";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(53, 18);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(420, 36);
            labelWelcome.TabIndex = 7;
            labelWelcome.Text = "Welcome To Your To-Do App!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 371);
            Controls.Add(labelWelcome);
            Controls.Add(labelRegister);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonLogin;
        private Button buttonRegister;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelRegister;
        private Label labelWelcome;
    }
}
