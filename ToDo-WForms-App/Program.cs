using System;
using System.Data.Entity;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;



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
            // check if database exist if not create it
            using (var context = new ToDoDbContext())
            {
                context.Database.EnsureCreated();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}