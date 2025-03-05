using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ToDo_WForms_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtLogUsername.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            //txtLogPassword.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            this.KeyPreview = true; // Allows the form to detect key presses before controls
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a control key, letter, or digit
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                // Cancel the input
                e.Handled = true;
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void btnOpenRegisterForm_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                // clear data in txt boxes
                this.Controls.Clear();
                this.InitializeComponent();
                this.OnLoad(EventArgs.Empty);

                this.Show();

            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            PassChangeForm passChangeForm = new PassChangeForm();
            this.Hide();
            if (passChangeForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtLogUsername.Text)) && (!string.IsNullOrWhiteSpace(txtLogPassword.Text)))
            {
                if (IsValidUser(txtLogUsername.Text, txtLogPassword.Text))
                {
                    // set the logged-in user session id and username
                    using (var context = new ToDoDbContext())
                    {
                        var user = context.Users
                                          .FirstOrDefault(u => u.Username == txtLogUsername.Text);

                        if (user != null)
                        {
                            UserSession.UserId = user.Id;
                            UserSession.Username = user.Username;
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
            }
            else
            {
                MessageBox.Show("Invalid data! Username and Password are required!");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            using (var context = new ToDoDbContext())
            {
                var hashedPassword = context.Users
                    .Where(u => u.Username == username)
                    .Select(u => u.Password)
                    .FirstOrDefault();

                if (hashedPassword == null)
                    return false;

                //return bool
                return PasswordHelper.VerifyPassword(password, hashedPassword);
            }
        }


    }
}
