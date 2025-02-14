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
            RegisterForm form2 = new RegisterForm();
            this.Hide();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }

        }
    }
}
