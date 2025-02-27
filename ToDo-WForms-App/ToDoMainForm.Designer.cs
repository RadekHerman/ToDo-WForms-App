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
            txtContentInsert = new TextBox();
            dateInsert = new DateTimePicker();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            timeInsert = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.Location = new Point(44, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1032, 282);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblWelcome.Location = new Point(44, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(112, 33);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = SystemColors.GradientActiveCaption;
            btnAddTask.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAddTask.Location = new Point(44, 60);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(87, 91);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(137, 69);
            label1.Name = "label1";
            label1.Size = new Size(745, 26);
            label1.TabIndex = 3;
            label1.Text = "Fill out the boxes and press the \"Add Task\" button to create a new task.";
            // 
            // txtSubjectInsert
            // 
            txtSubjectInsert.Location = new Point(137, 111);
            txtSubjectInsert.Name = "txtSubjectInsert";
            txtSubjectInsert.PlaceholderText = "Subject";
            txtSubjectInsert.Size = new Size(265, 40);
            txtSubjectInsert.TabIndex = 4;
            // 
            // txtContentInsert
            // 
            txtContentInsert.Location = new Point(408, 114);
            txtContentInsert.Name = "txtContentInsert";
            txtContentInsert.PlaceholderText = "Details";
            txtContentInsert.Size = new Size(347, 40);
            txtContentInsert.TabIndex = 4;
            // 
            // dateInsert
            // 
            dateInsert.Format = DateTimePickerFormat.Short;
            dateInsert.Location = new Point(761, 114);
            dateInsert.Name = "dateInsert";
            dateInsert.Size = new Size(183, 40);
            dateInsert.TabIndex = 5;
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
            timeInsert.Location = new Point(964, 114);
            timeInsert.Name = "timeInsert";
            timeInsert.ShowUpDown = true;
            timeInsert.Size = new Size(99, 40);
            timeInsert.TabIndex = 5;
            // 
            // ToDoMainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 451);
            Controls.Add(timeInsert);
            Controls.Add(dateInsert);
            Controls.Add(txtContentInsert);
            Controls.Add(txtSubjectInsert);
            Controls.Add(label1);
            Controls.Add(btnAddTask);
            Controls.Add(lblWelcome);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "ToDoMainForm";
            Text = "ToDoMainForm";
            Load += ToDoMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblWelcome;
        private Button btnAddTask;
        private Label label1;
        private TextBox txtSubjectInsert;
        private TextBox txtContentInsert;
        private DateTimePicker dateInsert;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private DateTimePicker timeInsert;
    }
}