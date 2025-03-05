namespace ToDo_WForms_App
{
    partial class PassChangeForm
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
            btnPassChangeConfirm = new Button();
            SuspendLayout();
            // 
            // btnPassChangeConfirm
            // 
            btnPassChangeConfirm.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPassChangeConfirm.Location = new Point(196, 242);
            btnPassChangeConfirm.Margin = new Padding(4, 4, 4, 4);
            btnPassChangeConfirm.Name = "btnPassChangeConfirm";
            btnPassChangeConfirm.Size = new Size(107, 32);
            btnPassChangeConfirm.TabIndex = 0;
            btnPassChangeConfirm.Text = "Confirm";
            btnPassChangeConfirm.UseVisualStyleBackColor = true;
            btnPassChangeConfirm.Click += btnPassChangeConfirm_Click;
            // 
            // PassChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 340);
            Controls.Add(btnPassChangeConfirm);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PassChangeForm";
            Text = "PassChangeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPassChangeConfirm;
    }
}