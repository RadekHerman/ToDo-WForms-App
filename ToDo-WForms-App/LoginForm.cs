using System.Drawing.Text;

namespace ToDo_WForms_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtLogUsername.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            //txtLogPassword.KeyPress += new KeyPressEventHandler(txt_KeyPress);
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

        private void btnOpenRegisterForm_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtLogUsername.Text)) && (!string.IsNullOrWhiteSpace(txtLogPassword.Text)))
            {
                if (validateUser(txtLogUsername.Text, txtLogPassword.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    MessageBox.Show("Login successful!");
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

        private bool validateUser(string username, string password)
        {
            using (var context = new ToDoDbContext())
            {
                bool userExists = context.Users.Any(u => u.Username == username);
                if (!userExists) { return false; }
                else
                {
                    return true;
                }
            }
        }
    }
}
