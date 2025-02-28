using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_WForms_App
{
    public partial class EditPostForm : Form
    {
        
        public EditPostForm(Post post)
        {
            InitializeComponent();
            dateEdit.Format = DateTimePickerFormat.Custom;
            dateEdit.CustomFormat = "dd/MM/yyyy";
            hourEdit.Format = DateTimePickerFormat.Custom;
            hourEdit.CustomFormat = "HH:mm";
            FillOutBoxes(post);
        }

        private void FillOutBoxes(Post post)
        {
            txtSubjectEdit.Text = post.Subject;
            txtContentEdit.Text = post.Content;
            dateEdit.Value = post.DateTodo;


            if (post.HourTodo.HasValue)
            {
                // Combine the time component with a default date (e.g., today)
                var timeOnly = post.HourTodo.Value;
                hourEdit.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                              timeOnly.Hours, timeOnly.Minutes, timeOnly.Seconds);
            }
            else
            {
                hourEdit.Value = DateTime.Now; // Default value if null
            }

        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEditClear_Click(object sender, EventArgs e)
        {
            txtSubjectEdit.Clear();
            txtContentEdit.Clear();
            dateEdit.Value = DateTime.Now;
            hourEdit.Value = DateTime.Now;
        }
    }
}
