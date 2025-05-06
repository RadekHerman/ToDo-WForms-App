namespace ToDo_WForms_App
{
    partial class UsernameChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsernameChangeForm));
            lblNUNewUsername = new Label();
            textBox1 = new TextBox();
            lblNUPassword = new Label();
            txtNUNewUsername = new TextBox();
            txtNUPassword = new TextBox();
            btnNUConfirm = new Button();
            btnNUCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNUNewUsername
            // 
            lblNUNewUsername.AutoSize = true;
            lblNUNewUsername.Location = new Point(32, 67);
            lblNUNewUsername.Margin = new Padding(4, 0, 4, 0);
            lblNUNewUsername.Name = "lblNUNewUsername";
            lblNUNewUsername.Size = new Size(127, 21);
            lblNUNewUsername.TabIndex = 0;
            lblNUNewUsername.Text = "New Username:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(948, 239);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 29);
            textBox1.TabIndex = 1;
            // 
            // lblNUPassword
            // 
            lblNUPassword.AutoSize = true;
            lblNUPassword.Location = new Point(32, 133);
            lblNUPassword.Margin = new Padding(4, 0, 4, 0);
            lblNUPassword.Name = "lblNUPassword";
            lblNUPassword.Size = new Size(88, 21);
            lblNUPassword.TabIndex = 0;
            lblNUPassword.Text = "Password:";
            // 
            // txtNUNewUsername
            // 
            txtNUNewUsername.Location = new Point(246, 60);
            txtNUNewUsername.MaxLength = 20;
            txtNUNewUsername.Name = "txtNUNewUsername";
            txtNUNewUsername.Size = new Size(316, 29);
            txtNUNewUsername.TabIndex = 0;
            // 
            // txtNUPassword
            // 
            txtNUPassword.Location = new Point(246, 126);
            txtNUPassword.MaxLength = 20;
            txtNUPassword.Name = "txtNUPassword";
            txtNUPassword.PasswordChar = '*';
            txtNUPassword.Size = new Size(316, 29);
            txtNUPassword.TabIndex = 1;
            // 
            // btnNUConfirm
            // 
            btnNUConfirm.Location = new Point(246, 193);
            btnNUConfirm.Name = "btnNUConfirm";
            btnNUConfirm.Size = new Size(139, 63);
            btnNUConfirm.TabIndex = 2;
            btnNUConfirm.Text = "Confirm";
            btnNUConfirm.UseVisualStyleBackColor = true;
            btnNUConfirm.Click += btnNUConfirm_Click;
            // 
            // btnNUCancel
            // 
            btnNUCancel.Location = new Point(423, 193);
            btnNUCancel.Name = "btnNUCancel";
            btnNUCancel.Size = new Size(139, 63);
            btnNUCancel.TabIndex = 3;
            btnNUCancel.Text = "Cancel";
            btnNUCancel.UseVisualStyleBackColor = true;
            btnNUCancel.Click += btnNUCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 21);
            label1.TabIndex = 4;
            label1.Text = "Now you can change your username.";
            // 
            // UsernameChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 313);
            Controls.Add(label1);
            Controls.Add(btnNUCancel);
            Controls.Add(btnNUConfirm);
            Controls.Add(txtNUPassword);
            Controls.Add(txtNUNewUsername);
            Controls.Add(textBox1);
            Controls.Add(lblNUPassword);
            Controls.Add(lblNUNewUsername);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "UsernameChangeForm";
            Text = "Your To Do List - Change Username";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNUNewUsername;
        private TextBox textBox1;
        private Label lblNUPassword;
        private TextBox txtNUNewUsername;
        private TextBox txtNUPassword;
        private Button btnNUConfirm;
        private Button btnNUCancel;
        private Label label1;
    }
}