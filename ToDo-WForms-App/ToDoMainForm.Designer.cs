namespace ToDo_WForms_App
{
    partial class ToDoMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblWelcome = new Label();
            btnAddTask = new Button();
            label1 = new Label();
            txtSubjectInsert = new TextBox();
            dateInsert = new DateTimePicker();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            timeInsert = new DateTimePicker();
            txtContentInsert = new TextBox();
            btnClearData = new Button();
            panel1 = new Panel();
            menuStripUser = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            changeUsernameStripMenu = new ToolStripMenuItem();
            changePasswordStripMenu = new ToolStripMenuItem();
            logoutStripMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            menuStripUser.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1060, 236);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblWelcome.Location = new Point(44, 48);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(117, 33);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome";
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = SystemColors.GradientActiveCaption;
            btnAddTask.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAddTask.Location = new Point(3, 6);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(97, 91);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(106, 6);
            label1.Name = "label1";
            label1.Size = new Size(724, 28);
            label1.TabIndex = 6;
            label1.Text = "Fill out the boxes and press the \"Add Task\" button to create a new task.";
            // 
            // txtSubjectInsert
            // 
            txtSubjectInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSubjectInsert.Location = new Point(106, 51);
            txtSubjectInsert.Multiline = true;
            txtSubjectInsert.Name = "txtSubjectInsert";
            txtSubjectInsert.PlaceholderText = "Subject";
            txtSubjectInsert.Size = new Size(237, 46);
            txtSubjectInsert.TabIndex = 0;
            // 
            // dateInsert
            // 
            dateInsert.Format = DateTimePickerFormat.Short;
            dateInsert.Location = new Point(756, 51);
            dateInsert.Name = "dateInsert";
            dateInsert.Size = new Size(183, 40);
            dateInsert.TabIndex = 2;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // timeInsert
            // 
            timeInsert.Format = DateTimePickerFormat.Time;
            timeInsert.Location = new Point(945, 51);
            timeInsert.Name = "timeInsert";
            timeInsert.ShowUpDown = true;
            timeInsert.Size = new Size(106, 40);
            timeInsert.TabIndex = 3;
            // 
            // txtContentInsert
            // 
            txtContentInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtContentInsert.Location = new Point(349, 51);
            txtContentInsert.Multiline = true;
            txtContentInsert.Name = "txtContentInsert";
            txtContentInsert.PlaceholderText = "Details";
            txtContentInsert.ScrollBars = ScrollBars.Vertical;
            txtContentInsert.Size = new Size(401, 90);
            txtContentInsert.TabIndex = 1;
            // 
            // btnClearData
            // 
            btnClearData.BackColor = SystemColors.GradientActiveCaption;
            btnClearData.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnClearData.Location = new Point(3, 103);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(97, 45);
            btnClearData.TabIndex = 5;
            btnClearData.Text = "Clear";
            btnClearData.UseVisualStyleBackColor = false;
            btnClearData.Click += btnClearData_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(timeInsert);
            panel1.Controls.Add(txtContentInsert);
            panel1.Controls.Add(dateInsert);
            panel1.Controls.Add(btnClearData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSubjectInsert);
            panel1.Location = new Point(44, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 158);
            panel1.TabIndex = 8;
            // 
            // menuStripUser
            // 
            menuStripUser.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStripUser.ImageScalingSize = new Size(24, 24);
            menuStripUser.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
            menuStripUser.Location = new Point(0, 0);
            menuStripUser.Name = "menuStripUser";
            menuStripUser.Size = new Size(1165, 32);
            menuStripUser.TabIndex = 9;
            menuStripUser.Text = "User";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeUsernameStripMenu, changePasswordStripMenu, logoutStripMenu });
            userToolStripMenuItem.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(63, 28);
            userToolStripMenuItem.Text = "&User";
            // 
            // changeUsernameStripMenu
            // 
            changeUsernameStripMenu.Name = "changeUsernameStripMenu";
            changeUsernameStripMenu.Size = new Size(270, 34);
            changeUsernameStripMenu.Text = "Change Username";
            changeUsernameStripMenu.Click += changeUsernameStripMenu_Click;
            // 
            // changePasswordStripMenu
            // 
            changePasswordStripMenu.Name = "changePasswordStripMenu";
            changePasswordStripMenu.Size = new Size(270, 34);
            changePasswordStripMenu.Text = "Change Password";
            changePasswordStripMenu.Click += changePasswordStripMenu_Click;
            // 
            // logoutStripMenu
            // 
            logoutStripMenu.Name = "logoutStripMenu";
            logoutStripMenu.Size = new Size(270, 34);
            logoutStripMenu.Text = "Logout";
            logoutStripMenu.Click += logoutStripMenu_Click;
            // 
            // ToDoMainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 520);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(dataGridView1);
            Controls.Add(menuStripUser);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MainMenuStrip = menuStripUser;
            Name = "ToDoMainForm";
            Text = "ToDoMainForm";
            Load += ToDoMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStripUser.ResumeLayout(false);
            menuStripUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblWelcome;
        private Button btnAddTask;
        private Label label1;
        private TextBox txtSubjectInsert;
        private DateTimePicker dateInsert;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private DateTimePicker timeInsert;
        private TextBox txtContentInsert;
        private Button btnClearData;
        private Panel panel1;
        private MenuStrip menuStripUser;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem changeUsernameStripMenu;
        private ToolStripMenuItem changePasswordStripMenu;
        private ToolStripMenuItem logoutStripMenu;
    }
}