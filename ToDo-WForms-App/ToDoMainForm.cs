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
                        p.DateTodo,
                        p.HourTodo,

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

                dataGridView1.Columns["DateCreated"].HeaderText = "Data utworzenia";
                dataGridView1.Columns["Subject"].HeaderText = "Temat";
                dataGridView1.Columns["Content"].HeaderText = "Opis";
                dataGridView1.Columns["DateTodo"].HeaderText = "Data wydarzenia";
                dataGridView1.Columns["HourTodo"].HeaderText = "Godzina wydarzenia";
            }
        }
    }
}
