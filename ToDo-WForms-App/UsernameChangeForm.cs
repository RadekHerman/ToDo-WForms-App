using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ToDo_WForms_App
{
    public partial class UsernameChangeForm : Form
    {
        
        public UsernameChangeForm()
        {
            InitializeComponent();
            txtNUNewUsername.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a control key, letter, or digit or ' '
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                // Cancel the input
                e.Handled = true;
            }
        }

        private void btnNUCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the Username has not been changed.");
            this.DialogResult = DialogResult.OK;
        }

        private void btnNUConfirm_Click(object sender, EventArgs e)
        {
            if (((!string.IsNullOrWhiteSpace(txtNUNewUsername.Text)) && (txtNUNewUsername.Text.Length >= 3)) && ((!string.IsNullOrWhiteSpace(txtNUPassword.Text))))
            {
                string newUsername = txtNUNewUsername.Text;
                using (var context = new ToDoDbContext())
                {
                    bool userExists = context.Users.Any(u => u.Username == newUsername);

                    if (userExists)
                    {
                        MessageBox.Show("Please choose a different Username!");
                    }
                    else
                    {
                        var user = context.Users.FirstOrDefault(u => u.Id == UserSession.UserId);

                        if (user != null)
                        {
                            if (PasswordHash.VerifyPassword(txtNUPassword.Text, user.Password))
                            {
                                user.Username = newUsername;
                                context.SaveChanges();
                                MessageBox.Show("The Username has been changed");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Wrong password please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, please try again.");
                        }
                    }
                }                        
            }
            else
            {
                Console.WriteLine("Invalid data. Please fill in the boxes with minimum 3 chacters.");
            }
        }
    }
}
