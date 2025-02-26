using System;
using System.Linq;
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
            lblWelcome.Text = $"Hello, {loggedInUsername}! Welcome to your TO DO LIST! Now you can create, edit and delete your Tasks!";
            MessageBox.Show($"user ID {loggedInUserId}, user name: {loggedInUsername}");
            dateInsert.Format = DateTimePickerFormat.Custom;
            dateInsert.CustomFormat = "dd/MM/yyyy";
            timeInsert.Format = DateTimePickerFormat.Custom;
            timeInsert.CustomFormat = "HH:mm";
        }

        private void ToDoMainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // MessageBox.Show("LoadData method called", "Debug");

            using (var context = new ToDoDbContext())
            {
                // MessageBox.Show("Database context initialized", "Debug");
                var posts = context.Posts
                    .Where(p => p.UserId == loggedInUserId)
                    .Select(p => new
                    {
                        p.DateCreated,
                        p.Subject,
                        p.Content,
                        //p.DateTodo,
                        //p.HourTodo,
                        DateTodo = p.DateTodo.ToString("dd/MM/yyyy"),
                        HourTodo = p.HourTodo.HasValue ? p.HourTodo.Value.ToString(@"hh\:mm") : "",

                    })
                    .ToList();

                if (posts.Count == 0)
                {
                    // MessageBox.Show("No posts found for the current user.", "Debug");
                }
                else
                {
                    //MessageBox.Show($"Retrieved {posts.Count} posts for UserId: {loggedInUserId}", "Debug");
                }

                dataGridView1.DataSource = posts;
                FormatDataGridView();

                dataGridView1.Columns["DateCreated"].HeaderText = "Data utworzenia";
                dataGridView1.Columns["Subject"].HeaderText = "Temat";
                dataGridView1.Columns["Content"].HeaderText = "Opis";
                dataGridView1.Columns["DateTodo"].HeaderText = "Data wydarzenia";
                dataGridView1.Columns["HourTodo"].HeaderText = "Godzina wydarzenia";
            }
        }

        private void FormatDataGridView()
        {
            dataGridView1.Columns["HourTodo"].DefaultCellStyle.Format = @"HH:mm";
            dataGridView1.Columns["DateTodo"].DefaultCellStyle.Format = "dd/MM/yyyy";
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

                MessageBox.Show("Post added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                txtSubjectInsert.Clear();
                txtContentInsert.Clear();
                dateInsert.Value = DateTime.Now;
                timeInsert.Value = DateTime.Now;
            }
        }
    }
}
