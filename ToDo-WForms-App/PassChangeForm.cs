
using System.Data;

namespace ToDo_WForms_App
{
    public partial class PassChangeForm : Form
    {
        public PassChangeForm()
        {
            InitializeComponent();
            txtPCUsername.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a control key, letter, or digit, or whitespace
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                // Cancel the input
                e.Handled = true;
            }
        }

        private void btnCPCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Operation Canceled.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPassChangeConfirm_Click(object sender, EventArgs e)
        {
           

            if ((!string.IsNullOrWhiteSpace(txtPCUsername.Text)) && (!string.IsNullOrWhiteSpace(txtPCNewPassword.Text)) && (!string.IsNullOrWhiteSpace(txtPCRepeatPassword.Text)) && (!string.IsNullOrWhiteSpace(txtPCPassHelper.Text)))
            {
                if (txtPCNewPassword.Text == txtPCRepeatPassword.Text)
                {
                    if (ChangePassword(txtPCUsername.Text, txtPCNewPassword.Text, txtPCPassHelper.Text))
                    {
                        MessageBox.Show("Your password has been changed succesfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, wrong data! Username or 'a place in the word' are not correct!");
                    }
                }
                else
                {
                    MessageBox.Show("The passwords in the boxes do not match!");
                }
            }
            else
            {
                MessageBox.Show("To chage the password all the boxes need to be filled in.");
            }
        }

        private bool ChangePassword(string username, string newPassword, string passHelper)
        {
            using (var context = new ToDoDbContext())
            {
                var userID = context.Users
                    .Where(u => u.Username == username)
                    .Select(u => u.Id)
                    .FirstOrDefault();

                passHelper = passHelper.Trim();

                if (userID == 0) {return false;}
                else
                {
                    var storedPassHelper = context.Users
                        .Where(u => u.Id == userID)
                        .Select(u => u.PassChangeHelper)
                        .FirstOrDefault();

                    if (passHelper != storedPassHelper) {return false; }
                    else
                    {
                        var newHashPassword = PasswordHelper.HashPassword(newPassword);
                        var user = context.Users.FirstOrDefault(u => u.Id == userID);

                        if (user != null)
                        {
                            user.Password = newHashPassword;
                            context.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }            
                }
            }
        }
    }
}
