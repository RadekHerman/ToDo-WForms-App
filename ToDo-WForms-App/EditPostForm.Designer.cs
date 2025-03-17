namespace ToDo_WForms_App
{
    partial class EditPostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPostForm));
            lblEdit = new Label();
            lblSubjectEdit = new Label();
            lblDetailsEdit = new Label();
            lblDateEdit = new Label();
            lblTimeEdit = new Label();
            txtSubjectEdit = new TextBox();
            txtContentEdit = new TextBox();
            dateEdit = new DateTimePicker();
            timeEdit = new DateTimePicker();
            btnEditAddPost = new Button();
            btnEditCancel = new Button();
            btnEditRevert = new Button();
            SuspendLayout();
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Location = new Point(13, 20);
            lblEdit.Margin = new Padding(4, 0, 4, 0);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(222, 21);
            lblEdit.TabIndex = 0;
            lblEdit.Text = "Now you can edit your task!";
            // 
            // lblSubjectEdit
            // 
            lblSubjectEdit.AutoSize = true;
            lblSubjectEdit.Location = new Point(13, 59);
            lblSubjectEdit.Name = "lblSubjectEdit";
            lblSubjectEdit.Size = new Size(70, 21);
            lblSubjectEdit.TabIndex = 1;
            lblSubjectEdit.Text = "Subject:";
            // 
            // lblDetailsEdit
            // 
            lblDetailsEdit.AllowDrop = true;
            lblDetailsEdit.AutoSize = true;
            lblDetailsEdit.Location = new Point(13, 134);
            lblDetailsEdit.Name = "lblDetailsEdit";
            lblDetailsEdit.Size = new Size(64, 21);
            lblDetailsEdit.TabIndex = 1;
            lblDetailsEdit.Text = "Details:";
            // 
            // lblDateEdit
            // 
            lblDateEdit.AllowDrop = true;
            lblDateEdit.AutoSize = true;
            lblDateEdit.Location = new Point(13, 275);
            lblDateEdit.Name = "lblDateEdit";
            lblDateEdit.Size = new Size(102, 21);
            lblDateEdit.TabIndex = 1;
            lblDateEdit.Text = "Date To Do:";
            // 
            // lblTimeEdit
            // 
            lblTimeEdit.AllowDrop = true;
            lblTimeEdit.AutoSize = true;
            lblTimeEdit.Location = new Point(13, 337);
            lblTimeEdit.Name = "lblTimeEdit";
            lblTimeEdit.Size = new Size(105, 21);
            lblTimeEdit.TabIndex = 1;
            lblTimeEdit.Text = "Time To Do:";
            // 
            // txtSubjectEdit
            // 
            txtSubjectEdit.Location = new Point(172, 59);
            txtSubjectEdit.Multiline = true;
            txtSubjectEdit.Name = "txtSubjectEdit";
            txtSubjectEdit.Size = new Size(748, 51);
            txtSubjectEdit.TabIndex = 0;
            // 
            // txtContentEdit
            // 
            txtContentEdit.Location = new Point(172, 134);
            txtContentEdit.Multiline = true;
            txtContentEdit.Name = "txtContentEdit";
            txtContentEdit.ScrollBars = ScrollBars.Vertical;
            txtContentEdit.Size = new Size(748, 104);
            txtContentEdit.TabIndex = 1;
            // 
            // dateEdit
            // 
            dateEdit.Format = DateTimePickerFormat.Short;
            dateEdit.Location = new Point(172, 275);
            dateEdit.Name = "dateEdit";
            dateEdit.Size = new Size(188, 29);
            dateEdit.TabIndex = 2;
            // 
            // timeEdit
            // 
            timeEdit.Format = DateTimePickerFormat.Time;
            timeEdit.Location = new Point(172, 329);
            timeEdit.Name = "timeEdit";
            timeEdit.ShowUpDown = true;
            timeEdit.Size = new Size(101, 29);
            timeEdit.TabIndex = 3;
            // 
            // btnEditAddPost
            // 
            btnEditAddPost.Location = new Point(444, 276);
            btnEditAddPost.Name = "btnEditAddPost";
            btnEditAddPost.Size = new Size(122, 90);
            btnEditAddPost.TabIndex = 4;
            btnEditAddPost.Text = "Confirm";
            btnEditAddPost.UseVisualStyleBackColor = true;
            btnEditAddPost.Click += btnEditAddPost_Click;
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(621, 276);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(122, 90);
            btnEditCancel.TabIndex = 5;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
            btnEditCancel.Click += btnEditCancel_Click;
            // 
            // btnEditRevert
            // 
            btnEditRevert.Location = new Point(798, 276);
            btnEditRevert.Name = "btnEditRevert";
            btnEditRevert.Size = new Size(122, 90);
            btnEditRevert.TabIndex = 6;
            btnEditRevert.Text = "Revert";
            btnEditRevert.UseVisualStyleBackColor = true;
            btnEditRevert.Click += btnEditRevert_Click;
            // 
            // EditPostForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 445);
            Controls.Add(btnEditRevert);
            Controls.Add(btnEditCancel);
            Controls.Add(btnEditAddPost);
            Controls.Add(timeEdit);
            Controls.Add(dateEdit);
            Controls.Add(txtContentEdit);
            Controls.Add(txtSubjectEdit);
            Controls.Add(lblTimeEdit);
            Controls.Add(lblDateEdit);
            Controls.Add(lblDetailsEdit);
            Controls.Add(lblSubjectEdit);
            Controls.Add(lblEdit);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "EditPostForm";
            Text = "Your To Do List - Task Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdit;
        private Label lblSubjectEdit;
        private Label lblDetailsEdit;
        private Label lblDateEdit;
        private Label lblTimeEdit;
        private TextBox txtSubjectEdit;
        private TextBox txtContentEdit;
        private DateTimePicker dateEdit;
        private DateTimePicker timeEdit;
        private Button btnEditAddPost;
        private Button btnEditCancel;
        private Button btnEditRevert;
    }
}