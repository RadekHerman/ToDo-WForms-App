using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ToDo_WForms_App
{
    public partial class ToDoMainForm : Form
    {
        private int loggedInUserId;
        private string loggedInUsername;

        public ToDoMainForm()
        {
            InitializeComponent();
            loggedInUserId = UserSession.UserId;
            loggedInUsername = UserSession.Username;
            lblWelcome.Text = $"Hello, {loggedInUsername}! Welcome to your TO DO LIST! Now you can create, edit and delete your tasks!";
            // MessageBox.Show($"user ID {loggedInUserId}, user name: {loggedInUsername}");
            dateInsert.Format = DateTimePickerFormat.Custom;
            dateInsert.CustomFormat = "dd/MM/yyyy";
            timeInsert.Format = DateTimePickerFormat.Custom;
            timeInsert.CustomFormat = "HH:mm";
        }

        private void ToDoMainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            AddEditAndDeleteButtons();
        }

        private void LoadData()
        {
            using (var context = new ToDoDbContext())
            {
                var posts = context.Posts
                    .Where(p => p.UserId == loggedInUserId)
                    .Select(p => new
                    {
                        p.Id,
                        p.DateCreated,
                        p.Subject,
                        p.Content,
                        DateTodo = p.DateTodo.ToString("dd/MM/yyyy"),
                        HourTodo = p.HourTodo.HasValue ? p.HourTodo.Value.ToString(@"hh\:mm") : "",
                    })
                    .ToList();

                dataGridView1.DataSource = posts;
                dataGridView1.Columns["Id"].Visible = false;
                FormatDataGridView();

                // reset values
                dataGridView1.Columns["DateCreated"].HeaderText = "Date Created";
                dataGridView1.Columns["Subject"].HeaderText = "Task Subject";
                dataGridView1.Columns["Content"].HeaderText = "Details";
                dataGridView1.Columns["DateTodo"].HeaderText = "Date To Do";
                dataGridView1.Columns["HourTodo"].HeaderText = "Hour To Do";
            }
        }

        private void FormatDataGridView()
        {
            dataGridView1.Columns["HourTodo"].DefaultCellStyle.Format = @"HH:mm";
            dataGridView1.Columns["DateTodo"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Content"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["DateTodo"].Width = 150;
            dataGridView1.Columns["HourTodo"].Width = 100;

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string subject = txtSubjectInsert.Text;
            string content = txtContentInsert.Text;
            DateTime dateTodo = dateInsert.Value.Date;
            TimeSpan? hourTodo = timeInsert.Value.TimeOfDay;

            if ((string.IsNullOrWhiteSpace(subject)) || (subject == "Subject"))
            {
                MessageBox.Show("Subject is required to add a new task.");
                return;
            }
            using (var context = new ToDoDbContext())
            {
                var newPost = new Post
                {
                    Subject = subject,
                    Content = content,
                    DateTodo = dateTodo,
                    HourTodo = hourTodo,
                    UserId = loggedInUserId,
                };
                context.Posts.Add(newPost);
                context.SaveChanges();

                //MessageBox.Show("Post added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                ClearData();
            }
        }

        private void ClearData()
        {
            txtSubjectInsert.Clear();
            txtContentInsert.Clear();
            dateInsert.Value = DateTime.Now;
            timeInsert.Value = DateTime.Now;
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        // add edit and delete buttons / columns

        private void AddEditAndDeleteButtons()
        {
            // Add Edit button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "Edit Task",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editButtonColumn);
            dataGridView1.Columns["EditButton"].Width = 100;


            // Add Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete Task",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButtonColumn);
            dataGridView1.Columns["DeleteButton"].Width = 100;
        }

        private void EditPost(int postId)
        {
            // Retrieve the post to edit
            using (var context = new ToDoDbContext())
            {
                var post = context.Posts.FirstOrDefault(p => p.Id == postId);

                if (post == null)
                {
                    MessageBox.Show("Post not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var editForm = new EditPostForm(post))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData(); // Reload data
                    }
                }
            }
        }

        private void DeletePost(int postId)
        {
            using (var context = new ToDoDbContext())
            {
                var post = context.Posts.FirstOrDefault(p => p.Id == postId);

                if (post == null)
                {
                    MessageBox.Show("Post not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete the post
                context.Posts.Remove(post);
                context.SaveChanges();

                MessageBox.Show("Post deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or an out-of-bounds index
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Check if the clicked column is the "Edit" button column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButton")
            {
                // Retrieve the post ID of the selected row
                int postId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Call your method to edit the post
                EditPost(postId);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                // Retrieve the post ID of the selected row
                int postId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Confirm and delete the post
                if (MessageBox.Show("Are you sure you want to delete this post?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeletePost(postId);
                    LoadData(); // Reload data after deletion
                }
            }
        }

        private void logoutStripMenu_Click(object sender, EventArgs e)
        {
            var currentProcess = Process.GetCurrentProcess();

            // Start a new instance of the application
            Process.Start(currentProcess.MainModule.FileName);

            // Exit the current instance
            Environment.Exit(0);

        }

        private void changePasswordStripMenu_Click(object sender, EventArgs e)
        {
            using (var passwordChangeForm = new PassChangeForm())
            {
                passwordChangeForm.ShowDialog();
            }
            
        }

        private void changeUsernameStripMenu_Click(object sender, EventArgs e)
        {
            using (var newUsernameChangeForm = new UsernameChangeForm())
            {               
                newUsernameChangeForm.ShowDialog();

                UpdateLoggedUsername();
                lblWelcome.Text = $"Hello, {loggedInUsername}! Welcome to your TO DO LIST! Now you can create, edit and delete your tasks!";
                lblWelcome.Refresh();
            }
        }

        private void UpdateLoggedUsername()
        {
            using (var context = new ToDoDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == loggedInUserId);
                UserSession.Username = user.Username;
                loggedInUsername = UserSession.Username;

            }
        }


        private void changeHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using( var newPasswordHelperChangeForm = new PasswordHelperChangeForm())
            {
                newPasswordHelperChangeForm.ShowDialog();
            }
        }
    }
}
