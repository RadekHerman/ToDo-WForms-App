namespace ToDo_WForms_App
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            txtRegUsername.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            //txtRegPassword.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            //txtRegConfirmPass.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a control key, letter, or digit
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                // Cancel the input
                e.Handled = true;
            }
        }

        private void btnOpenLoginForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtRegUsername.Text) && (txtRegUsername.Text.Length >= 3)) && (!string.IsNullOrWhiteSpace(txtRegPassword.Text) && txtRegPassword.Text.Length >= 3) && (!string.IsNullOrWhiteSpace(txtRegConfirmPass.Text)) && ((!string.IsNullOrWhiteSpace(txtPassHelper.Text) && txtPassHelper.Text.Length >= 3)))
            {
                if (txtRegPassword.Text == txtRegConfirmPass.Text)
                {
                    if (createUser(txtRegUsername.Text, txtRegPassword.Text, txtPassHelper.Text))
                    {
                        MessageBox.Show("Your Account Has Been Created! Please Login!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry! Please change the username. The username already exist!");
                    }
                }
                else
                {
                    MessageBox.Show("The Passwords Do Not Match!");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid inputs in all the boxes, minimum 3 charcters!");
            }
        }

        private bool createUser(string username, string password, string passHelper)
        {
            using (var context = new ToDoDbContext())
            {
                //var users = context.Users.ToList();
                //bool userExists = users.Any(u => u.Username == username);
                bool userExists = context.Users.Any(u => u.Username == username);

                passHelper = passHelper.Trim();

                if (userExists) { return false; }
                else
                {
                    string hashedPassword = PasswordHelper.HashPassword(password);
                    var newUser = new User
                    {
                        Username = username,
                        Password = hashedPassword,
                        PassChangeHelper = passHelper
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();
                    return true;
                }
            }
        }
    }
}
