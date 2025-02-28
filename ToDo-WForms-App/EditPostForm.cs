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
            txtSubjectEdit.Text = post.Subject;
            txtContentEdit.Text = post.Content;
            //richTextBox1.Text = post.Content;
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
    }
}
