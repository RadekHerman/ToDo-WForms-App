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
        private readonly Post _post;
        public EditPostForm(Post post)
        {
            InitializeComponent();
            dateEdit.Format = DateTimePickerFormat.Custom;
            dateEdit.CustomFormat = "dd/MM/yyyy";
            timeEdit.Format = DateTimePickerFormat.Custom;
            timeEdit.CustomFormat = "HH:mm";
            _post = post;
            FillOutBoxes(_post);
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
                timeEdit.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                              timeOnly.Hours, timeOnly.Minutes, timeOnly.Seconds);
            }
            else
            {
                timeEdit.Value = DateTime.Now; // Default value if null
            }

        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEditRevert_Click(object sender, EventArgs e)
        {
            FillOutBoxes(_post);
        }

        private void btnEditAddPost_Click(object sender, EventArgs e)
        {
            int userId = _post.UserId;
            int postId = _post.Id;
            string subject = txtSubjectEdit.Text;
            string content = txtContentEdit.Text;
            DateTime dateTodo = dateEdit.Value.Date;
            TimeSpan? hourTodo = timeEdit.Value.TimeOfDay;

            if ((string.IsNullOrWhiteSpace(subject)) || (subject == "Subject"))
            {
                MessageBox.Show("Subject is required to add a new task.");
                return;
            }
            using (var context = new ToDoDbContext())
            {
                var updatePost = context.Posts.FirstOrDefault(p => p.UserId == userId && p.Id == postId);

                if (updatePost != null) 
                {
                    updatePost.Subject = subject;
                    updatePost.Content = content;
                    updatePost.DateTodo = dateTodo;
                    updatePost.HourTodo = hourTodo;
         
                };
                context.SaveChanges();

                MessageBox.Show("Post updated successfully!", "Success", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
