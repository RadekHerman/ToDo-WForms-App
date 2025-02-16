namespace ToDo_WForms_App
{
    public partial class ToDoMainForm : Form
    {
        public ToDoMainForm()
        {
            InitializeComponent();
            int loggedInUserId = UserSession.UserId;
            string loggedInUsername = UserSession.Username;
        }
    }
}
