using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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
            if ((!string.IsNullOrWhiteSpace(txtRegUsername.Text) && (txtRegUsername.Text.Length >= 3)) && (!string.IsNullOrWhiteSpace(txtRegPassword.Text) && txtRegPassword.Text.Length >= 3) && (!string.IsNullOrWhiteSpace(txtRegConfirmPass.Text)))
            {
                if (txtRegPassword.Text == txtRegConfirmPass.Text)
                {
                    if (createUser(txtRegUsername.Text))
                    {
                        MessageBox.Show("The Accout Has Been Created!");
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
                MessageBox.Show("Please enter valid inputs, minimum 3 charcters!");
            }
        }

        private bool createUser(string username)
        {
            //connect to database and check if username exist, if retrun false
            // else add user to database
           
            return true;
        }
    }
}
