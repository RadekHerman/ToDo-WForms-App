namespace ToDo_WForms_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
