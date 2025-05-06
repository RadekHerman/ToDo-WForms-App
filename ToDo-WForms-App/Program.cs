
namespace ToDo_WForms_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-GB");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-GB");

            // check if database exist if not create it
            using (var context = new ToDoDbContext())
            {
                context.Database.EnsureCreated();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new ToDoMainForm());

            bool loginSuccessful = false;
            LoginForm loginForm;

            while (!loginSuccessful)
            {
                loginForm = new LoginForm();

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loginSuccessful = true;
                    Application.Run(new ToDoMainForm());
                }
                else if (loginForm.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;  // Exit the method and the application
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}