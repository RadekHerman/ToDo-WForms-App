using ToDo_WForms_App.Models;
using ToDo_WForms_App.Utilities;

namespace ToDo_WForms_App
{
    public partial class PasswordHelperChangeForm : Form
    {
        public PasswordHelperChangeForm()
        {
            InitializeComponent();
        }

        private void PasswordHelperChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCPHConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCPHNewHelper.Text) && (txtCPHNewHelper.Text.Length >= 3) && (!string.IsNullOrWhiteSpace(txtCPHPassword.Text)))
            {
                using (var context = new ToDoDbContext())
                {
                    string newHelper = txtCPHNewHelper.Text.Trim();
                    var user = context.Users.FirstOrDefault(u => u.Id == UserSession.UserId);

                    if (user != null)
                    {
                        if (PasswordHash.VerifyPassword(txtCPHPassword.Text, user.Password))
                        {
                            user.PassChangeHelper = newHelper;
                            context.SaveChanges();
                            MessageBox.Show("The data has been changed");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password, please try again.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the boxes with valid data and minimum 3 characters.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
