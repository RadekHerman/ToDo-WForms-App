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
            lblEdit = new Label();
            lblSubjectEdit = new Label();
            lblDetailsEdit = new Label();
            lblDateEdit = new Label();
            lblTimeEdit = new Label();
            txtSubjectEdit = new TextBox();
            txtContentEdit = new TextBox();
            dateEdit = new DateTimePicker();
            hourEdit = new DateTimePicker();
            btnEditAddPost = new Button();
            btnEditCancel = new Button();
            btnEditClear = new Button();
            SuspendLayout();
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Location = new Point(21, 19);
            lblEdit.Margin = new Padding(4, 0, 4, 0);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(327, 33);
            lblEdit.TabIndex = 0;
            lblEdit.Text = "Now you can edit your task!";
            // 
            // lblSubjectEdit
            // 
            lblSubjectEdit.AutoSize = true;
            lblSubjectEdit.Location = new Point(21, 90);
            lblSubjectEdit.Name = "lblSubjectEdit";
            lblSubjectEdit.Size = new Size(107, 33);
            lblSubjectEdit.TabIndex = 1;
            lblSubjectEdit.Text = "Subject:";
            // 
            // lblDetailsEdit
            // 
            lblDetailsEdit.AllowDrop = true;
            lblDetailsEdit.AutoSize = true;
            lblDetailsEdit.Location = new Point(21, 141);
            lblDetailsEdit.Name = "lblDetailsEdit";
            lblDetailsEdit.Size = new Size(102, 33);
            lblDetailsEdit.TabIndex = 1;
            lblDetailsEdit.Text = "Details:";
            // 
            // lblDateEdit
            // 
            lblDateEdit.AllowDrop = true;
            lblDateEdit.AutoSize = true;
            lblDateEdit.Location = new Point(21, 197);
            lblDateEdit.Name = "lblDateEdit";
            lblDateEdit.Size = new Size(150, 33);
            lblDateEdit.TabIndex = 1;
            lblDateEdit.Text = "Date To Do:";
            // 
            // lblTimeEdit
            // 
            lblTimeEdit.AllowDrop = true;
            lblTimeEdit.AutoSize = true;
            lblTimeEdit.Location = new Point(21, 256);
            lblTimeEdit.Name = "lblTimeEdit";
            lblTimeEdit.Size = new Size(153, 33);
            lblTimeEdit.TabIndex = 1;
            lblTimeEdit.Text = "Time To Do:";
            // 
            // txtSubjectEdit
            // 
            txtSubjectEdit.Location = new Point(134, 87);
            txtSubjectEdit.Multiline = true;
            txtSubjectEdit.Name = "txtSubjectEdit";
            txtSubjectEdit.Size = new Size(438, 40);
            txtSubjectEdit.TabIndex = 2;
            // 
            // txtContentEdit
            // 
            txtContentEdit.Location = new Point(134, 138);
            txtContentEdit.Multiline = true;
            txtContentEdit.Name = "txtContentEdit";
            txtContentEdit.Size = new Size(1039, 40);
            txtContentEdit.TabIndex = 3;
            // 
            // dateEdit
            // 
            dateEdit.Format = DateTimePickerFormat.Short;
            dateEdit.Location = new Point(177, 191);
            dateEdit.Name = "dateEdit";
            dateEdit.Size = new Size(188, 40);
            dateEdit.TabIndex = 4;
            // 
            // hourEdit
            // 
            hourEdit.Format = DateTimePickerFormat.Time;
            hourEdit.Location = new Point(180, 249);
            hourEdit.Name = "hourEdit";
            hourEdit.ShowUpDown = true;
            hourEdit.Size = new Size(101, 40);
            hourEdit.TabIndex = 5;
            // 
            // btnEditAddPost
            // 
            btnEditAddPost.Location = new Point(143, 326);
            btnEditAddPost.Name = "btnEditAddPost";
            btnEditAddPost.Size = new Size(122, 90);
            btnEditAddPost.TabIndex = 6;
            btnEditAddPost.Text = "Confirm";
            btnEditAddPost.UseVisualStyleBackColor = true;
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(303, 330);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(121, 83);
            btnEditCancel.TabIndex = 6;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
            btnEditCancel.Click += btnEditCancel_Click;
            // 
            // btnEditClear
            // 
            btnEditClear.Location = new Point(460, 333);
            btnEditClear.Name = "btnEditClear";
            btnEditClear.Size = new Size(124, 83);
            btnEditClear.TabIndex = 6;
            btnEditClear.Text = "Clear";
            btnEditClear.UseVisualStyleBackColor = true;
            btnEditClear.Click += btnEditClear_Click;
            // 
            // EditPostForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 594);
            Controls.Add(btnEditClear);
            Controls.Add(btnEditCancel);
            Controls.Add(btnEditAddPost);
            Controls.Add(hourEdit);
            Controls.Add(dateEdit);
            Controls.Add(txtContentEdit);
            Controls.Add(txtSubjectEdit);
            Controls.Add(lblTimeEdit);
            Controls.Add(lblDateEdit);
            Controls.Add(lblDetailsEdit);
            Controls.Add(lblSubjectEdit);
            Controls.Add(lblEdit);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EditPostForm";
            Text = "EditPostForm";
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
        private DateTimePicker hourEdit;
        private Button btnEditAddPost;
        private Button btnEditCancel;
        private Button btnEditClear;
    }
}